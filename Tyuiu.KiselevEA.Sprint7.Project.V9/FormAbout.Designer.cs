﻿namespace Tyuiu.KiselevEA.Sprint7.Project.V9
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            textBoxAbout_KEA = new TextBox();
            buttonOK_KEA = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBoxAbout_KEA
            // 
            textBoxAbout_KEA.BackColor = Color.FromArgb(64, 64, 64);
            textBoxAbout_KEA.BorderStyle = BorderStyle.None;
            textBoxAbout_KEA.ForeColor = SystemColors.Window;
            textBoxAbout_KEA.Location = new Point(171, 18);
            textBoxAbout_KEA.Multiline = true;
            textBoxAbout_KEA.Name = "textBoxAbout_KEA";
            textBoxAbout_KEA.ReadOnly = true;
            textBoxAbout_KEA.Size = new Size(287, 191);
            textBoxAbout_KEA.TabIndex = 0;
            textBoxAbout_KEA.TabStop = false;
            textBoxAbout_KEA.Text = resources.GetString("textBoxAbout_KEA.Text");
            textBoxAbout_KEA.TextChanged += textBox1_TextChanged;
            // 
            // buttonOK_KEA
            // 
            buttonOK_KEA.BackColor = Color.FromArgb(48, 48, 48);
            buttonOK_KEA.FlatStyle = FlatStyle.Popup;
            buttonOK_KEA.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonOK_KEA.ForeColor = SystemColors.Window;
            buttonOK_KEA.Location = new Point(369, 210);
            buttonOK_KEA.Name = "buttonOK_KEA";
            buttonOK_KEA.Size = new Size(81, 32);
            buttonOK_KEA.TabIndex = 1;
            buttonOK_KEA.Text = "Закрыть";
            buttonOK_KEA.UseVisualStyleBackColor = false;
            buttonOK_KEA.Click += buttonOK_KEA_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(153, 197);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(461, 249);
            Controls.Add(pictureBox1);
            Controls.Add(buttonOK_KEA);
            Controls.Add(textBoxAbout_KEA);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxAbout_KEA;
        private Button buttonOK_KEA;
        private PictureBox pictureBox1;
    }
}