using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ColegioLibrarySystem.Helpers;
using MySql.Data.MySqlClient;

namespace LibraryManagementSystem.Forms.AdminDashboard
{
    public partial class ucHome : UserControl
    {
        private DatabaseHelper dbhelper;
        public ucHome()
        {
            InitializeComponent();
            dbhelper = new DatabaseHelper();
            LoadDashboardData();
        }
        private void LoadTransactions()
        {
            // This method can be implemented to load recent transactions or any relevant data for the admin dashboard.
            // For example, you could query the database for recent book checkouts, returns, or user registrations and display them in a DataGridView or ListView.
        }
        private void LoadAuthors(string searchqueary = "")
        {
            DataTable dtAuthor = dbhelper.GetAuthors(searchqueary);
            dataGridView5.DataSource = dtAuthor;

        }
        private void LoadBooks(string searchqueary = "", int categoryId = 0, int authorID = 0)
        {
            DataTable dtBooks = dbhelper.GetBooks(searchqueary, categoryId, authorID);
            dataGridView4.DataSource = dtBooks;
        }
        private void LoadCategories(string searchQueary = "")
        {
            DataTable dtCategory = dbhelper.GetCategories(searchQueary);
            dataGridView3.DataSource = dtCategory;
        }
        private void LoadUsers(string searchQueary = "")
        {
            DataTable dtUser = dbhelper.GetUsers(searchQueary);
            dataGridView2.DataSource = dtUser;
        }
        private void LoadTransaction(string searchqueary = "")
        {
            DataTable dtTransaction = dbhelper.GetTransactions(searchqueary);
            dataGridView1.DataSource = dtTransaction;
        }
        private void LoadDashboardData()
        {
            LoadTransactions();
            LoadAuthors();
            LoadBooks();
            LoadCategories();
            LoadUsers();
            LoadTransaction();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
