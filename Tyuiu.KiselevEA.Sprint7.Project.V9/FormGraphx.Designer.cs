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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGraphx));
            groupBox1 = new GroupBox();
            chartGraphx_KEA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            menuStrip1 = new MenuStrip();
            выберитеГрафикToolStripMenuItem = new ToolStripMenuItem();
            годВыпускаToolStripMenuItem = new ToolStripMenuItem();
            жанрToolStripMenuItem = new ToolStripMenuItem();
            категорияToolStripMenuItem = new ToolStripMenuItem();
            длительностьToolStripMenuItem = new ToolStripMenuItem();
            режиссерToolStripMenuItem = new ToolStripMenuItem();
            бюджетToolStripMenuItem = new ToolStripMenuItem();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            buttonBack_KEA = new Button();
            pictureBox1 = new PictureBox();
            openFileDialogGraphx_KEA = new OpenFileDialog();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartGraphx_KEA).BeginInit();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.None;
            groupBox1.Controls.Add(chartGraphx_KEA);
            groupBox1.Controls.Add(menuStrip1);
            groupBox1.ForeColor = SystemColors.ButtonFace;
            groupBox1.Location = new Point(7, 104);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1303, 503);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "График";
            // 
            // chartGraphx_KEA
            // 
            chartGraphx_KEA.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            chartArea1.Name = "ChartArea1";
            chartGraphx_KEA.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartGraphx_KEA.Legends.Add(legend1);
            chartGraphx_KEA.Location = new Point(9, 46);
            chartGraphx_KEA.Name = "chartGraphx_KEA";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartGraphx_KEA.Series.Add(series1);
            chartGraphx_KEA.Size = new Size(1288, 451);
            chartGraphx_KEA.TabIndex = 1;
            chartGraphx_KEA.Text = "chart1";
            chartGraphx_KEA.Click += chartGraphx_KEA_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { выберитеГрафикToolStripMenuItem });
            menuStrip1.Location = new Point(3, 19);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1297, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // выберитеГрафикToolStripMenuItem
            // 
            выберитеГрафикToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { годВыпускаToolStripMenuItem, жанрToolStripMenuItem, категорияToolStripMenuItem, длительностьToolStripMenuItem, режиссерToolStripMenuItem, бюджетToolStripMenuItem });
            выберитеГрафикToolStripMenuItem.Name = "выберитеГрафикToolStripMenuItem";
            выберитеГрафикToolStripMenuItem.Size = new Size(116, 20);
            выберитеГрафикToolStripMenuItem.Text = "Выберите график";
            // 
            // годВыпускаToolStripMenuItem
            // 
            годВыпускаToolStripMenuItem.Name = "годВыпускаToolStripMenuItem";
            годВыпускаToolStripMenuItem.Size = new Size(151, 22);
            годВыпускаToolStripMenuItem.Text = "Год выпуска";
            годВыпускаToolStripMenuItem.Click += годВыпускаToolStripMenuItem_Click;
            // 
            // жанрToolStripMenuItem
            // 
            жанрToolStripMenuItem.Name = "жанрToolStripMenuItem";
            жанрToolStripMenuItem.Size = new Size(151, 22);
            жанрToolStripMenuItem.Text = "Жанр";
            // 
            // категорияToolStripMenuItem
            // 
            категорияToolStripMenuItem.Name = "категорияToolStripMenuItem";
            категорияToolStripMenuItem.Size = new Size(151, 22);
            категорияToolStripMenuItem.Text = "Категория";
            // 
            // длительностьToolStripMenuItem
            // 
            длительностьToolStripMenuItem.Name = "длительностьToolStripMenuItem";
            длительностьToolStripMenuItem.Size = new Size(151, 22);
            длительностьToolStripMenuItem.Text = "Длительность";
            // 
            // режиссерToolStripMenuItem
            // 
            режиссерToolStripMenuItem.Name = "режиссерToolStripMenuItem";
            режиссерToolStripMenuItem.Size = new Size(151, 22);
            режиссерToolStripMenuItem.Text = "Режиссер";
            // 
            // бюджетToolStripMenuItem
            // 
            бюджетToolStripMenuItem.Name = "бюджетToolStripMenuItem";
            бюджетToolStripMenuItem.Size = new Size(151, 22);
            бюджетToolStripMenuItem.Text = "Бюджет";
            бюджетToolStripMenuItem.Click += бюджетToolStripMenuItem_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ActiveCaptionText;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8, Column9, Column10 });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.InactiveCaptionText;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.GridColor = SystemColors.MenuHighlight;
            dataGridView1.Location = new Point(924, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(181, 178);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Column1";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Column2";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Column3";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Column4";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Column5";
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.HeaderText = "Column6";
            Column6.Name = "Column6";
            // 
            // Column7
            // 
            Column7.HeaderText = "Column7";
            Column7.Name = "Column7";
            // 
            // Column8
            // 
            Column8.HeaderText = "Column8";
            Column8.Name = "Column8";
            // 
            // Column9
            // 
            Column9.HeaderText = "Column9";
            Column9.Name = "Column9";
            // 
            // Column10
            // 
            Column10.HeaderText = "Column10";
            Column10.Name = "Column10";
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
            // openFileDialogGraphx_KEA
            // 
            openFileDialogGraphx_KEA.FileName = "openFileDialog1";
            // 
            // FormGraphx
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1322, 619);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox1);
            Controls.Add(buttonBack_KEA);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            Name = "FormGraphx";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormGraphx";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartGraphx_KEA).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private OpenFileDialog openFileDialogGraphx_KEA;
        private DataGridView dataGridView1;
        private ToolStripMenuItem бюджетToolStripMenuItem;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
    }
}