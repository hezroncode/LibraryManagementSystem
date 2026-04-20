using ColegioLibrarySystem.Helpers;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LibraryManagementSystem.Forms.AdminDashboard
{
    public partial class ucCategories : UserControl
    {
        private DatabaseHelper dbhelper;
        private int selectedcatid = -1;
        public ucCategories()
        {
            InitializeComponent();
            dbhelper = new DatabaseHelper();
            LoadCategories();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Please enter a category name.");
                return;
            }
            string categoryName = textBox1.Text.Trim();

            try
            {
                string query = "INSERT INTO Category (category_name) VALUES (@catName)";
                MySqlParameter[] parameters = {
                    new MySqlParameter("@catName", categoryName)
                };
                dbhelper.ExecuteNonQuery(query, parameters);
                MessageBox.Show($"Category '{categoryName}' added successfully!");
                LoadCategories();
                textBox1.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong: " + ex.Message);
            }
        }
        private void LoadCategories(string searchQueary = "")
        {
            DataTable dtCategory = dbhelper.GetCategories(searchQueary);
            dataGridView1.DataSource = dtCategory;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string search = textBox2.Text.Trim();
            LoadCategories(search);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            LoadCategories();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (selectedcatid == -1)
            {
                MessageBox.Show("Please select a category to delete");
                return;
            }
            var result = MessageBox.Show("Are you sure you want to delete this category?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                // 3. Call the Helper
                if (dbhelper.DeleteCategory(selectedcatid))
                {
                    MessageBox.Show("Book deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // 4. Refresh UI
                    LoadCategories();
                }
                else
                {
                    // This happens if the book was already deleted or if there is a foreign key error
                    MessageBox.Show("Failed to delete category. It may be linked to existing book.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                selectedcatid = Convert.ToInt32(row.Cells["Category ID"].Value);
                textBox1.Text = row.Cells["Category"].Value.ToString();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (selectedcatid == -1)
            {
                MessageBox.Show("Please select a category from the list to update.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string category = textBox1.Text.Trim();

            var confirm = MessageBox.Show("Save changes to this book?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                if (dbhelper.UpdateCategory(selectedcatid, category))
                {
                    MessageBox.Show("Category updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadCategories();
                }
                else
                {
                    MessageBox.Show("Failed to update the category. Please check your data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string search = textBox2.Text.Trim();
            LoadCategories(search);
        }
    }
}
