using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace Dijkstra_Algorithm
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Обработчик нажатия клавиши Решить
        /// </summary>
        private void BDecide_Click(object sender, System.EventArgs e)
        {
            string vName = tbVerticesName.Text;
            string vWeight = tbRibWeight.Text;
            string pStart = tbPointStart.Text;
            string pEnd = tbPointEnd.Text;

            tbResul.AppendText("Назавние вершин: " + vName + "\r\n"
                            + "Ребра: " + vWeight + "\r\n"
                            + "Стартовая вершина: " + pStart + "\r\n"
                            + "Конечная вершина: " + pEnd + "\r\n- - - - - - - - - - - - - - - - - - - -\r\n");

            if (vName.Trim(' ').Length == 0 ||
                vWeight.Trim(' ').Length == 0 ||
                pStart.Trim(' ').Length == 0 ||
                pEnd.Trim(' ').Length == 0)
            {
                MessageBox.Show("Одно или несколько полей пусты!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var listPoints = new List<Point>();
            foreach (var str in vName.Split(' '))
            {
                if (str.Equals(pStart))
                {
                    listPoints.Add(new Point(str, 0, new List<string> { pStart }, 0));
                    continue;
                }
                listPoints.Add(new Point(str, double.MaxValue));
            }

            var listRibs = new List<Rib>();
            foreach (string str in vWeight.Split(' '))
            {
                var temp = str.Split('=');
                var nameRib = temp[0].Split(',');
                listRibs.Add(new Rib(nameRib[0], nameRib[1], double.Parse(temp[1])));
            }
            var warning = listRibs.FindAll(r => r.IsNegativeMeaning());
            if (warning.Count > 0)
            {
                var strWord = warning.Count > 1 ? " имеют" : " имеет";
                var strRib = warning.Count > 1 ? "Ребра: " : "Ребро: ";
                MessageBox.Show(strRib + String.Join(" ", warning) + strWord + " отрицательный вес", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            bool flag = true;
            int i = 1;
            while (flag)
            {
                foreach (var point in listPoints.FindAll(p => p.Check == 0))
                {
                    point.Check = 1;
                    tbResul.AppendText("----> Вершина: " + point.Name + " <----\r\n" + point.GetPathToString() + " = " + point.Value + "\r\n- - - - Итерация " + i++ + "- - - -\r\n");
                    foreach (var rib in listRibs.FindAll(r => point.Name.Equals(r.FirstPoint)))
                    {
                        foreach (var pSecond in listPoints.FindAll(p => rib.SecondPoint.Equals(p.Name)))
                        {
                            var sum = point.Value + rib.Weight;
                            pSecond.Check = 0;
                            if (sum < pSecond.Value)
                            {
                                pSecond.Path.Clear();
                                pSecond.Path.AddRange(point.Path.ToArray());
                                pSecond.Path.Add(rib.SecondPoint);
                                pSecond.Value = sum;
                            }
                            tbResul.AppendText(pSecond.GetPathToString() + " = " + pSecond.Value + "\r\n");
                        }
                    }
                }
                if (listPoints.TrueForAll(x => x.Check == 1))
                {
                    flag = false;
                }
            }
            Point result = listPoints.Find(p => p.Name.Equals(pEnd));
            tbResul.AppendText("Ответ: кратчайший путь до вершины " + pEnd + " является " + result.GetPathToString() + " = " + result.Value);
        }

        /// <summary>
        /// Очистка всех полей ввода
        /// </summary>
        private void MClear_Click(object sender, System.EventArgs e)
        {
            tbVerticesName.Clear();
            tbRibWeight.Clear();
            tbPointStart.Clear();
            tbPointEnd.Clear();
            tbResul.Clear();
        }

        /// <summary>
        /// Данный метод проверяет ввод данных в поле ввода названия вершин
        /// </summary>
        private void TbVerticesName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsLetter(ch) && ch != 8 && ch != 32)
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Данный метод проверяет ввод данных в поле ввода начальной и конечной точки
        /// </summary>
        private void TbPoint_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsLetter(ch) && ch != 8)
            {
                e.Handled = true;
            }

            if (((TextBox)sender).TextLength == 1 && ch != 8)
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Сохранение проекта
        /// </summary>
        private void MSave_Click(object sender, System.EventArgs e)
        {
            ProjectFile pf = new ProjectFile
            {
                Names = tbVerticesName.Text,
                Weight = tbRibWeight.Text,
                Start = tbPointStart.Text,
                End = tbPointEnd.Text,
                Result = tbResul.Text
            };
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = saveFileDialog.FileName;
                using (FileStream fs = (FileStream)saveFileDialog.OpenFile())
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(fs, pf);
                }
                MessageBox.Show("Проект сохранен\r\n" + fileName, "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Открытие сохраненного проекта
        /// </summary>
        private void MOpen_Click(object sender, System.EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialog.FileName;
                using (FileStream fs = (FileStream)openFileDialog.OpenFile())
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    ProjectFile file = (ProjectFile)formatter.Deserialize(fs);
                    tbVerticesName.Text = file.Names;
                    tbRibWeight.Text = file.Weight;
                    tbPointStart.Text = file.Start;
                    tbPointEnd.Text = file.End;
                    tbResul.Text = file.Result;
                }
            }
        }

        /// <summary>
        /// Выход из программы
        /// </summary>
        private void MExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Открытие окна О программе
        /// </summary>
        private void MAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Алгори́тм Де́йкстры (англ. Dijkstra’s algorithm) — алгоритм"
                           + "\r\nна графах, изобретённый нидерландским учёным"
                           + "\r\nЭдсгером Дейкстрой в 1959 году. Находит кратчайшие"
                           + "\r\nпути от однойиз вершин графа до всех остальных."
                           + "\r\nАлгоритм работает только для графов без рёбер"
                           + "\r\nотрицательного веса. Алгоритм широко применяется"
                           + "\r\nв программировании и технологиях, например, его"
                           + "\r\nиспользуют протоколы маршрутизации OSPF и IS-IS.", "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
