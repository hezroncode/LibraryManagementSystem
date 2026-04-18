using MySql.Data.MySqlClient;
using System.Data;

namespace ColegioLibrarySystem.Helpers
{
    public class DatabaseHelper
    {
        // The connector for the database
        private string connectionString = "Server=localhost;Database=librarymanagementdb;Uid=root;Pwd=;Convert Zero Datetime=True;";

        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }

        // For the SELECT queries
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
        // For the INSERT, DELETE, and UPDATE queries
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

        /* 
          Below are the reusable dbhelper code extension for most of the database queries:
            # Return/Retrieving (Books, Categories, Authors, Users, Transactions, Books borrowed(user), TransactionHistory(user))
            # Borrowing and Returning books
            # Delete and Update functions for the Admin dashboard
          
          All you have to do is to create an instance of this class and access the needed method
           Step 1. Create a private field on each dashboard { private DatabaseHelper dbhelper; }
           Step 2. Create a new instance of the class in the constructor { private DatabaseHelper dbhelper; }
           Step 3. You can now access the methods in your dashboard form like { dbhelper.GetBooks(searchquery, categoryID, authorID) }
                   don't forget the required parameters to be sent via argument
            
           This might still contain some bugs

           Contact me nalang if naa
        */

        // Returns the books from the database
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
        // Returns the categories from the database
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
            string query = @"SELECT user_id AS 'User ID', 
                                    fullname AS 'Fullname', 
                                    username AS 'Username', 
                                    password AS 'Password', 
                                    role AS 'Role' 
                           FROM User
                           WHERE (@search IS NULL OR fullname LIKE @search OR username LIKE @search)";
            MySqlParameter[] parameters = {
                new MySqlParameter("@search", string.IsNullOrEmpty(searchquery) ? (object)DBNull.Value : "%" + searchquery + "%")
            };
            return ExecuteQuery(query, parameters);
        }
        // Returns the transactions from the database 
        public DataTable GetTransactions(string searchquery = "", int userID = 0, int bookID = 0)
        {
            string query = @"SELECT t.transaction_id AS 'ID', 
                           u.fullname AS 'Borrower', 
                           b.title AS 'Book Title', 
                           t.quantity AS 'Qty', 
                           t.borrow_date AS 'Borrowed', 
                           t.return_date AS 'Returned',
                           t.status AS 'Status'
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

        // This is not used. Remove the /* */ if you plan on using this

        /*public int GetActiveBorrowCount(int userId)
        {
                string query = "SELECT COUNT(*) FROM transaction WHERE user_id = @userId AND status = 'Borrow'";
                MySqlParameter[] parameters = {
            new MySqlParameter("@userId", userId)
        };
                using (MySqlConnection conn = GetConnection())
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddRange(parameters);
                    conn.Open();
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
        }

        public bool HasAlreadyBorrowed(int userId, int bookId)
        {
                string query = "SELECT COUNT(*) FROM `transaction` WHERE user_id = @userId AND book_id = @bookId AND status = 'Borrow'";
                MySqlParameter[] parameters = {
            new MySqlParameter("@userId", userId),
            new MySqlParameter("@bookId", bookId)
        };
                using (MySqlConnection conn = GetConnection())
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddRange(parameters);
                    conn.Open();
                    return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
                }
        }*/
        // Returns the books a user has borrowed
        public DataTable GetCurrentBorrowedBooks(int userId)
        {
            string query = @"SELECT 
                        b.book_id AS 'BookID',
                        b.title AS 'Title',
                        COALESCE(a.author_name, 'Unknown') AS 'Author',
                        c.category_name AS 'Category',
                        SUM(CASE 
                            WHEN LOWER(t.status) = 'borrow' THEN t.quantity 
                            WHEN LOWER(t.status) = 'returned' THEN -t.quantity 
                            ELSE 0 
                        END) AS 'Copies'
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
        //Returns the transaction hisstory of a user
        public DataTable GetTransactionHistory(int userId)
        {
            string query = @"SELECT 
                        t.transaction_id AS 'ID',
                        b.title AS 'Title',
                        t.quantity AS 'Qty',
                        t.status AS 'Action',
                        IFNULL(t.borrow_date, t.return_date) AS 'Date'
                     FROM `transaction` t
                     JOIN book b ON t.book_id = b.book_id
                     WHERE t.user_id = @userId
                     ORDER BY t.transaction_id DESC"; // Shows newest actions at the top

            MySqlParameter[] parameters = { new MySqlParameter("@userId", userId) };
            return ExecuteQuery(query, parameters);
        }
        // For borrowing books
        public (bool success, string message) BorrowBook(int userId, string userRole, int bookId, int qty)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlTransaction sqlTrans = conn.BeginTransaction();
                try
                {
                    if (userRole == "Student")
                    {
                        qty = 1;

                        string checkStudent = @"SELECT SUM(CASE WHEN status = 'Borrow' THEN quantity ELSE -quantity END) 
                                        FROM `transaction` WHERE user_id = @uid AND book_id = @bid";
                        MySqlCommand checkStudentCmd = new MySqlCommand(checkStudent, conn, sqlTrans);
                        checkStudentCmd.Parameters.AddWithValue("@uid", userId);
                        checkStudentCmd.Parameters.AddWithValue("@bid", bookId);

                        object currentBalance = checkStudentCmd.ExecuteScalar();
                        if (currentBalance != DBNull.Value && Convert.ToInt32(currentBalance) > 0)
                        {
                            return (false, "Students can only borrow 1 copy per book. You already have this one!");
                        }
                    }
                    // Check Library Stock
                    string checkStock = "SELECT available_copies FROM book WHERE book_id = @bid";
                    MySqlCommand checkStockCmd = new MySqlCommand(checkStock, conn, sqlTrans);
                    checkStockCmd.Parameters.AddWithValue("@bid", bookId);
                    int available = Convert.ToInt32(checkStockCmd.ExecuteScalar());

                    if (available < qty) return (false, "Not enough copies available in the library.");

                    // INSERT the Borrow Transaction
                    string insertBorrow = @"INSERT INTO `transaction` (user_id, book_id, quantity, borrow_date, status) 
                                    VALUES (@uid, @bid, @qty, NOW(), 'Borrow')";
                    MySqlCommand insertCmd = new MySqlCommand(insertBorrow, conn, sqlTrans);
                    insertCmd.Parameters.AddWithValue("@uid", userId);
                    insertCmd.Parameters.AddWithValue("@bid", bookId);
                    insertCmd.Parameters.AddWithValue("@qty", qty);
                    insertCmd.ExecuteNonQuery();

                    // 4. Update Library Stock
                    string deductStock = "UPDATE book SET available_copies = available_copies - @qty WHERE book_id = @bid";
                    MySqlCommand deductCmd = new MySqlCommand(deductStock, conn, sqlTrans);
                    deductCmd.Parameters.AddWithValue("@qty", qty);
                    deductCmd.Parameters.AddWithValue("@bid", bookId);
                    deductCmd.ExecuteNonQuery();

                    sqlTrans.Commit();
                    return (true, "Book borrowed successfully!");
                }
                catch (Exception ex)
                {
                    sqlTrans.Rollback();
                    return (false, "Database Error: " + ex.Message);
                }
            }
        }

        // For returning books
        public (bool success, string message) ReturnBook(int userId, int bookId)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlTransaction sqlTrans = conn.BeginTransaction();
                try
                {
                    // Calculate the exact number of copies they CURRENTLY hold (The Balance)
                    string balanceQuery = @"SELECT SUM(CASE 
                                        WHEN LOWER(status) = 'borrow' THEN quantity 
                                        WHEN LOWER(status) = 'returned' THEN -quantity 
                                        ELSE 0 
                                    END) 
                                    FROM `transaction` 
                                    WHERE user_id = @uid AND book_id = @bid";

                    MySqlCommand balanceCmd = new MySqlCommand(balanceQuery, conn, sqlTrans);
                    balanceCmd.Parameters.AddWithValue("@uid", userId);
                    balanceCmd.Parameters.AddWithValue("@bid", bookId);

                    object result = balanceCmd.ExecuteScalar();
                    int outstandingBalance = (result != DBNull.Value) ? Convert.ToInt32(result) : 0;

                    if (outstandingBalance <= 0)
                    {
                        return (false, "You don't have any copies of this book to return.");
                    }

                    // INSERT the Return Transaction for ALL copies
                    string insertReturn = @"INSERT INTO `transaction` (user_id, book_id, quantity, return_date, status) 
                                    VALUES (@uid, @bid, @qty, NOW(), 'Returned')";
                    MySqlCommand insertCmd = new MySqlCommand(insertReturn, conn, sqlTrans);
                    insertCmd.Parameters.AddWithValue("@uid", userId);
                    insertCmd.Parameters.AddWithValue("@bid", bookId);
                    insertCmd.Parameters.AddWithValue("@qty", outstandingBalance); // Returns EVERYTHING they hold
                    insertCmd.ExecuteNonQuery();

                    // Restore ALL copies back to the Library Stock
                    string addStock = "UPDATE book SET available_copies = available_copies + @qty WHERE book_id = @bid";
                    MySqlCommand addCmd = new MySqlCommand(addStock, conn, sqlTrans);
                    addCmd.Parameters.AddWithValue("@qty", outstandingBalance);
                    addCmd.Parameters.AddWithValue("@bid", bookId);
                    addCmd.ExecuteNonQuery();

                    sqlTrans.Commit();
                    return (true, $"Successfully returned all {outstandingBalance} copy/copies!");
                }
                catch (Exception ex)
                {
                    sqlTrans.Rollback();
                    return (false, "Database Error: " + ex.Message);
                }
            }
        }

        // All the DELETE queries for the database

        public bool DeleteBooks(int bookid)
        {
            string query = "DELETE FROM `book` WHERE book_id = @id";
            MySqlParameter[] parameters = { new MySqlParameter("@id", bookid) };

            return ExecuteNonQuery(query, parameters) > 0;
        }
        public bool DeleteAuthors(int authorid)
        {
            string query = "DELETE FROM `author` WHERE author_id = @id";
            MySqlParameter[] parameters = { new MySqlParameter("@id", authorid) };
            return ExecuteNonQuery(query, parameters) > 0;
        }
        public bool DeleteCategory(int catid)
        {
            string query = "DELETE FROM `category` WHERE category_id = @id";
            MySqlParameter[] parameters = { new MySqlParameter("@id", catid) };
            return ExecuteNonQuery(query, parameters) > 0;
        }
        public bool DeleteUsers(int userid)
        {
            string query = "DELETE FROM `user` WHERE user_id = @id";
            MySqlParameter[] parameters = { new MySqlParameter("@id", userid) };
            return ExecuteNonQuery(query, parameters) > 0;
        }

        // All the update queries for the database

        public bool UpdateBook(int bookId, string title, int authorId, int categoryId, int year, int totalCopies)
        {
            string query = @"UPDATE `book` 
                           SET title = @title, 
                           author_id = @authorId, 
                           category_id = @categoryId, 
                           yearpublished = @year, 
                           total_copies = @copies 
                           WHERE book_id = @bookId";
            MySqlParameter[] parameters = {
            new MySqlParameter("@title", title),
            new MySqlParameter("@authorId", authorId),
            new MySqlParameter("@categoryId", categoryId),
            new MySqlParameter("@year", year),
            new MySqlParameter("@copies", totalCopies),
            new MySqlParameter("@bookId", bookId)
            };
            return ExecuteNonQuery(query, parameters) > 0;
        }
        public bool UpdateAuthors(int authorid, string authorname, string description)
        {
            string query = @"UPDATE `author`
                           SET author_name = @authorname,
                           description = @desc
                           WHILE author_id = @authorid";
            MySqlParameter[] parameters = {
            new MySqlParameter("@authorname", authorname),
            new MySqlParameter("@desc", description),
            new MySqlParameter("@authorid", authorid)
            };
            return ExecuteNonQuery(query, parameters) > 0;
        }
        public bool UpdateUsers(int userid, string fullname, string username, string password, string role)
        {
            string query = @"UPDATE `user`
                            SET fullname = @fullname,
                            username = @username,
                            password = @password,
                            role = @role
                            WHERE user_id = @userid";
            MySqlParameter[] parameters = {
            new MySqlParameter("@fullname", fullname),
            new MySqlParameter("@username", username),
            new MySqlParameter("@password", password),
            new MySqlParameter("@role", role),
            new MySqlParameter("@userid", userid)
            };
            return ExecuteNonQuery(query, parameters) > 0;
        }
        public bool UpdateCategory(int catid, string catname)
        {
            string query = @"UPDATE `category`
                           SET category_name = @catname
                           WHERE category_id = @catid";
            MySqlParameter[] parameters = {
            new MySqlParameter("@catname", catname),
            new MySqlParameter("catid", catid)
            };
            return ExecuteNonQuery(query, parameters) > 0;

        }
    }
}