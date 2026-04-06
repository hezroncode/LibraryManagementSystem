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

namespace LibraryManagementSystem.Forms.AdminDashboard
{
    public partial class ucCategories : UserControl
    {
        private DatabaseHelper dbhelper;
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
            string search = textBox3.Text.Trim();
            LoadCategories(search);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            LoadCategories();
        }
    }
}
