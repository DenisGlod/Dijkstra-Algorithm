namespace Алгоритм_Дейкстры
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
            this.bClear = new System.Windows.Forms.Button();
            this.bOpen = new System.Windows.Forms.Button();
            this.bSave = new System.Windows.Forms.Button();
            this.bDecide = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // tbVerticesName
            // 
            this.tbVerticesName.AccessibleDescription = "";
            this.tbVerticesName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbVerticesName.Location = new System.Drawing.Point(132, 12);
            this.tbVerticesName.Name = "tbVerticesName";
            this.tbVerticesName.Size = new System.Drawing.Size(202, 20);
            this.tbVerticesName.TabIndex = 1;
            this.toolTip.SetToolTip(this.tbVerticesName, "Введите название вершин: \r\n<название>[пробел]<название>\r\na b c d e f j");
            this.tbVerticesName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbVerticesName_KeyPress);
            // 
            // tbRibWeight
            // 
            this.tbRibWeight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRibWeight.Location = new System.Drawing.Point(132, 49);
            this.tbRibWeight.Name = "tbRibWeight";
            this.tbRibWeight.Size = new System.Drawing.Size(202, 20);
            this.tbRibWeight.TabIndex = 2;
            this.toolTip.SetToolTip(this.tbRibWeight, "Введите вес ребер:\r\na;b=3 d;f=4 c;t=2.4");
            // 
            // tbResul
            // 
            this.tbResul.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbResul.BackColor = System.Drawing.SystemColors.Window;
            this.tbResul.Location = new System.Drawing.Point(12, 169);
            this.tbResul.Multiline = true;
            this.tbResul.Name = "tbResul";
            this.tbResul.ReadOnly = true;
            this.tbResul.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbResul.Size = new System.Drawing.Size(322, 305);
            this.tbResul.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Название  вершин:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(13, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ребра:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.Location = new System.Drawing.Point(13, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Стартовая вершина:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.Location = new System.Drawing.Point(150, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Конечная вершина:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbPointStart
            // 
            this.tbPointStart.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbPointStart.Location = new System.Drawing.Point(132, 89);
            this.tbPointStart.Name = "tbPointStart";
            this.tbPointStart.Size = new System.Drawing.Size(41, 20);
            this.tbPointStart.TabIndex = 10;
            this.tbPointStart.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbPoint_KeyPress);
            // 
            // tbPointEnd
            // 
            this.tbPointEnd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbPointEnd.Location = new System.Drawing.Point(293, 89);
            this.tbPointEnd.Name = "tbPointEnd";
            this.tbPointEnd.Size = new System.Drawing.Size(41, 20);
            this.tbPointEnd.TabIndex = 11;
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
            // bClear
            // 
            this.bClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bClear.Image = global::Алгоритм_Дейкстры.Properties.Resources.eraser;
            this.bClear.Location = new System.Drawing.Point(300, 127);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(34, 27);
            this.bClear.TabIndex = 14;
            this.bClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip.SetToolTip(this.bClear, "Очистить");
            this.bClear.UseVisualStyleBackColor = true;
            this.bClear.Click += new System.EventHandler(this.BClear_Click);
            // 
            // bOpen
            // 
            this.bOpen.Image = global::Алгоритм_Дейкстры.Properties.Resources.open;
            this.bOpen.Location = new System.Drawing.Point(55, 127);
            this.bOpen.Name = "bOpen";
            this.bOpen.Size = new System.Drawing.Size(40, 27);
            this.bOpen.TabIndex = 13;
            this.toolTip.SetToolTip(this.bOpen, "Открыть проект");
            this.bOpen.UseVisualStyleBackColor = true;
            this.bOpen.Click += new System.EventHandler(this.BOpen_Click);
            // 
            // bSave
            // 
            this.bSave.Image = global::Алгоритм_Дейкстры.Properties.Resources.save;
            this.bSave.Location = new System.Drawing.Point(12, 127);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(37, 27);
            this.bSave.TabIndex = 12;
            this.toolTip.SetToolTip(this.bSave, "Сохранить проект");
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.BSave_Click);
            // 
            // bDecide
            // 
            this.bDecide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bDecide.Image = global::Алгоритм_Дейкстры.Properties.Resources.ok;
            this.bDecide.Location = new System.Drawing.Point(244, 127);
            this.bDecide.Name = "bDecide";
            this.bDecide.Size = new System.Drawing.Size(50, 27);
            this.bDecide.TabIndex = 4;
            this.bDecide.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip.SetToolTip(this.bDecide, "Решить");
            this.bDecide.UseVisualStyleBackColor = true;
            this.bDecide.Click += new System.EventHandler(this.BDecide_Click);
            // 
            // toolTip
            // 
            this.toolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip.ToolTipTitle = "Подсказка";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 486);
            this.Controls.Add(this.bClear);
            this.Controls.Add(this.bOpen);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.tbPointEnd);
            this.Controls.Add(this.tbPointStart);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bDecide);
            this.Controls.Add(this.tbResul);
            this.Controls.Add(this.tbRibWeight);
            this.Controls.Add(this.tbVerticesName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(362, 330);
            this.Name = "Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Алгоритм Дейкстры";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbVerticesName;
        private System.Windows.Forms.TextBox tbRibWeight;
        private System.Windows.Forms.TextBox tbResul;
        private System.Windows.Forms.Button bDecide;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbPointStart;
        private System.Windows.Forms.TextBox tbPointEnd;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Button bOpen;
        private System.Windows.Forms.Button bClear;
        private System.Windows.Forms.ToolTip toolTip;
    }
}

