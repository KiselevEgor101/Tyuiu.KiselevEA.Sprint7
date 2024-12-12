namespace Tyuiu.KiselevEA.Sprint7.Project.V9
{
    partial class FormMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            pictureBoxLogo_KEA = new PictureBox();
            textBoxName_KEA = new TextBox();
            buttonClose_KEA = new Button();
            buttonGuide_KEA = new Button();
            buttonAbout_KEA = new Button();
            buttonStart_KEA = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo_KEA).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxLogo_KEA
            // 
            pictureBoxLogo_KEA.Image = (Image)resources.GetObject("pictureBoxLogo_KEA.Image");
            pictureBoxLogo_KEA.Location = new Point(0, 1);
            pictureBoxLogo_KEA.Name = "pictureBoxLogo_KEA";
            pictureBoxLogo_KEA.Padding = new Padding(1);
            pictureBoxLogo_KEA.Size = new Size(413, 385);
            pictureBoxLogo_KEA.TabIndex = 0;
            pictureBoxLogo_KEA.TabStop = false;
            // 
            // textBoxName_KEA
            // 
            textBoxName_KEA.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxName_KEA.BackColor = Color.FromArgb(64, 64, 64);
            textBoxName_KEA.BorderStyle = BorderStyle.None;
            textBoxName_KEA.Font = new Font("Segoe UI Semibold", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBoxName_KEA.ForeColor = SystemColors.Window;
            textBoxName_KEA.Location = new Point(419, 63);
            textBoxName_KEA.Multiline = true;
            textBoxName_KEA.Name = "textBoxName_KEA";
            textBoxName_KEA.ReadOnly = true;
            textBoxName_KEA.Size = new Size(423, 98);
            textBoxName_KEA.TabIndex = 0;
            textBoxName_KEA.TabStop = false;
            textBoxName_KEA.Text = "ClipVaultS:\r\nКаталог видеоклипов";
            // 
            // buttonClose_KEA
            // 
            buttonClose_KEA.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonClose_KEA.BackColor = Color.FromArgb(48, 48, 48);
            buttonClose_KEA.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonClose_KEA.ForeColor = SystemColors.Window;
            buttonClose_KEA.Location = new Point(678, 397);
            buttonClose_KEA.Name = "buttonClose_KEA";
            buttonClose_KEA.Size = new Size(110, 41);
            buttonClose_KEA.TabIndex = 2;
            buttonClose_KEA.Text = "Выход";
            buttonClose_KEA.UseVisualStyleBackColor = false;
            buttonClose_KEA.Click += buttonClose_KEA_Click;
            // 
            // buttonGuide_KEA
            // 
            buttonGuide_KEA.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonGuide_KEA.BackColor = Color.FromArgb(48, 48, 48);
            buttonGuide_KEA.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonGuide_KEA.ForeColor = SystemColors.Window;
            buttonGuide_KEA.Location = new Point(12, 400);
            buttonGuide_KEA.Name = "buttonGuide_KEA";
            buttonGuide_KEA.Size = new Size(110, 40);
            buttonGuide_KEA.TabIndex = 3;
            buttonGuide_KEA.Text = "Руководство";
            buttonGuide_KEA.UseVisualStyleBackColor = false;
            // 
            // buttonAbout_KEA
            // 
            buttonAbout_KEA.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonAbout_KEA.BackColor = Color.FromArgb(48, 48, 48);
            buttonAbout_KEA.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonAbout_KEA.ForeColor = SystemColors.Window;
            buttonAbout_KEA.Location = new Point(128, 400);
            buttonAbout_KEA.Name = "buttonAbout_KEA";
            buttonAbout_KEA.Size = new Size(110, 40);
            buttonAbout_KEA.TabIndex = 4;
            buttonAbout_KEA.Text = "О программе";
            buttonAbout_KEA.UseVisualStyleBackColor = false;
            buttonAbout_KEA.Click += buttonAbout_KEA_Click;
            // 
            // buttonStart_KEA
            // 
            buttonStart_KEA.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonStart_KEA.BackColor = Color.FromArgb(48, 48, 48);
            buttonStart_KEA.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonStart_KEA.ForeColor = SystemColors.Window;
            buttonStart_KEA.Location = new Point(431, 167);
            buttonStart_KEA.Name = "buttonStart_KEA";
            buttonStart_KEA.Size = new Size(268, 56);
            buttonStart_KEA.TabIndex = 5;
            buttonStart_KEA.Text = "Запустить программу";
            buttonStart_KEA.UseVisualStyleBackColor = false;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(800, 450);
            Controls.Add(buttonStart_KEA);
            Controls.Add(buttonAbout_KEA);
            Controls.Add(buttonGuide_KEA);
            Controls.Add(buttonClose_KEA);
            Controls.Add(textBoxName_KEA);
            Controls.Add(pictureBoxLogo_KEA);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormMenu";
            Text = "ClipVaultS";
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo_KEA).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxLogo_KEA;
        private TextBox textBoxName_KEA;
        private Button buttonClose_KEA;
        private Button buttonGuide_KEA;
        private Button buttonAbout_KEA;
        private Button buttonStart_KEA;
    }
}
