namespace LibraryManagementSystem.Forms.AdminDashboard
{
    partial class MainAdminDashboard
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
            pnlContainer = new Panel();
            panel2 = new Panel();
            linkLabel1 = new LinkLabel();
            label2 = new Label();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            panel1 = new Panel();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlContainer
            // 
            pnlContainer.BackColor = Color.FromArgb(30, 30, 30);
            pnlContainer.Dock = DockStyle.Fill;
            pnlContainer.Location = new Point(0, 85);
            pnlContainer.Margin = new Padding(3, 2, 3, 2);
            pnlContainer.Name = "pnlContainer";
            pnlContainer.Size = new Size(1212, 630);
            pnlContainer.TabIndex = 1;
            pnlContainer.Paint += pnlContainer_Paint;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(20, 20, 20);
            panel2.Controls.Add(linkLabel1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(-1, -1);
            panel2.Name = "panel2";
            panel2.Size = new Size(1213, 86);
            panel2.TabIndex = 1;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.Fuchsia;
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Transparent;
            linkLabel1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel1.ForeColor = Color.FromArgb(212, 191, 255);
            linkLabel1.LinkColor = Color.FromArgb(246, 242, 255);
            linkLabel1.Location = new Point(1154, 64);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(56, 20);
            linkLabel1.TabIndex = 2;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Logout";
            linkLabel1.VisitedLinkColor = Color.FromArgb(131, 81, 232);
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(246, 242, 255);
            label2.Location = new Point(347, 38);
            label2.Name = "label2";
            label2.Size = new Size(124, 21);
            label2.TabIndex = 1;
            label2.Text = "Welcome Admin";
            // 
            // button5
            // 
            button5.AutoSize = true;
            button5.BackColor = Color.Transparent;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatAppearance.MouseDownBackColor = Color.FromArgb(131, 81, 232);
            button5.FlatAppearance.MouseOverBackColor = Color.FromArgb(131, 81, 232);
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button5.ForeColor = Color.FromArgb(246, 242, 255);
            button5.Location = new Point(595, 25);
            button5.Name = "button5";
            button5.Padding = new Padding(4, 3, 4, 4);
            button5.Size = new Size(101, 47);
            button5.TabIndex = 6;
            button5.Text = "Home";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.AutoSize = true;
            button4.BackColor = Color.Transparent;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseDownBackColor = Color.FromArgb(131, 81, 232);
            button4.FlatAppearance.MouseOverBackColor = Color.FromArgb(131, 81, 232);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button4.ForeColor = Color.FromArgb(246, 242, 255);
            button4.Location = new Point(1033, 25);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Padding = new Padding(4, 2, 4, 4);
            button4.Size = new Size(101, 47);
            button4.TabIndex = 5;
            button4.Text = "User";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.AutoSize = true;
            button3.BackColor = Color.Transparent;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseDownBackColor = Color.FromArgb(131, 81, 232);
            button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(131, 81, 232);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button3.ForeColor = Color.FromArgb(246, 242, 255);
            button3.Location = new Point(913, 25);
            button3.Name = "button3";
            button3.Padding = new Padding(4, 3, 4, 4);
            button3.Size = new Size(134, 47);
            button3.TabIndex = 4;
            button3.Text = "Categories";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.BackColor = Color.Transparent;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(131, 81, 232);
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(131, 81, 232);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button2.ForeColor = Color.FromArgb(246, 242, 255);
            button2.Location = new Point(807, 25);
            button2.Name = "button2";
            button2.Padding = new Padding(4, 3, 4, 4);
            button2.Size = new Size(110, 47);
            button2.TabIndex = 3;
            button2.Text = "Authors";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(131, 81, 232);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(131, 81, 232);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.ForeColor = Color.FromArgb(246, 242, 255);
            button1.Location = new Point(701, 25);
            button1.Name = "button1";
            button1.Padding = new Padding(4, 3, 4, 4);
            button1.Size = new Size(101, 47);
            button1.TabIndex = 2;
            button1.Text = "Books";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(246, 242, 255);
            label1.Location = new Point(23, 19);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(293, 45);
            label1.TabIndex = 0;
            label1.Text = "Admin Dashboard";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(20, 20, 20);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1212, 85);
            panel1.TabIndex = 0;
            // 
            // MainAdminDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1212, 715);
            Controls.Add(pnlContainer);
            Controls.Add(panel1);
            Name = "MainAdminDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BookManagementForm";
            Load += MainAdminDashboard_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlContainer;
        private Panel panel2;
        private LinkLabel linkLabel1;
        private Label label2;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label1;
        private Panel panel1;
    }
}