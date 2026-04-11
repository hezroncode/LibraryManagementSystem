using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ColegioLibrarySystem.Helpers;
using ColegioLibrarySystem.Models;

namespace LibraryManagementSystem.Forms.LibraryDashboard.ucLibraryDashboard
{
    public partial class ucLibraryHome : UserControl
    {
        private DatabaseHelper dbhelper;
        private int selectedbookID = -1;
        public ucLibraryHome()
        {
            InitializeComponent();
            dbhelper = new DatabaseHelper();
            LoadBooks();
            LoadCategory();
            
        }
        private void LoadBooks(string searchqueary = "", int categoryId = 0, int authorID = 0)
        {
            DataTable dtBooks = dbhelper.GetBooks(searchqueary, categoryId, authorID);
            dataGridView1.DataSource = dtBooks;
        }
        private void LoadCategory()
        {
            DataTable dtCategory = dbhelper.GetCategories();
            comboBox1.DataSource = dtCategory;
            comboBox1.DisplayMember = "category_name";
            comboBox1.ValueMember = "category_id";
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                selectedbookID = Convert.ToInt32(row.Cells["BookID"].Value);
                string title = row.Cells["Title"].Value.ToString();
                string author = row.Cells["Author"].Value.ToString();
                string category = row.Cells["Category"].Value.ToString();
                int yearpublished = Convert.ToInt32(row.Cells["Year Published"].Value);
                int totalcopies = Convert.ToInt32(row.Cells["Total Copies"].Value);


                label1.Text = $"Title: {title}";
                label2.Text = $"Author: {author}";
                label3.Text = $"Category: {category}";
                label4.Text = $"Year Published: {yearpublished}";

            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (selectedbookID == -1)
            {
                MessageBox.Show("Please select a book.");
                return;
            }
            int currentuserID = Session.UserID;
            string currentuserRole = Session.Role;

            var (success, message) = dbhelper.BorrowBook(currentuserID, currentuserRole, selectedbookID);
            if (success)
            {
                MessageBox.Show(message, "Book borrowed succesfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadBooks();
                ClearOverview();
            }
            else 
            {
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ClearOverview()
        {
            label1.Text = "Title:";
            label2.Text = "Author:";
            label3.Text = "Category:";
            label4.Text = "Year Published:";
        }
    }
}
