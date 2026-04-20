using ColegioLibrarySystem.Helpers;
using MySql.Data.MySqlClient;
using System.ComponentModel;
using System.Data;

namespace LibraryManagementSystem.Forms.AdminDashboard
{
    public partial class ucBooks : UserControl
    {
        private DatabaseHelper dbhelper;
        private int selectedbookid = -1;
        private int selectedAuthorId = -1;

        public ucBooks()
        {
            InitializeComponent();
            dbhelper = new DatabaseHelper();
            LoadBooks();
            LoadCategories();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || selectedAuthorId == -1 || !int.TryParse(textBox3.Text, out int year) || year <= 0 || comboBox1.SelectedValue == null || numericUpDown1.Value <= 0)
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            string title = textBox1.Text.Trim();
            int authorId = selectedAuthorId;
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
                textBox4.Clear();
                selectedAuthorId = -1;
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

        private void LoadCategories()
        {
            DataTable dtCategories = dbhelper.GetCategories();
            comboBox1.DataSource = dtCategories;
            comboBox1.DisplayMember = "Category";
            comboBox1.ValueMember = "Category ID";
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

        private void button7_Click(object sender, EventArgs e)
        {
            if (selectedbookid == -1)
            {
                MessageBox.Show("Please select a book from the list to update.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (selectedAuthorId == -1)
            {
                MessageBox.Show("Please select a valid author from the suggestions.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string title = textBox1.Text.Trim();
            int authorId = selectedAuthorId;
            int yearpublished = Convert.ToInt32(textBox3.Text.Trim());
            int categoryId = Convert.ToInt32(comboBox1.SelectedValue);
            int totalCopies = (int)numericUpDown1.Value;

            var confirm = MessageBox.Show("Save changes to this book?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                if (dbhelper.UpdateBook(selectedbookid, title, authorId, categoryId, yearpublished, totalCopies))
                {
                    MessageBox.Show("Book updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadBooks();
                }
                else
                {
                    MessageBox.Show("Failed to update the book. Please check your data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            listBox1.Visible = false;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                selectedbookid = Convert.ToInt32(row.Cells["Book ID"].Value);
                textBox1.Text = row.Cells["Title"].Value.ToString();
                textBox4.Text = row.Cells["Author"].Value.ToString();
                textBox3.Text = row.Cells["Year Published"].Value.ToString();
                comboBox1.Text = row.Cells["Category"].Value.ToString();
                numericUpDown1.Value = Convert.ToDecimal(row.Cells["Total Copies"].Value);

                DataTable dt = dbhelper.GetAuthors(row.Cells["Author"].Value.ToString());
                if (dt.Rows.Count > 0)
                    selectedAuthorId = Convert.ToInt32(dt.Rows[0]["Author ID"]);
            }
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            if (selectedbookid == -1)
            {
                MessageBox.Show("Please select a book to delete");
                return;
            }

            var result = MessageBox.Show("Are you sure you want to delete this book?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                if (dbhelper.DeleteBooks(selectedbookid))
                {
                    MessageBox.Show("Book deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadBooks();
                }
                else
                {
                    MessageBox.Show("Failed to delete book. It may be linked to existing transactions.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void listBox1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string authorName = listBox1.SelectedItem.ToString();
                textBox4.Text = authorName;
                listBox1.Visible = false;

                DataTable dt = dbhelper.GetAuthors(authorName);
                if (dt.Rows.Count > 0)
                    selectedAuthorId = Convert.ToInt32(dt.Rows[0]["Author ID"]);
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            string search = textBox4.Text.Trim();

            if (string.IsNullOrEmpty(search))
            {
                listBox1.Visible = false;
                selectedAuthorId = -1;
                return;
            }

            listBox1.Items.Clear();

            DataTable authors = dbhelper.GetAuthors(search);
            foreach (DataRow row in authors.Rows)
                listBox1.Items.Add(row["Author"].ToString());

            listBox1.Visible = listBox1.Items.Count > 0;
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            Task.Delay(200).ContinueWith(_ =>
                this.Invoke(() => listBox1.Visible = false));
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string search = textBox2.Text.Trim();
            LoadBooks(search);
        }
    }
}