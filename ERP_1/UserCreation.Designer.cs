namespace ERP_1
{
    partial class UserCreation
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
            ListViewItem listViewItem3 = new ListViewItem("Administrator");
            ListViewItem listViewItem4 = new ListViewItem("Staff");
            label1 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            listView1 = new ListView();
            button1 = new Button();
            listBox1 = new ListBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Perpetua", 26.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(42, 17);
            label1.Name = "label1";
            label1.Size = new Size(293, 40);
            label1.TabIndex = 0;
            label1.Text = "Staff User Creation ";
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(listView1);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(6, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(464, 434);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(listBox1);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(487, 10);
            panel2.Name = "panel2";
            panel2.Size = new Size(295, 427);
            panel2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Perpetua", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(13, 19);
            label2.Name = "label2";
            label2.Size = new Size(208, 33);
            label2.TabIndex = 0;
            label2.Text = "Registered Users";
            label2.Click += label2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(43, 139);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(294, 23);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(43, 274);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(294, 23);
            textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(43, 230);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(294, 23);
            textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(43, 185);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(294, 23);
            textBox4.TabIndex = 4;
            // 
            // listView1
            // 
            listView1.Items.AddRange(new ListViewItem[] { listViewItem3, listViewItem4 });
            listView1.Location = new Point(48, 86);
            listView1.Name = "listView1";
            listView1.Size = new Size(287, 36);
            listView1.TabIndex = 5;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Tile;
            // 
            // button1
            // 
            button1.Font = new Font("Perpetua", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(119, 318);
            button1.Name = "button1";
            button1.Size = new Size(142, 38);
            button1.TabIndex = 6;
            button1.Text = "Register User";
            button1.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 73);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(257, 154);
            listBox1.TabIndex = 1;
            // 
            // UserCreation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "UserCreation";
            Text = "UserCreation";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private Label label2;
        private ListView listView1;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button1;
        private ListBox listBox1;
    }
}