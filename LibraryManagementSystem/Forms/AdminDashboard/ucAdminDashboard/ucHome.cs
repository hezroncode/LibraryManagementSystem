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
            LoadAuthors();
            LoadBooks();
            LoadCategories();
            LoadUsers();
            LoadTransaction();
        }
        /*private void StyleDataGridView(DataGridView dgv)
        {
            // Overall grid
            dgv.BorderStyle = BorderStyle.None;
            dgv.BackgroundColor = Color.White;
            dgv.GridColor = Color.FromArgb(230, 230, 230);
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.RowHeadersVisible = false;
            dgv.AllowUserToResizeRows = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Header
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(112, 0, 192);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.Padding = new Padding(5);
            dgv.ColumnHeadersHeight = 36;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            // Rows
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 9f);
            dgv.DefaultCellStyle.ForeColor = Color.FromArgb(40, 40, 40);
            dgv.DefaultCellStyle.BackColor = Color.White;
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(220, 180, 255);
            dgv.DefaultCellStyle.SelectionForeColor = Color.FromArgb(40, 40, 40);
            dgv.DefaultCellStyle.Padding = new Padding(5);
            dgv.RowTemplate.Height = 32;

            // Alternating row color
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 242, 255);
        }*/

    }
}
