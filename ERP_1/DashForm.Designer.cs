
namespace ERP_1
{
    partial class DashForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashForm));
            panel1 = new Panel();
            button4 = new Button();
            button3 = new Button();
            btnUcreate = new Button();
            button1 = new Button();
            lblusername = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            panel2 = new Panel();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(btnUcreate);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(lblusername);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(203, 511);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // button4
            // 
            button4.Font = new Font("Script MT Bold", 11.25F, FontStyle.Bold);
            button4.Location = new Point(1, 257);
            button4.Name = "button4";
            button4.Size = new Size(202, 39);
            button4.TabIndex = 5;
            button4.Text = "Reports";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Script MT Bold", 11.25F, FontStyle.Bold);
            button3.Location = new Point(1, 218);
            button3.Name = "button3";
            button3.Size = new Size(202, 39);
            button3.TabIndex = 4;
            button3.Text = "Stock  ";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // btnUcreate
            // 
            btnUcreate.Font = new Font("Script MT Bold", 11.25F, FontStyle.Bold);
            btnUcreate.Location = new Point(1, 179);
            btnUcreate.Name = "btnUcreate";
            btnUcreate.Size = new Size(202, 39);
            btnUcreate.TabIndex = 3;
            btnUcreate.Text = "User Creation";
            btnUcreate.UseVisualStyleBackColor = true;
            btnUcreate.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Script MT Bold", 11.25F, FontStyle.Bold);
            button1.Location = new Point(65, 407);
            button1.Name = "button1";
            button1.Size = new Size(70, 32);
            button1.TabIndex = 2;
            button1.Text = "Log out";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblusername
            // 
            lblusername.AutoSize = true;
            lblusername.Font = new Font("Script MT Bold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblusername.Location = new Point(20, 121);
            lblusername.Name = "lblusername";
            lblusername.Size = new Size(97, 25);
            lblusername.TabIndex = 1;
            lblusername.Text = "user name";
            lblusername.TextAlign = ContentAlignment.MiddleCenter;
            lblusername.Click += username;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(55, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(80, 81);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label2
            // 
            label2.AccessibleRole = AccessibleRole.None;
            label2.AutoSize = true;
            label2.Font = new Font("Pristina", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(101, 244);
            label2.Name = "label2";
            label2.Size = new Size(632, 117);
            label2.TabIndex = 3;
            label2.Text = "Where all your Enterprise Resource Planning needs are met \r\nwhile you sitback and relax and manage you \r\norganisation's data at your comfort\r\n";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(210, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(834, 511);
            panel2.TabIndex = 4;
            // 
            // label1
            // 
            label1.AccessibleRole = AccessibleRole.None;
            label1.AutoSize = true;
            label1.Font = new Font("Pristina", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(185, 161);
            label1.Name = "label1";
            label1.Size = new Size(473, 49);
            label1.TabIndex = 5;
            label1.Text = "Welcome to Aztech ERP Software ";
            // 
            // pictureBox2
            // 
            pictureBox2.AccessibleRole = AccessibleRole.None;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(185, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(473, 118);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // DashForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1043, 512);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "DashForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DashForm";
            Load += DashForm_Load_1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Button button1;
        private Label lblusername;
        private Button button4;
        private Button button3;
        private Button btnUcreate;
        private Panel panel2;
        public Label label1;
        public PictureBox pictureBox2;
        public Label label2;
    }
}