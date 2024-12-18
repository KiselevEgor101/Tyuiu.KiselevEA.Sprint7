namespace Tyuiu.KiselevEA.Sprint7.Project.V9
{
    partial class FormGraphx
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGraphx));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            groupBox1 = new GroupBox();
            menuStrip1 = new MenuStrip();
            выберитеГрафикToolStripMenuItem = new ToolStripMenuItem();
            годВыпускаToolStripMenuItem = new ToolStripMenuItem();
            жанрToolStripMenuItem = new ToolStripMenuItem();
            категорияToolStripMenuItem = new ToolStripMenuItem();
            длительностьToolStripMenuItem = new ToolStripMenuItem();
            режиссерToolStripMenuItem = new ToolStripMenuItem();
            buttonBack_KEA = new Button();
            pictureBox1 = new PictureBox();
            chartGraphx_KEA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBox1.SuspendLayout();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartGraphx_KEA).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(chartGraphx_KEA);
            groupBox1.Controls.Add(menuStrip1);
            groupBox1.ForeColor = SystemColors.ButtonFace;
            groupBox1.Location = new Point(3, 96);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1008, 342);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "График";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { выберитеГрафикToolStripMenuItem });
            menuStrip1.Location = new Point(3, 19);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1002, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // выберитеГрафикToolStripMenuItem
            // 
            выберитеГрафикToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { годВыпускаToolStripMenuItem, жанрToolStripMenuItem, категорияToolStripMenuItem, длительностьToolStripMenuItem, режиссерToolStripMenuItem });
            выберитеГрафикToolStripMenuItem.Name = "выберитеГрафикToolStripMenuItem";
            выберитеГрафикToolStripMenuItem.Size = new Size(116, 20);
            выберитеГрафикToolStripMenuItem.Text = "Выберите график";
            // 
            // годВыпускаToolStripMenuItem
            // 
            годВыпускаToolStripMenuItem.Name = "годВыпускаToolStripMenuItem";
            годВыпускаToolStripMenuItem.Size = new Size(180, 22);
            годВыпускаToolStripMenuItem.Text = "Год выпуска";
            годВыпускаToolStripMenuItem.Click += годВыпускаToolStripMenuItem_Click;
            // 
            // жанрToolStripMenuItem
            // 
            жанрToolStripMenuItem.Name = "жанрToolStripMenuItem";
            жанрToolStripMenuItem.Size = new Size(180, 22);
            жанрToolStripMenuItem.Text = "Жанр";
            // 
            // категорияToolStripMenuItem
            // 
            категорияToolStripMenuItem.Name = "категорияToolStripMenuItem";
            категорияToolStripMenuItem.Size = new Size(180, 22);
            категорияToolStripMenuItem.Text = "Категория";
            // 
            // длительностьToolStripMenuItem
            // 
            длительностьToolStripMenuItem.Name = "длительностьToolStripMenuItem";
            длительностьToolStripMenuItem.Size = new Size(180, 22);
            длительностьToolStripMenuItem.Text = "Длительность";
            // 
            // режиссерToolStripMenuItem
            // 
            режиссерToolStripMenuItem.Name = "режиссерToolStripMenuItem";
            режиссерToolStripMenuItem.Size = new Size(180, 22);
            режиссерToolStripMenuItem.Text = "Режиссер";
            // 
            // buttonBack_KEA
            // 
            buttonBack_KEA.BackColor = Color.FromArgb(48, 48, 48);
            buttonBack_KEA.FlatStyle = FlatStyle.Popup;
            buttonBack_KEA.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonBack_KEA.ForeColor = SystemColors.ButtonFace;
            buttonBack_KEA.Location = new Point(39, 12);
            buttonBack_KEA.Name = "buttonBack_KEA";
            buttonBack_KEA.Size = new Size(104, 32);
            buttonBack_KEA.TabIndex = 1;
            buttonBack_KEA.Text = "Назад";
            buttonBack_KEA.UseVisualStyleBackColor = false;
            buttonBack_KEA.Click += buttonBack_KEA_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(7, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // chartGraphx_KEA
            // 
            chartArea1.Name = "ChartArea1";
            chartGraphx_KEA.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartGraphx_KEA.Legends.Add(legend1);
            chartGraphx_KEA.Location = new Point(5, 47);
            chartGraphx_KEA.Name = "chartGraphx_KEA";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartGraphx_KEA.Series.Add(series1);
            chartGraphx_KEA.Size = new Size(994, 300);
            chartGraphx_KEA.TabIndex = 1;
            chartGraphx_KEA.Text = "chart1";
            chartGraphx_KEA.Click += chartGraphx_KEA_Click;
            // 
            // FormGraphx
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1014, 450);
            Controls.Add(pictureBox1);
            Controls.Add(buttonBack_KEA);
            Controls.Add(groupBox1);
            MainMenuStrip = menuStrip1;
            Name = "FormGraphx";
            Text = "FormGraphx";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartGraphx_KEA).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button buttonBack_KEA;
        private PictureBox pictureBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem выберитеГрафикToolStripMenuItem;
        private ToolStripMenuItem годВыпускаToolStripMenuItem;
        private ToolStripMenuItem жанрToolStripMenuItem;
        private ToolStripMenuItem категорияToolStripMenuItem;
        private ToolStripMenuItem длительностьToolStripMenuItem;
        private ToolStripMenuItem режиссерToolStripMenuItem;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGraphx_KEA;
    }
}