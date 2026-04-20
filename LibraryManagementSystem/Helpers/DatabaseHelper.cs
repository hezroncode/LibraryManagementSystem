using ColegioLibrarySystem.Models;
using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace ColegioLibrarySystem.Helpers
{
    public class DatabaseHelper
    {
        private string connectionString = "Server=localhost;Database=librarymanagementdb;Uid=root;Pwd=;Convert Zero Datetime=True;";

        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }

        public DataTable ExecuteQuery(string query, MySqlParameter[] parameters = null)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection conn = GetConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    if (parameters != null)
                        cmd.Parameters.AddRange(parameters);

                    try
                    {
                        conn.Open();
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            return dt;
        }

        public int ExecuteNonQuery(string query, MySqlParameter[] parameters = null)
        {
            int rowsAffected = 0;
            using (MySqlConnection conn = GetConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    if (parameters != null)
                        cmd.Parameters.AddRange(parameters);

                    try
                    {
                        conn.Open();
                        rowsAffected = cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            return rowsAffected;
        }
        private int ExecuteCountQuery(string query)
        {
            int count = 0;
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            count = Convert.ToInt32(result);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return count;
        }

        public DataTable GetBooks(string searchquery = "", int categoryId = 0, int authorID = 0)
        {
            string query = @"SELECT b.book_id AS 'Book ID', b.title AS Title, a.author_name AS Author, c.category_name AS Category, b.yearpublished AS 'Year Published', b.total_copies AS 'Total Copies', b.available_copies AS 'Available Copies'
                           FROM book b
                           JOIN author a ON b.author_id = a.author_id
                           JOIN Category c ON b.category_id = c.category_id
                           WHERE (@search IS NULL OR b.title LIKE @search OR a.author_name LIKE @search)
                           AND (@catId = 0 OR b.category_id = @catId) 
                           AND (@authId = 0 OR b.author_id = @authId)";
            MySqlParameter[] parameters = {
                new MySqlParameter("@search", string.IsNullOrEmpty(searchquery) ? (object)DBNull.Value : "%" + searchquery + "%"),
                new MySqlParameter("@catId", categoryId),
                new MySqlParameter("@authId", authorID)
                };
            return ExecuteQuery(query, parameters);
        }

        public DataTable GetAuthors(string searchquery = "")
        {
            string query = @"SELECT author_id AS 'Author ID', author_name AS 'Author', description AS 'Description' FROM Author
                            WHERE (@search IS NULL OR author_name LIKE @search)
                            ORDER BY author_name ASC";
            MySqlParameter[] parameters = {
                new MySqlParameter("@search", string.IsNullOrEmpty(searchquery) ? (object)DBNull.Value : "%" + searchquery + "%")
            };
            return ExecuteQuery(query, parameters);
        }

        public DataTable GetCategories(string searchquery = "")
        {
            string query = @"SELECT category_id AS 'Category ID', category_name AS 'Category' FROM Category
                           WHERE (@search IS NULL OR category_name LIKE @search)
                           ORDER BY category_id ASC";
            MySqlParameter[] parameters = {
                new MySqlParameter("@search", string.IsNullOrEmpty(searchquery) ? (object)DBNull.Value : "%" + searchquery + "%")
            };
            return ExecuteQuery(query, parameters);
        }

        public DataTable GetUsers(string searchquery = "")
        {
            string query = @"SELECT user_id AS 'User ID', fullname AS 'Fullname', username AS 'Username', password AS 'Password', role AS 'Role' 
                           FROM User
                           WHERE (@search IS NULL OR fullname LIKE @search OR username LIKE @search)";
            MySqlParameter[] parameters = {
                new MySqlParameter("@search", string.IsNullOrEmpty(searchquery) ? (object)DBNull.Value : "%" + searchquery + "%")
            };
            return ExecuteQuery(query, parameters);
        }

        public DataTable GetTransactions(string searchquery = "")
        {
            string query = @"SELECT t.transaction_id AS 'ID', u.fullname AS 'Borrower', b.title AS 'Book Title', t.quantity AS 'Qty', t.borrow_date AS 'Borrowed', t.due_date AS 'Due Date', t.return_date AS 'Returned', t.status AS 'Status'
                           FROM `transaction` t
                           JOIN User u ON t.user_id = u.user_id
                           JOIN book b ON t.book_id = b.book_id
                           WHERE (@search IS NULL OR u.fullname LIKE @search OR b.title LIKE @search)
                           ORDER BY t.borrow_date DESC";
            MySqlParameter[] parameters = {
                new MySqlParameter("@search", string.IsNullOrEmpty(searchquery) ? (object)DBNull.Value : "%" + searchquery + "%")
            };
            return ExecuteQuery(query, parameters);
        }

        public DataTable GetCurrentBorrowedBooks(int userId)
        {
            string query = @"SELECT b.book_id AS 'BookID', b.title AS 'Title', COALESCE(a.author_name, 'Unknown') AS 'Author', c.category_name AS 'Category', 
                            SUM(CASE WHEN LOWER(t.status) = 'borrow' THEN t.quantity WHEN LOWER(t.status) = 'returned' THEN -t.quantity ELSE 0 END) AS 'Copies'
                             FROM book b
                             INNER JOIN `transaction` t ON b.book_id = t.book_id
                             LEFT JOIN author a ON b.author_id = a.author_id
                             LEFT JOIN Category c ON b.category_id = c.category_id
                             WHERE t.user_id = @userId
                             GROUP BY b.book_id, b.title, a.author_name, c.category_name
                             HAVING Copies > 0
                             ORDER BY b.title ASC";

            MySqlParameter[] parameters = { new MySqlParameter("@userId", userId) };
            return ExecuteQuery(query, parameters);
        }

        public DataTable GetTransactionHistory(int userId)
        {
            string query = @"SELECT t.transaction_id AS 'ID', b.title AS 'Title', t.quantity AS 'Qty', t.status AS 'Action', IFNULL(t.borrow_date, t.return_date) AS 'Date'
                             FROM `transaction` t
                             JOIN book b ON t.book_id = b.book_id
                             WHERE t.user_id = @userId
                             ORDER BY t.transaction_id DESC";
            MySqlParameter[] parameters = { new MySqlParameter("@userId", userId) };
            return ExecuteQuery(query, parameters);
        }

        public (bool success, string message) BorrowBook(int userId, string userRole, int bookId, int qty)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                using (MySqlTransaction sqlTrans = conn.BeginTransaction())
                {
                    try
                    {
                        if (userRole == "Student")
                        {
                            qty = 1;
                            string checkStudent = @"SELECT SUM(CASE WHEN status = 'Borrow' THEN quantity ELSE -quantity END) FROM `transaction` WHERE user_id = @uid AND book_id = @bid";
                            using (MySqlCommand cmd = new MySqlCommand(checkStudent, conn, sqlTrans))
                            {
                                cmd.Parameters.AddWithValue("@uid", userId);
                                cmd.Parameters.AddWithValue("@bid", bookId);
                                object res = cmd.ExecuteScalar();
                                if (res != DBNull.Value && Convert.ToInt32(res) > 0)
                                    return (false, "Students can only borrow 1 copy per book.");
                            }
                        }
                        string checkStock = "SELECT available_copies FROM book WHERE book_id = @bid";
                        int available = 0;
                        using (MySqlCommand cmd = new MySqlCommand(checkStock, conn, sqlTrans))
                        {
                            cmd.Parameters.AddWithValue("@bid", bookId);
                            available = Convert.ToInt32(cmd.ExecuteScalar());
                        }

                        if (available < qty || available <= 0) return (false, "Not enough copies available.");

                        int daysToAdd = (userRole == "Student") ? 14 : 30;
                        DateTime dueDate = DateTime.Now.AddDays(daysToAdd);

                        string insertBorrow = @"INSERT INTO `transaction` (user_id, book_id, quantity, borrow_date, due_date, status) VALUES (@uid, @bid, @qty, NOW(), @duedate, 'Borrow')";
                        using (MySqlCommand cmd = new MySqlCommand(insertBorrow, conn, sqlTrans))
                        {
                            cmd.Parameters.AddWithValue("@uid", userId);
                            cmd.Parameters.AddWithValue("@bid", bookId);
                            cmd.Parameters.AddWithValue("@qty", qty);
                            cmd.Parameters.AddWithValue("@duedate", dueDate);
                            cmd.ExecuteNonQuery();
                        }

                        string deductStock = "UPDATE book SET available_copies = available_copies - @qty WHERE book_id = @bid";
                        using (MySqlCommand cmd = new MySqlCommand(deductStock, conn, sqlTrans))
                        {
                            cmd.Parameters.AddWithValue("@qty", qty);
                            cmd.Parameters.AddWithValue("@bid", bookId);
                            cmd.ExecuteNonQuery();
                        }

                        sqlTrans.Commit();
                        return (true, "Book borrowed successfully!");
                    }
                    catch (Exception ex)
                    {
                        sqlTrans.Rollback();
                        return (false, "Error: " + ex.Message);
                    }
                }
            }
        }

        public (bool success, string message) ReturnBook(int userId, int bookId)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                using (MySqlTransaction sqlTrans = conn.BeginTransaction())
                {
                    try
                    {
                        string findActive = @"SELECT transaction_id, due_date, quantity FROM `transaction` WHERE user_id = @uid AND book_id = @bid AND status = 'Borrow' ORDER BY borrow_date ASC LIMIT 1";
                        int tid; DateTime dDate; int qty;

                        using (MySqlCommand cmd = new MySqlCommand(findActive, conn, sqlTrans))
                        {
                            cmd.Parameters.AddWithValue("@uid", userId);
                            cmd.Parameters.AddWithValue("@bid", bookId);
                            using (var rdr = cmd.ExecuteReader())
                            {
                                if (!rdr.Read()) return (false, "No active borrow record.");
                                tid = rdr.GetInt32("transaction_id");
                                dDate = rdr.GetDateTime("due_date");
                                qty = rdr.GetInt32("quantity");
                            }
                        }

                        // Fine Calculation Logic
                        string fineAlert = "";
                        if (dDate != DateTime.MinValue && DateTime.Now > dDate)
                        {
                            int lateDays = (DateTime.Now - dDate).Days;
                            if (lateDays > 0) fineAlert = $"\nLate: {lateDays} days. Fine: P{lateDays * 10}";
                        }

                        string updateRet = "UPDATE `transaction` SET return_date = NOW(), status = 'Returned' WHERE transaction_id = @tid";
                        using (MySqlCommand cmd = new MySqlCommand(updateRet, conn, sqlTrans))
                        {
                            cmd.Parameters.AddWithValue("@tid", tid);
                            cmd.ExecuteNonQuery();
                        }

                        string addStock = "UPDATE book SET available_copies = available_copies + @qty WHERE book_id = @bid";
                        using (MySqlCommand cmd = new MySqlCommand(addStock, conn, sqlTrans))
                        {
                            cmd.Parameters.AddWithValue("@qty", qty);
                            cmd.Parameters.AddWithValue("@bid", bookId);
                            cmd.ExecuteNonQuery();
                        }

                        sqlTrans.Commit();
                        return (true, "Returned successfully!" + fineAlert);
                    }
                    catch (Exception ex)
                    {
                        sqlTrans.Rollback();
                        return (false, "Error: " + ex.Message);
                    }
                }
            }
        }
        public bool DeleteBooks(int id) => ExecuteNonQuery("DELETE FROM `book` WHERE book_id = @id", new[] { new MySqlParameter("@id", id) }) > 0;
        public bool DeleteAuthors(int id) => ExecuteNonQuery("DELETE FROM `author` WHERE author_id = @id", new[] { new MySqlParameter("@id", id) }) > 0;
        public bool DeleteCategory(int id) => ExecuteNonQuery("DELETE FROM `category` WHERE category_id = @id", new[] { new MySqlParameter("@id", id) }) > 0;
        public bool DeleteUsers(int id) => ExecuteNonQuery("DELETE FROM `user` WHERE user_id = @id", new[] { new MySqlParameter("@id", id) }) > 0;

        public bool UpdateBook(int bookId, string title, int authorId, int categoryId, int year, int totalCopies)
        {
            string query = @"UPDATE `book` SET title=@title, author_id=@authorId, category_id=@categoryId, yearpublished=@year, total_copies=@copies WHERE book_id=@bookId";
            return ExecuteNonQuery(query, new[] {
                new MySqlParameter("@title", title), new MySqlParameter("@authorId", authorId),
                new MySqlParameter("@categoryId", categoryId), new MySqlParameter("@year", year),
                new MySqlParameter("@copies", totalCopies), new MySqlParameter("@bookId", bookId)
            }) > 0;
        }
        public bool UpdateAuthors(int id, string name, string desc)
        {
            string query = "UPDATE `author` SET author_name = @name, description = @desc WHERE author_id = @id";
            return ExecuteNonQuery(query, new[] { new MySqlParameter("@name", name), new MySqlParameter("@desc", desc), new MySqlParameter("@id", id) }) > 0;
        }
        public bool UpdateUsers(int id, string fullname, string username, string password, string role)
        {
            string query = "UPDATE `user` SET fullname=@fn, username=@un, password=@pw, role=@role WHERE user_id=@id";
            return ExecuteNonQuery(query, new[] {
                new MySqlParameter("@fn", fullname), new MySqlParameter("@un", username),
                new MySqlParameter("@pw", password), new MySqlParameter("@role", role), new MySqlParameter("@id", id)
            }) > 0;
        }
        public bool UpdateCategory(int id, string name)
        {
            string query = "UPDATE `category` SET category_name = @name WHERE category_id = @id";
            return ExecuteNonQuery(query, new[] { new MySqlParameter("@name", name), new MySqlParameter("@id", id) }) > 0;
        }
        public int BorrowedBookCount() => ExecuteCountQuery("SELECT COUNT(*) FROM `transaction` WHERE status = 'Borrow'");
        public int TotalUserCount() => ExecuteCountQuery("SELECT COUNT(*) FROM `user`");
        public int TotalBookCount() => ExecuteCountQuery("SELECT COUNT(*) FROM `book`");
        public int TotalAuthorCount() => ExecuteCountQuery("SELECT COUNT(*) FROM `author`");
        public int TotalCategoryCount() => ExecuteCountQuery("SELECT COUNT(*) FROM `category`");
    }
}