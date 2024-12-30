namespace ERP_1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            inpwd = new TextBox();
            button2 = new Button();
            inuser = new TextBox();
            exit1 = new Button();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Controls.Add(inpwd);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(inuser);
            panel1.Location = new Point(214, 160);
            panel1.Name = "panel1";
            panel1.Size = new Size(362, 206);
            panel1.TabIndex = 0;
            // 
            // inpwd
            // 
            inpwd.Font = new Font("Script MT Bold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            inpwd.Location = new Point(66, 87);
            inpwd.Multiline = true;
            inpwd.Name = "inpwd";
            inpwd.PasswordChar = '*';
            inpwd.PlaceholderText = "Password";
            inpwd.Size = new Size(243, 34);
            inpwd.TabIndex = 3;
            inpwd.TextAlign = HorizontalAlignment.Center;
            inpwd.TextChanged += inpwd_TextChanged;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Script MT Bold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button2.Location = new Point(145, 139);
            button2.Name = "button2";
            button2.Size = new Size(93, 28);
            button2.TabIndex = 2;
            button2.Text = "Login";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // inuser
            // 
            inuser.Font = new Font("Script MT Bold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            inuser.Location = new Point(66, 33);
            inuser.Multiline = true;
            inuser.Name = "inuser";
            inuser.PlaceholderText = "User Name";
            inuser.Size = new Size(243, 35);
            inuser.TabIndex = 0;
            inuser.TextAlign = HorizontalAlignment.Center;
            // 
            // exit1
            // 
            exit1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            exit1.AutoSize = true;
            exit1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            exit1.Location = new Point(752, 13);
            exit1.Name = "exit1";
            exit1.Size = new Size(36, 25);
            exit1.TabIndex = 1;
            exit1.Text = "Exit\r\n";
            exit1.UseVisualStyleBackColor = true;
            exit1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.AppWorkspace;
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Zoom;
            panel2.Controls.Add(exit1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 48);
            panel2.TabIndex = 2;
            panel2.Paint += panel2_Paint;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 485);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button exit1;
        private TextBox inpwd;
        private Button button2;
        private TextBox inuser;
        private Panel panel2;
    }
}
