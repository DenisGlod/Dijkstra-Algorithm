namespace Dijkstra_Algorithm
{
    partial class Form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.tbVerticesName = new System.Windows.Forms.TextBox();
            this.tbRibWeight = new System.Windows.Forms.TextBox();
            this.tbResul = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbPointStart = new System.Windows.Forms.TextBox();
            this.tbPointEnd = new System.Windows.Forms.TextBox();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.правкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bDecide = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbVerticesName
            // 
            this.tbVerticesName.AccessibleDescription = "";
            this.tbVerticesName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbVerticesName.Location = new System.Drawing.Point(132, 42);
            this.tbVerticesName.Name = "tbVerticesName";
            this.tbVerticesName.Size = new System.Drawing.Size(230, 20);
            this.tbVerticesName.TabIndex = 1;
            this.toolTip.SetToolTip(this.tbVerticesName, "Введите название вершин: \r\n<название>[пробел]<название>\r\na b c d e f j");
            this.tbVerticesName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbVerticesName_KeyPress);
            // 
            // tbRibWeight
            // 
            this.tbRibWeight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRibWeight.Location = new System.Drawing.Point(132, 79);
            this.tbRibWeight.Name = "tbRibWeight";
            this.tbRibWeight.Size = new System.Drawing.Size(230, 20);
            this.tbRibWeight.TabIndex = 2;
            this.toolTip.SetToolTip(this.tbRibWeight, "Введите вес ребер:\r\na;b=3 d;f=4 c;t=2.4");
            // 
            // tbResul
            // 
            this.tbResul.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbResul.BackColor = System.Drawing.SystemColors.Window;
            this.tbResul.Location = new System.Drawing.Point(12, 201);
            this.tbResul.Multiline = true;
            this.tbResul.Name = "tbResul";
            this.tbResul.ReadOnly = true;
            this.tbResul.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbResul.Size = new System.Drawing.Size(350, 309);
            this.tbResul.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(18, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Название  вершин:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(19, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ребра:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.Location = new System.Drawing.Point(16, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Стартовая вершина:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.Location = new System.Drawing.Point(205, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Конечная вершина:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbPointStart
            // 
            this.tbPointStart.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbPointStart.Location = new System.Drawing.Point(132, 119);
            this.tbPointStart.Name = "tbPointStart";
            this.tbPointStart.Size = new System.Drawing.Size(41, 20);
            this.tbPointStart.TabIndex = 10;
            this.toolTip.SetToolTip(this.tbPointStart, "Введите начальную вершину:\r\na");
            this.tbPointStart.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbPoint_KeyPress);
            // 
            // tbPointEnd
            // 
            this.tbPointEnd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbPointEnd.Location = new System.Drawing.Point(321, 119);
            this.tbPointEnd.Name = "tbPointEnd";
            this.tbPointEnd.Size = new System.Drawing.Size(41, 20);
            this.tbPointEnd.TabIndex = 11;
            this.toolTip.SetToolTip(this.tbPointEnd, "Введите конечную вершину:\r\nb");
            this.tbPointEnd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbPoint_KeyPress);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "ad";
            this.saveFileDialog.Filter = "Algorithm dijkstra (*.ad)|*.ad";
            this.saveFileDialog.Title = "Соранить";
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "ad";
            this.openFileDialog.Filter = "Algorithm dijkstra (*.ad)|*.ad";
            this.openFileDialog.Title = "Открыть";
            // 
            // toolTip
            // 
            this.toolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip.ToolTipTitle = "Подсказка";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.правкаToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(374, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.toolStripMenuItem1,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Image = global::Dijkstra_Algorithm.Properties.Resources.file;
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("открытьToolStripMenuItem.Image")));
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.MOpen_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("сохранитьToolStripMenuItem.Image")));
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.MSave_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(129, 6);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Image = global::Dijkstra_Algorithm.Properties.Resources.exit;
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.MExit_Click);
            // 
            // правкаToolStripMenuItem
            // 
            this.правкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.очиститьToolStripMenuItem});
            this.правкаToolStripMenuItem.Image = global::Dijkstra_Algorithm.Properties.Resources.new_message;
            this.правкаToolStripMenuItem.Name = "правкаToolStripMenuItem";
            this.правкаToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.правкаToolStripMenuItem.Text = "Правка";
            // 
            // очиститьToolStripMenuItem
            // 
            this.очиститьToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("очиститьToolStripMenuItem.Image")));
            this.очиститьToolStripMenuItem.Name = "очиститьToolStripMenuItem";
            this.очиститьToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.очиститьToolStripMenuItem.Text = "Очистить все";
            this.очиститьToolStripMenuItem.Click += new System.EventHandler(this.MClear_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Image = global::Dijkstra_Algorithm.Properties.Resources.about;
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.MAbout_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(0, 154);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(380, 1);
            this.panel1.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(374, 1);
            this.panel2.TabIndex = 18;
            // 
            // bDecide
            // 
            this.bDecide.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bDecide.Image = global::Dijkstra_Algorithm.Properties.Resources.ok;
            this.bDecide.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bDecide.Location = new System.Drawing.Point(147, 165);
            this.bDecide.Name = "bDecide";
            this.bDecide.Size = new System.Drawing.Size(87, 22);
            this.bDecide.TabIndex = 19;
            this.bDecide.Text = "Посчитать";
            this.bDecide.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bDecide.UseVisualStyleBackColor = true;
            this.bDecide.Click += new System.EventHandler(this.BDecide_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 522);
            this.Controls.Add(this.bDecide);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbPointEnd);
            this.Controls.Add(this.tbPointStart);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbResul);
            this.Controls.Add(this.tbRibWeight);
            this.Controls.Add(this.tbVerticesName);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(390, 561);
            this.Name = "Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Алгоритм Дейкстры";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbVerticesName;
        private System.Windows.Forms.TextBox tbRibWeight;
        private System.Windows.Forms.TextBox tbResul;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbPointStart;
        private System.Windows.Forms.TextBox tbPointEnd;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem правкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очиститьToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bDecide;
    }
}

