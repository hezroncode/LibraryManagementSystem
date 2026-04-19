namespace LibraryManagementSystem.Forms.LibraryDashboard.ucLibraryDashboard
{
    partial class ucLibraryHome
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label9 = new Label();
            panel2 = new Panel();
            label10 = new Label();
            numericUpDown1 = new NumericUpDown();
            panel3 = new Panel();
            label5 = new Label();
            label8 = new Label();
            button2 = new Button();
            label6 = new Label();
            panel4 = new Panel();
            label11 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel5 = new Panel();
            comboBox1 = new ComboBox();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            panel6 = new Panel();
            panel7 = new Panel();
            label7 = new Label();
            textBox1 = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 30, 30);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(panel5);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1385, 839);
            panel1.TabIndex = 0;
            panel1.Click += panel1_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(246, 242, 255);
            label9.Location = new Point(41, 29);
            label9.Name = "label9";
            label9.Size = new Size(118, 46);
            label9.TabIndex = 7;
            label9.Text = "Books";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(35, 35, 35);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label10);
            panel2.Controls.Add(numericUpDown1);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(panel4);
            panel2.Location = new Point(959, 79);
            panel2.Name = "panel2";
            panel2.Size = new Size(396, 717);
            panel2.TabIndex = 1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semilight", 8.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FromArgb(238, 199, 97);
            label10.Location = new Point(12, 696);
            label10.Name = "label10";
            label10.Size = new Size(231, 19);
            label10.TabIndex = 8;
            label10.Text = "Note: you can can only borrow 1 copy";
            label10.Visible = false;
            label10.Click += label10_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.BackColor = Color.FromArgb(50, 50, 50);
            numericUpDown1.BorderStyle = BorderStyle.None;
            numericUpDown1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numericUpDown1.ForeColor = Color.FromArgb(246, 242, 255);
            numericUpDown1.Location = new Point(115, 566);
            numericUpDown1.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(45, 25);
            numericUpDown1.TabIndex = 6;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(131, 81, 232);
            panel3.Controls.Add(label5);
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(388, 67);
            panel3.TabIndex = 0;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(9, 8);
            label5.Name = "label5";
            label5.Size = new Size(121, 41);
            label5.TabIndex = 0;
            label5.Text = "Borrow";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(246, 242, 255);
            label8.Location = new Point(19, 563);
            label8.Name = "label8";
            label8.Size = new Size(90, 28);
            label8.TabIndex = 5;
            label8.Text = "Quantity";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(131, 81, 232);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(168, 536);
            button2.Name = "button2";
            button2.Size = new Size(199, 55);
            button2.TabIndex = 4;
            button2.Text = "Confirm Borrow";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(246, 242, 255);
            label6.Location = new Point(24, 91);
            label6.Name = "label6";
            label6.Size = new Size(131, 37);
            label6.TabIndex = 3;
            label6.Text = "Overview";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(40, 40, 40);
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(label11);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(label1);
            panel4.Location = new Point(24, 142);
            panel4.Name = "panel4";
            panel4.Size = new Size(352, 366);
            panel4.TabIndex = 2;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.FromArgb(246, 242, 255);
            label11.Location = new Point(199, 325);
            label11.Name = "label11";
            label11.Size = new Size(123, 20);
            label11.TabIndex = 9;
            label11.Text = "Available copies:";
            label11.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(246, 242, 255);
            label4.Location = new Point(17, 229);
            label4.Name = "label4";
            label4.Size = new Size(182, 32);
            label4.TabIndex = 4;
            label4.Text = "Year Published:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(246, 242, 255);
            label3.Location = new Point(13, 170);
            label3.Name = "label3";
            label3.Size = new Size(117, 32);
            label3.TabIndex = 3;
            label3.Text = "Category:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(246, 242, 255);
            label2.Location = new Point(17, 110);
            label2.Name = "label2";
            label2.Size = new Size(94, 32);
            label2.TabIndex = 2;
            label2.Text = "Author:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(246, 242, 255);
            label1.Location = new Point(17, 53);
            label1.Name = "label1";
            label1.Size = new Size(67, 32);
            label1.TabIndex = 1;
            label1.Text = "Title:";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(35, 35, 35);
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(comboBox1);
            panel5.Controls.Add(dataGridView1);
            panel5.Controls.Add(button1);
            panel5.Controls.Add(panel6);
            panel5.Controls.Add(label7);
            panel5.Controls.Add(textBox1);
            panel5.Location = new Point(41, 79);
            panel5.Margin = new Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(912, 717);
            panel5.TabIndex = 6;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.FromArgb(50, 50, 50);
            comboBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.ForeColor = Color.FromArgb(246, 242, 255);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "--All--" });
            comboBox1.Location = new Point(447, 16);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(139, 29);
            comboBox1.TabIndex = 5;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(131, 81, 232);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(246, 242, 255);
            dataGridViewCellStyle1.Padding = new Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(131, 81, 232);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(246, 242, 255);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(30, 30, 30);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(246, 242, 255);
            dataGridViewCellStyle2.Padding = new Padding(10);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(40, 40, 40);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(246, 242, 255);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.FromArgb(30, 30, 30);
            dataGridView1.Location = new Point(18, 63);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 32;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(888, 577);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(131, 81, 232);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(246, 242, 255);
            button1.Location = new Point(18, 11);
            button1.Name = "button1";
            button1.Size = new Size(94, 39);
            button1.TabIndex = 3;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(50, 50, 50);
            panel6.Controls.Add(panel7);
            panel6.Location = new Point(119, 11);
            panel6.Margin = new Padding(3, 4, 3, 4);
            panel6.Name = "panel6";
            panel6.Size = new Size(209, 39);
            panel6.TabIndex = 8;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(40, 40, 40);
            panel7.Location = new Point(5, 33);
            panel7.Margin = new Padding(3, 4, 3, 4);
            panel7.Name = "panel7";
            panel7.Size = new Size(202, 1);
            panel7.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(246, 242, 255);
            label7.Location = new Point(351, 16);
            label7.Name = "label7";
            label7.Size = new Size(94, 28);
            label7.TabIndex = 4;
            label7.Text = "Category";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(50, 50, 50);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.FromArgb(246, 242, 255);
            textBox1.Location = new Point(121, 20);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(207, 22);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // ucLibraryHome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "ucLibraryHome";
            Size = new Size(1385, 839);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private Panel panel2;
        private Label label1;
        private Panel panel3;
        private Panel panel4;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label6;
        private Label label5;
        private TextBox textBox1;
        private Label label7;
        private Button button1;
        private ComboBox comboBox1;
        private Button button2;
        private NumericUpDown numericUpDown1;
        private Label label8;
        private Label label9;
        private Panel panel5;
        private Label label10;
        private Panel panel6;
        private Panel panel7;
        private Label label11;
    }
}
