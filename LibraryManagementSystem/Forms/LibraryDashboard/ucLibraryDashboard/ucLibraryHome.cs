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

namespace LibraryManagementSystem.Forms.LibraryDashboard.ucLibraryDashboard
{
    public partial class ucLibraryHome : UserControl
    {
        private DatabaseHelper dbhelper;
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

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
