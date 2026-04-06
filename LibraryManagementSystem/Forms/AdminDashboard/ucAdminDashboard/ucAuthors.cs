using MySql.Data.MySqlClient;
using ColegioLibrarySystem.Helpers;
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
    public partial class ucAuthors : UserControl
    {
        private DatabaseHelper dbHelper;
        public ucAuthors()
        {
            InitializeComponent();
            dbHelper = new DatabaseHelper();
            LoadAuthors();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string authorName = textBox1.Text.Trim();
            string description = textBox2.Text.Trim();

            if (string.IsNullOrEmpty(authorName) || string.IsNullOrEmpty(description))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
            try
            {
                string query = "INSERT INTO Author (author_name, description) VALUES (@authName, @desc)";
                MySqlParameter[] parameters = {
                    new MySqlParameter("@authName", authorName),
                    new MySqlParameter("@desc", description)
                };
                dbHelper.ExecuteNonQuery(query, parameters);
                MessageBox.Show($"Author '{authorName}' added successfully!");
                LoadAuthors();
                textBox1.Clear();
                textBox2.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong: " + ex.Message);
            }
        }
        private void LoadAuthors(string searchQueary = "")
        {
            DataTable dtAuthor = dbHelper.GetAuthors(searchQueary);
            dataGridView1.DataSource = dtAuthor;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string search = textBox3.Text.Trim();
            LoadAuthors(search);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            LoadAuthors();
        }
    }
}
