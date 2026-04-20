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
            pictureBox2 = new PictureBox();
            label4 = new Label();
            label3 = new Label();
            panel3 = new Panel();
            txtPassword = new TextBox();
            panel5 = new Panel();
            panel2 = new Panel();
            panel4 = new Panel();
            txtUsername = new TextBox();
            label2 = new Label();
            cnfrmbtn1 = new Button();
            linkLabel1 = new LinkLabel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel6 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 30, 30);
            panel1.Controls.Add(pictureBox2);
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
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(331, 294);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 29);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(246, 242, 255);
            label4.Location = new Point(79, 271);
            label4.Name = "label4";
            label4.Size = new Size(73, 20);
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
            label3.Size = new Size(78, 20);
            label3.TabIndex = 11;
            label3.Text = "Username";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.None;
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(txtPassword);
            panel3.Controls.Add(panel5);
            panel3.Location = new Point(82, 288);
            panel3.Name = "panel3";
            panel3.Size = new Size(245, 42);
            panel3.TabIndex = 10;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(30, 30, 30);
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Cursor = Cursors.IBeam;
            txtPassword.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.ForeColor = Color.FromArgb(246, 242, 255);
            txtPassword.Location = new Point(4, 14);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '●';
            txtPassword.Size = new Size(239, 20);
            txtPassword.TabIndex = 3;
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
            panel2.Controls.Add(txtUsername);
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
            // txtUsername
            // 
            txtUsername.BackColor = Color.FromArgb(30, 30, 30);
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Cursor = Cursors.IBeam;
            txtUsername.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.ForeColor = Color.FromArgb(246, 242, 255);
            txtUsername.Location = new Point(4, 14);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(239, 20);
            txtUsername.TabIndex = 0;
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
            label2.Size = new Size(89, 37);
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
            linkLabel1.Location = new Point(154, 473);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(128, 15);
            linkLabel1.TabIndex = 2;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Create Admin Account";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(51, 84);
            label1.Name = "label1";
            label1.Size = new Size(340, 32);
            label1.TabIndex = 3;
            label1.Text = "Library Management System";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(121, 200);
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
            AutoScaleDimensions = new SizeF(7F, 15F);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
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
        private TextBox txtPassword;
        private Panel panel5;
        private Panel panel4;
        private TextBox txtUsername;
        private Label label4;
        private Label label3;
        private PictureBox pictureBox1;
        private Panel panel6;
        private PictureBox pictureBox2;
    }
}
