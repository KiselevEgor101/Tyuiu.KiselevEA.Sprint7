namespace Tyuiu.KiselevEA.Sprint7.Project.V9
{
    partial class FormGuides
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGuides));
            textBoxGuidesMenu_KEA = new TextBox();
            buttonGuidesClose_KEA = new Button();
            textBoxGroup_KEA = new TextBox();
            buttonMenu_KEA = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // textBoxGuidesMenu_KEA
            // 
            textBoxGuidesMenu_KEA.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxGuidesMenu_KEA.BackColor = Color.FromArgb(64, 64, 64);
            textBoxGuidesMenu_KEA.BorderStyle = BorderStyle.None;
            textBoxGuidesMenu_KEA.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBoxGuidesMenu_KEA.ForeColor = SystemColors.Window;
            textBoxGuidesMenu_KEA.Location = new Point(-3, -3);
            textBoxGuidesMenu_KEA.Margin = new Padding(4);
            textBoxGuidesMenu_KEA.Multiline = true;
            textBoxGuidesMenu_KEA.Name = "textBoxGuidesMenu_KEA";
            textBoxGuidesMenu_KEA.ReadOnly = true;
            textBoxGuidesMenu_KEA.Size = new Size(1016, 259);
            textBoxGuidesMenu_KEA.TabIndex = 0;
            textBoxGuidesMenu_KEA.TabStop = false;
            textBoxGuidesMenu_KEA.TextChanged += textBoxGuidesMenu_KEA_TextChanged;
            // 
            // buttonGuidesClose_KEA
            // 
            buttonGuidesClose_KEA.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonGuidesClose_KEA.BackColor = Color.FromArgb(48, 48, 48);
            buttonGuidesClose_KEA.FlatStyle = FlatStyle.Popup;
            buttonGuidesClose_KEA.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonGuidesClose_KEA.ForeColor = SystemColors.Window;
            buttonGuidesClose_KEA.Location = new Point(887, 563);
            buttonGuidesClose_KEA.Margin = new Padding(4);
            buttonGuidesClose_KEA.Name = "buttonGuidesClose_KEA";
            buttonGuidesClose_KEA.Size = new Size(126, 50);
            buttonGuidesClose_KEA.TabIndex = 1;
            buttonGuidesClose_KEA.Text = "Закрыть";
            buttonGuidesClose_KEA.UseVisualStyleBackColor = false;
            buttonGuidesClose_KEA.Click += buttonGuidesClose_KEA_Click;
            // 
            // textBoxGroup_KEA
            // 
            textBoxGroup_KEA.BackColor = Color.FromArgb(64, 64, 64);
            textBoxGroup_KEA.BorderStyle = BorderStyle.None;
            textBoxGroup_KEA.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBoxGroup_KEA.ForeColor = SystemColors.ButtonHighlight;
            textBoxGroup_KEA.Location = new Point(13, 551);
            textBoxGroup_KEA.Margin = new Padding(4);
            textBoxGroup_KEA.Multiline = true;
            textBoxGroup_KEA.Name = "textBoxGroup_KEA";
            textBoxGroup_KEA.Size = new Size(145, 66);
            textBoxGroup_KEA.TabIndex = 2;
            textBoxGroup_KEA.Text = "Выберите\r\nраздел:";
            // 
            // buttonMenu_KEA
            // 
            buttonMenu_KEA.BackColor = Color.FromArgb(48, 48, 48);
            buttonMenu_KEA.ForeColor = SystemColors.ButtonHighlight;
            buttonMenu_KEA.Location = new Point(114, 547);
            buttonMenu_KEA.Margin = new Padding(4);
            buttonMenu_KEA.Name = "buttonMenu_KEA";
            buttonMenu_KEA.Size = new Size(109, 66);
            buttonMenu_KEA.TabIndex = 3;
            buttonMenu_KEA.Text = "Главное\r\nменю";
            buttonMenu_KEA.UseVisualStyleBackColor = false;
            buttonMenu_KEA.Click += buttonMenu_KEA_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(48, 48, 48);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(231, 547);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(121, 66);
            button1.TabIndex = 4;
            button1.Text = "Приложение";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // FormGuides
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1029, 630);
            Controls.Add(button1);
            Controls.Add(buttonMenu_KEA);
            Controls.Add(textBoxGroup_KEA);
            Controls.Add(buttonGuidesClose_KEA);
            Controls.Add(textBoxGuidesMenu_KEA);
            Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "FormGuides";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormGuides";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxGuidesMenu_KEA;
        private Button buttonGuidesClose_KEA;
        private TextBox textBoxGroup_KEA;
        private Button buttonMenu_KEA;
        private Button button1;
    }
}