using ColegioLibrarySystem.Helpers;
using System.Data;

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
            label7.Text = $"Books Borrowed: {dbhelper.BorrowedBookCount()}";
            label8.Text = $"Total Users: {dbhelper.TotalUserCount()}";
            label9.Text = $"Total Books: {dbhelper.TotalBookCount()}";
            label10.Text = $"Total Author: {dbhelper.TotalAuthorCount()}";
            label11.Text = $"Total Categories: {dbhelper.TotalCategoryCount()}";
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Status" && e.Value != null)
            {
                string status = e.Value.ToString();

                if (status == "Borrow")
                {
                    DateTime duedate = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells["Due Date"].Value);

                    if (DateTime.Now > duedate)
                    {
                        e.CellStyle.ForeColor = Color.Salmon;
                        e.CellStyle.Font = new Font(dataGridView1.Font, FontStyle.Bold);
                    }
                }
                else if (status == "Returned")
                {
                    e.CellStyle.ForeColor = Color.LightGreen;
                }
            }
        }
    }
}
