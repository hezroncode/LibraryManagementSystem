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
using ColegioLibrarySystem.Models;

namespace LibraryManagementSystem.Forms.LibraryDashboard.ucLibraryDashboard
{
    public partial class ucBorrowed : UserControl
    {
        private DatabaseHelper dbhelper;
        private int returnBookId = -1;

        public ucBorrowed()
        {
            InitializeComponent();
            dbhelper = new DatabaseHelper();
            LoadMyShelf();
        }

        private void LoadMyShelf()
        {
            // Calls the balance query (Borrows minus Returns). 
            // If balance is 0, the book naturally hides itself.
            DataTable dtBorrowed = dbhelper.GetCurrentBorrowedBooks(Session.UserID);
            dataGridView1.DataSource = dtBorrowed;

            // Hide the BookID column so the grid looks clean
            if (dataGridView1.Columns["BookID"] != null)
            {
                dataGridView1.Columns["BookID"].Visible = false;
            }
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                returnBookId = Convert.ToInt32(row.Cells["BookID"].Value);

                string title = row.Cells["Title"].Value.ToString();
                string author = row.Cells["Author"].Value.ToString();
                string category = row.Cells["Category"].Value.ToString();
                string copies = row.Cells["Copies"].Value.ToString();

                // Fill the Overview labels. 
                // I swapped "Year Published" for "Copies to Return" since that's more useful here!
                label7.Text = $"Title: {title}";
                label2.Text = $"Author: {author}";
                label3.Text = $"Category: {category}";
                label4.Text = $"Copies to Return: {copies}";
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {

            if (returnBookId == -1)
            {
                MessageBox.Show("Please select a book to return.", "Select Book", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Call the helper (It automatically returns ALL outstanding copies for this book)
            var (success, message) = dbhelper.ReturnBook(Session.UserID, returnBookId);

            if (success)
            {
                MessageBox.Show(message, "Return Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // REFRESH: This makes the math recalculate to 0, causing the row to vanish!
                LoadMyShelf();
                ClearOverview();
            }
            else
            {
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ClearOverview()
        {
            returnBookId = -1;
            label7.Text = "Title:";
            label2.Text = "Author:";
            label3.Text = "Category:";
            label4.Text = "Copies to Return:";
        }
    }
}