using ColegioLibrarySystem.Helpers;
using ColegioLibrarySystem.Models;
using System.Data;

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

            if (Session.Role == "Student")
            {
                numericUpDown1.Value = 1;
                numericUpDown1.Enabled = false;
                label10.Visible = true;
            }

        }
        private void LoadBooks(string searchquery = "", int categoryId = 0, int authorID = 0)
        {
            DataTable dtBooks = dbhelper.GetBooks(searchquery, categoryId, authorID);
            dataGridView1.DataSource = dtBooks;

            if (dataGridView1.Columns["Book ID"] != null)
            {
                dataGridView1.Columns["Book ID"].Visible = false;
            }
        }
        private void LoadCategory()
        {
            DataTable dtCategory = dbhelper.GetCategories();
            DataRow row = dtCategory.NewRow(); row["Category ID"] = 0; row["Category"] = "-- All --";
            dtCategory.Rows.InsertAt(row, 0);

            comboBox1.DisplayMember = "Category";
            comboBox1.ValueMember = "Category ID";
            comboBox1.DataSource = dtCategory;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (selectedbookID == -1)
            {
                MessageBox.Show("Please select a book.");
                return;
            }

            int qty = numericUpDown1.Value > 0 ? (int)numericUpDown1.Value : 1;
            int currentuserID = Session.UserID;
            string currentuserRole = Session.Role;

            var (success, message) = dbhelper.BorrowBook(currentuserID, currentuserRole, selectedbookID, qty);

            if (success)
            {
                MessageBox.Show(message, "Book borrowed successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadBooks();
                ClearOverview();
                selectedbookID = -1;
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
            label11.Visible = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                selectedbookID = Convert.ToInt32(row.Cells["Book ID"].Value);
                string title = row.Cells["Title"].Value.ToString();
                string author = row.Cells["Author"].Value.ToString();
                string category = row.Cells["Category"].Value.ToString();
                int yearpublished = Convert.ToInt32(row.Cells["Year Published"].Value);
                int availablecopies = Convert.ToInt32(row.Cells["Available Copies"].Value);


                label1.Text = $"Title: {title}";
                label2.Text = $"Author: {author}";
                label3.Text = $"Category: {category}";
                label4.Text = $"Year Published: {yearpublished}";
                label11.Text = $"Available copies: {availablecopies}";
                label11.Visible = true;

            }

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedCatID = Convert.ToInt32(comboBox1.SelectedValue);
            string search = textBox1.Text.Trim();
            LoadBooks(search, selectedCatID);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string search = textBox1.Text.Trim();
            LoadBooks(search);
        }
        private void panel1_Click(object sender, EventArgs e)
        {
            ClearOverview();
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            string search = textBox2.Text.Trim();
            LoadBooks(search);
        }
    }
}
