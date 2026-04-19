namespace LibraryManagementSystem
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            panel1 = new Panel();
            label4 = new Label();
            label3 = new Label();
            panel3 = new Panel();
            pictureBox2 = new PictureBox();
            textBox2 = new TextBox();
            panel5 = new Panel();
            panel2 = new Panel();
            panel4 = new Panel();
            textBox1 = new TextBox();
            label2 = new Label();
            cnfrmbtn1 = new Button();
            linkLabel1 = new LinkLabel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel6 = new Panel();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 30, 30);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(cnfrmbtn1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(459, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(397, 497);
            panel1.TabIndex = 0;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(246, 242, 255);
            label4.Location = new Point(79, 271);
            label4.Name = "label4";
            label4.Size = new Size(91, 25);
            label4.TabIndex = 12;
            label4.Text = "Password";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(246, 242, 255);
            label3.Location = new Point(79, 193);
            label3.Name = "label3";
            label3.Size = new Size(98, 25);
            label3.TabIndex = 11;
            label3.Text = "Username";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.None;
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(textBox2);
            panel3.Controls.Add(panel5);
            panel3.Location = new Point(82, 288);
            panel3.Name = "panel3";
            panel3.Size = new Size(245, 42);
            panel3.TabIndex = 10;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(210, 6);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 29);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(30, 30, 30);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Cursor = Cursors.IBeam;
            textBox2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.ForeColor = Color.FromArgb(246, 242, 255);
            textBox2.Location = new Point(4, 12);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '●';
            textBox2.Size = new Size(239, 24);
            textBox2.TabIndex = 3;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(131, 81, 232);
            panel5.Location = new Point(3, 37);
            panel5.Name = "panel5";
            panel5.Size = new Size(240, 1);
            panel5.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(textBox1);
            panel2.Location = new Point(82, 210);
            panel2.Name = "panel2";
            panel2.Size = new Size(245, 42);
            panel2.TabIndex = 9;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(131, 81, 232);
            panel4.Location = new Point(3, 37);
            panel4.Name = "panel4";
            panel4.Size = new Size(240, 1);
            panel4.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(30, 30, 30);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.FromArgb(246, 242, 255);
            textBox1.Location = new Point(4, 14);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(239, 24);
            textBox1.TabIndex = 0;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(246, 242, 255);
            label2.Location = new Point(159, 123);
            label2.Name = "label2";
            label2.Size = new Size(110, 46);
            label2.TabIndex = 6;
            label2.Text = "Login";
            // 
            // cnfrmbtn1
            // 
            cnfrmbtn1.Anchor = AnchorStyles.None;
            cnfrmbtn1.BackColor = Color.FromArgb(131, 81, 232);
            cnfrmbtn1.Cursor = Cursors.Hand;
            cnfrmbtn1.FlatAppearance.BorderSize = 0;
            cnfrmbtn1.FlatStyle = FlatStyle.Flat;
            cnfrmbtn1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cnfrmbtn1.ForeColor = Color.FromArgb(246, 242, 255);
            cnfrmbtn1.Location = new Point(82, 348);
            cnfrmbtn1.Margin = new Padding(3, 2, 3, 2);
            cnfrmbtn1.Name = "cnfrmbtn1";
            cnfrmbtn1.Size = new Size(245, 51);
            cnfrmbtn1.TabIndex = 5;
            cnfrmbtn1.Text = "Confirm";
            cnfrmbtn1.UseVisualStyleBackColor = false;
            cnfrmbtn1.Click += cnfrmbtn1_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.FromArgb(255, 128, 255);
            linkLabel1.Anchor = AnchorStyles.Bottom;
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.White;
            linkLabel1.Location = new Point(149, 456);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(158, 20);
            linkLabel1.TabIndex = 2;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Create Admin Account";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(28, 84);
            label1.Name = "label1";
            label1.Size = new Size(413, 40);
            label1.TabIndex = 3;
            label1.Text = "Library Management System";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(122, 200);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 154);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(131, 81, 232);
            panel6.Controls.Add(label1);
            panel6.Controls.Add(linkLabel1);
            panel6.Controls.Add(pictureBox1);
            panel6.Dock = DockStyle.Left;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(459, 497);
            panel6.TabIndex = 5;
            // 
            // LoginForm
            // 
            AcceptButton = cnfrmbtn1;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Indigo;
            ClientSize = new Size(856, 497);
            Controls.Add(panel1);
            Controls.Add(panel6);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 2, 3, 2);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginPage";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button cnfrmbtn1;
        private LinkLabel linkLabel1;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private TextBox textBox2;
        private Panel panel5;
        private Panel panel4;
        private TextBox textBox1;
        private Label label4;
        private Label label3;
        private PictureBox pictureBox1;
        private Panel panel6;
        private PictureBox pictureBox2;
    }
}
