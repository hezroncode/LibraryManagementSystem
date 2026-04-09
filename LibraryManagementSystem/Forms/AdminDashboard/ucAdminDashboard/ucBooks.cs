using ColegioLibrarySystem.Helpers;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem.Forms.AdminDashboard
{
    public partial class ucBooks : UserControl
    {
        private DatabaseHelper dbhelper;
        public ucBooks()
        {

            InitializeComponent();

            dbhelper = new DatabaseHelper();

            LoadBooks();
            LoadAuthors();
            LoadCategories();

        }
        private void button5_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(textBox1.Text) || comboBox2.SelectedValue == null || !int.TryParse(textBox3.Text, out int year) || year <= 0 || comboBox1.SelectedValue == null || numericUpDown1.Value <= 0)
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            string title = textBox1.Text.Trim();
            int authorId = Convert.ToInt32(comboBox2.SelectedValue);
            int yearpublished = Convert.ToInt32(textBox3.Text.Trim());
            int categoryId = Convert.ToInt32(comboBox1.SelectedValue);
            int totalCopies = (int)numericUpDown1.Value;

            try
            {
                string query = "INSERT INTO Book (title, author_id, yearpublished, category_id, total_copies, available_copies) VALUES (@title, @authId, @yearpub, @catId, @total, @available)";
                MySqlParameter[] parameters = {
                    new MySqlParameter("@title", title),
                    new MySqlParameter("@authId", authorId),
                    new MySqlParameter("@yearpub", yearpublished),
                    new MySqlParameter("@catId", categoryId),
                    new MySqlParameter("@total", totalCopies),
                    new MySqlParameter("@available", totalCopies)
                };
                dbhelper.ExecuteNonQuery(query, parameters);
                MessageBox.Show($"Book '{title}' added successfully!");
                LoadBooks();
                textBox1.Clear();
                textBox3.Clear();
                numericUpDown1.Value = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong: " + ex.Message);
            }
        }
        private void LoadBooks(string searchqueary = "", int categoryId = 0, int authorID = 0)
        {
            DataTable dtBooks = dbhelper.GetBooks(searchqueary, categoryId, authorID);
            dataGridView1.DataSource = dtBooks;
        }
        private void LoadAuthors()
        {
            DataTable dtAuthors = dbhelper.GetAuthors();
            comboBox2.DataSource = dtAuthors;
            comboBox2.DisplayMember = "author_name";
            comboBox2.ValueMember = "author_id";
        }

        private void LoadCategories()
        {
            DataTable dtCategories = dbhelper.GetCategories();
            comboBox1.DataSource = dtCategories;
            comboBox1.DisplayMember = "category_name";
            comboBox1.ValueMember = "category_id";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string search = textBox2.Text.Trim();
            LoadBooks(search);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            LoadBooks();
        }
    }
}
