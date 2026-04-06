namespace LibraryManagementSystem.Forms
{
    partial class AdminSignUpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminSignUpForm));
            panel1 = new Panel();
            linkLabel1 = new LinkLabel();
            button1 = new Button();
            panel8 = new Panel();
            pictureBox3 = new PictureBox();
            panel9 = new Panel();
            textBox3 = new TextBox();
            label4 = new Label();
            panel6 = new Panel();
            pictureBox2 = new PictureBox();
            panel7 = new Panel();
            textBox2 = new TextBox();
            label3 = new Label();
            panel4 = new Panel();
            pictureBox1 = new PictureBox();
            panel5 = new Panel();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            panel1.SuspendLayout();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(panel8);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.ForeColor = SystemColors.ActiveBorder;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(10, 10, 10, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(730, 565);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Transparent;
            linkLabel1.ForeColor = Color.Indigo;
            linkLabel1.LinkColor = Color.Indigo;
            linkLabel1.Location = new Point(338, 538);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(50, 20);
            linkLabel1.TabIndex = 8;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Log in";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkViolet;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(208, 453);
            button1.Name = "button1";
            button1.Size = new Size(313, 56);
            button1.TabIndex = 7;
            button1.Text = "Create";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel8
            // 
            panel8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel8.BackColor = Color.Transparent;
            panel8.Controls.Add(pictureBox3);
            panel8.Controls.Add(panel9);
            panel8.Controls.Add(textBox3);
            panel8.Location = new Point(210, 364);
            panel8.Name = "panel8";
            panel8.Size = new Size(311, 41);
            panel8.TabIndex = 6;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(277, 5);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(36, 33);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            // 
            // panel9
            // 
            panel9.BackColor = Color.MediumPurple;
            panel9.Location = new Point(2, 39);
            panel9.Name = "panel9";
            panel9.Size = new Size(311, 2);
            panel9.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.ForeColor = Color.DarkViolet;
            textBox3.Location = new Point(3, 13);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(308, 23);
            textBox3.TabIndex = 0;
            textBox3.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.MediumPurple;
            label4.Location = new Point(205, 333);
            label4.Name = "label4";
            label4.Size = new Size(97, 28);
            label4.TabIndex = 5;
            label4.Text = "Password";
            // 
            // panel6
            // 
            panel6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel6.BackColor = Color.Transparent;
            panel6.Controls.Add(pictureBox2);
            panel6.Controls.Add(panel7);
            panel6.Controls.Add(textBox2);
            panel6.Location = new Point(208, 259);
            panel6.Name = "panel6";
            panel6.Size = new Size(311, 41);
            panel6.TabIndex = 4;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(279, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(36, 33);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // panel7
            // 
            panel7.BackColor = Color.MediumPurple;
            panel7.Location = new Point(2, 39);
            panel7.Name = "panel7";
            panel7.Size = new Size(311, 2);
            panel7.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.ForeColor = Color.DarkViolet;
            textBox2.Location = new Point(3, 13);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(308, 23);
            textBox2.TabIndex = 0;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.MediumPurple;
            label3.Location = new Point(203, 228);
            label3.Name = "label3";
            label3.Size = new Size(104, 28);
            label3.TabIndex = 3;
            label3.Text = "Username";
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel4.BackColor = Color.Transparent;
            panel4.Controls.Add(pictureBox1);
            panel4.Controls.Add(panel5);
            panel4.Controls.Add(textBox1);
            panel4.Location = new Point(208, 156);
            panel4.Name = "panel4";
            panel4.Size = new Size(311, 41);
            panel4.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(276, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 33);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // panel5
            // 
            panel5.BackColor = Color.MediumPurple;
            panel5.Location = new Point(2, 39);
            panel5.Name = "panel5";
            panel5.Size = new Size(311, 2);
            panel5.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.DarkViolet;
            textBox1.Location = new Point(3, 13);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(308, 23);
            textBox1.TabIndex = 0;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.MediumPurple;
            label2.Location = new Point(203, 125);
            label2.Name = "label2";
            label2.Size = new Size(95, 28);
            label2.TabIndex = 1;
            label2.Text = "Fullname";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MediumPurple;
            label1.Location = new Point(199, 38);
            label1.Name = "label1";
            label1.Size = new Size(334, 41);
            label1.TabIndex = 0;
            label1.Text = "Create Admin Account";
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(567, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(163, 565);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(163, 565);
            panel3.TabIndex = 2;
            // 
            // AdminSignUpForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Indigo;
            ClientSize = new Size(730, 565);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "AdminSignUpForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminSignUpForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private Label label2;
        private Panel panel8;
        private Panel panel9;
        private TextBox textBox3;
        private Label label4;
        private Panel panel6;
        private Panel panel7;
        private TextBox textBox2;
        private Label label3;
        private Panel panel4;
        private Panel panel5;
        private TextBox textBox1;
        private Button button1;
        private LinkLabel linkLabel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
    }
}