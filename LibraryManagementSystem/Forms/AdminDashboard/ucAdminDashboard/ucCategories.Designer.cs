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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel6.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(246, 242, 255);
            label4.Location = new Point(530, 64);
            label4.Name = "label4";
            label4.Size = new Size(168, 41);
            label4.TabIndex = 20;
            label4.Text = "Categories";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(246, 242, 255);
            label3.Location = new Point(49, 63);
            label3.Name = "label3";
            label3.Size = new Size(181, 50);
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
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(131, 81, 232);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(246, 242, 255);
            dataGridViewCellStyle5.Padding = new Padding(5);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(131, 81, 232);
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(246, 242, 255);
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(30, 30, 30);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(246, 242, 255);
            dataGridViewCellStyle6.Padding = new Padding(10);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(40, 40, 40);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(246, 242, 255);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.FromArgb(30, 30, 30);
            dataGridView1.Location = new Point(530, 119);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 32;
            dataGridView1.Size = new Size(811, 597);
            dataGridView1.TabIndex = 19;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // panel6
            // 
            panel6.Anchor = AnchorStyles.None;
            panel6.BackColor = Color.FromArgb(50, 50, 50);
            panel6.Controls.Add(panel7);
            panel6.Controls.Add(textBox1);
            panel6.Location = new Point(34, 100);
            panel6.Name = "panel6";
            panel6.Size = new Size(294, 43);
            panel6.TabIndex = 13;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(40, 40, 40);
            panel7.Location = new Point(3, 37);
            panel7.Name = "panel7";
            panel7.Size = new Size(288, 1);
            panel7.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(50, 50, 50);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.FromArgb(246, 242, 255);
            textBox1.Location = new Point(5, 8);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(286, 25);
            textBox1.TabIndex = 0;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(246, 242, 255);
            label6.Location = new Point(23, 64);
            label6.Name = "label6";
            label6.Size = new Size(192, 32);
            label6.TabIndex = 15;
            label6.Text = "Category Name";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(35, 35, 35);
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label6);
            panel3.Controls.Add(panel6);
            panel3.Location = new Point(49, 119);
            panel3.Name = "panel3";
            panel3.Size = new Size(424, 211);
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
            button5.Location = new Point(49, 349);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Padding = new Padding(5, 4, 5, 5);
            button5.Size = new Size(115, 51);
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
            button6.Location = new Point(182, 349);
            button6.Margin = new Padding(3, 4, 3, 4);
            button6.Name = "button6";
            button6.Padding = new Padding(5, 4, 5, 5);
            button6.Size = new Size(115, 51);
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
            button7.Location = new Point(314, 349);
            button7.Margin = new Padding(3, 4, 3, 4);
            button7.Name = "button7";
            button7.Padding = new Padding(5, 4, 5, 5);
            button7.Size = new Size(115, 56);
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
            button8.Location = new Point(1225, 739);
            button8.Margin = new Padding(3, 4, 3, 4);
            button8.Name = "button8";
            button8.Padding = new Padding(5, 4, 5, 5);
            button8.Size = new Size(115, 56);
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
            textBox3.Location = new Point(5, 11);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(239, 25);
            textBox3.TabIndex = 30;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(131, 81, 232);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(975, 64);
            button1.Name = "button1";
            button1.Size = new Size(115, 43);
            button1.TabIndex = 31;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(50, 50, 50);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(textBox3);
            panel1.Location = new Point(1097, 63);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(243, 44);
            panel1.TabIndex = 32;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(40, 40, 40);
            panel2.Location = new Point(2, 40);
            panel2.Name = "panel2";
            panel2.Size = new Size(238, 1);
            panel2.TabIndex = 32;
            // 
            // ucCategories
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(panel3);
            Controls.Add(dataGridView1);
            Controls.Add(label3);
            Controls.Add(panel1);
            Name = "ucCategories";
            Size = new Size(1385, 840);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
    }
}
