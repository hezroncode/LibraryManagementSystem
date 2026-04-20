namespace LibraryManagementSystem.Forms.AdminDashboard
{
    partial class ucCategories
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            label4 = new Label();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            panel6 = new Panel();
            panel7 = new Panel();
            textBox1 = new TextBox();
            label6 = new Label();
            panel3 = new Panel();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            textBox3 = new TextBox();
            button1 = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            textBox2 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel6.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(246, 242, 255);
            label4.Location = new Point(14, 11);
            label4.Name = "label4";
            label4.Size = new Size(135, 32);
            label4.TabIndex = 20;
            label4.Text = "Categories";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(246, 242, 255);
            label3.Location = new Point(3, 5);
            label3.Name = "label3";
            label3.Size = new Size(136, 37);
            label3.TabIndex = 17;
            label3.Text = "Category";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = Color.FromArgb(35, 35, 35);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(131, 81, 232);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(246, 242, 255);
            dataGridViewCellStyle3.Padding = new Padding(5);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(131, 81, 232);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(246, 242, 255);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(30, 30, 30);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(246, 242, 255);
            dataGridViewCellStyle4.Padding = new Padding(10);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(40, 40, 40);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(246, 242, 255);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.FromArgb(30, 30, 30);
            dataGridView1.Location = new Point(452, 89);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 32;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(729, 438);
            dataGridView1.TabIndex = 19;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // panel6
            // 
            panel6.Anchor = AnchorStyles.None;
            panel6.BackColor = Color.FromArgb(50, 50, 50);
            panel6.Controls.Add(panel7);
            panel6.Controls.Add(textBox1);
            panel6.Location = new Point(27, 72);
            panel6.Margin = new Padding(3, 2, 3, 2);
            panel6.Name = "panel6";
            panel6.Size = new Size(257, 32);
            panel6.TabIndex = 13;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(40, 40, 40);
            panel7.Location = new Point(3, 28);
            panel7.Margin = new Padding(3, 2, 3, 2);
            panel7.Name = "panel7";
            panel7.Size = new Size(252, 1);
            panel7.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(50, 50, 50);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.FromArgb(246, 242, 255);
            textBox1.Location = new Point(4, 6);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(250, 20);
            textBox1.TabIndex = 0;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(246, 242, 255);
            label6.Location = new Point(17, 45);
            label6.Name = "label6";
            label6.Size = new Size(151, 25);
            label6.TabIndex = 15;
            label6.Text = "Category Name";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(35, 35, 35);
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label6);
            panel3.Controls.Add(panel6);
            panel3.Location = new Point(43, 89);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(344, 159);
            panel3.TabIndex = 18;
            // 
            // button5
            // 
            button5.AutoSize = true;
            button5.BackColor = Color.FromArgb(61, 133, 98);
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.White;
            button5.Location = new Point(49, 262);
            button5.Name = "button5";
            button5.Padding = new Padding(4, 3, 4, 4);
            button5.Size = new Size(101, 38);
            button5.TabIndex = 21;
            button5.Text = "Add";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.AutoSize = true;
            button6.BackColor = Color.FromArgb(133, 50, 50);
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.ForeColor = Color.White;
            button6.Location = new Point(165, 262);
            button6.Name = "button6";
            button6.Padding = new Padding(4, 3, 4, 4);
            button6.Size = new Size(101, 38);
            button6.TabIndex = 22;
            button6.Text = "Delete";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.AutoSize = true;
            button7.BackColor = Color.FromArgb(66, 84, 138);
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.ForeColor = Color.White;
            button7.Location = new Point(281, 262);
            button7.Name = "button7";
            button7.Padding = new Padding(4, 3, 4, 4);
            button7.Size = new Size(101, 42);
            button7.TabIndex = 23;
            button7.Text = "Update";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.AutoSize = true;
            button8.BackColor = Color.FromArgb(131, 81, 232);
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button8.ForeColor = Color.FromArgb(246, 242, 255);
            button8.Location = new Point(1080, 554);
            button8.Name = "button8";
            button8.Padding = new Padding(4, 3, 4, 4);
            button8.Size = new Size(101, 42);
            button8.TabIndex = 24;
            button8.Text = "Refresh";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(50, 50, 50);
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.ForeColor = Color.FromArgb(246, 242, 255);
            textBox3.Location = new Point(281, 262);
            textBox3.Margin = new Padding(3, 2, 3, 2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(209, 20);
            textBox3.TabIndex = 30;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(131, 81, 232);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(246, 242, 255);
            button1.Location = new Point(853, 48);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(101, 32);
            button1.TabIndex = 31;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(50, 50, 50);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(960, 47);
            panel1.Name = "panel1";
            panel1.Size = new Size(221, 33);
            panel1.TabIndex = 32;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(40, 40, 40);
            panel2.Location = new Point(2, 30);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(218, 1);
            panel2.TabIndex = 32;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(35, 35, 35);
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(label4);
            panel4.Controls.Add(textBox3);
            panel4.Location = new Point(438, 37);
            panel4.Name = "panel4";
            panel4.Size = new Size(755, 500);
            panel4.TabIndex = 33;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(131, 81, 232);
            panel5.Controls.Add(label3);
            panel5.Location = new Point(43, 40);
            panel5.Name = "panel5";
            panel5.Size = new Size(344, 47);
            panel5.TabIndex = 34;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(50, 50, 50);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.ForeColor = Color.FromArgb(246, 242, 255);
            textBox2.Location = new Point(3, 9);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(215, 18);
            textBox2.TabIndex = 35;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // ucCategories
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            Controls.Add(button1);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(panel3);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Controls.Add(panel4);
            Controls.Add(panel5);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ucCategories";
            Size = new Size(1212, 630);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label3;
        private DataGridView dataGridView1;
        private Panel panel6;
        private Panel panel7;
        private TextBox textBox1;
        private Label label6;
        private Panel panel3;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private TextBox textBox3;
        private Button button1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel4;
        private Panel panel5;
        private TextBox textBox2;
    }
}
