using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab9
{
    public partial class SignUp_Form : Form
    {
        private string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=lab9;Integrated Security=True";
        public SignUp_Form()
        {
            InitializeComponent();
        }

        private void Back_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SignUp_Button_Click(object sender, EventArgs e)
        {
            string username = Login_Textbox.Text;
            string password1 = Password1_Textbox.Text;
            string password2 = Password2_Textbox.Text;
            string email = Email_Textbox.Text;
            string address = Address_Textbox.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password1) || string.IsNullOrWhiteSpace(password2) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(address))
            {
                MessageBox.Show("Please fill in all fields.", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (IsUserNameExists(username))
            {
                MessageBox.Show("Username already exists. Please choose a different one.", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!IsValidEmail(email))
            {
                MessageBox.Show("Please enter a valid email address.", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!IsValidPassword(password1, password2))
            {
                MessageBox.Show("Please enter a valid password.", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            byte[] passwordHash = HashPassword(password1);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string insertQuery = "INSERT INTO Users (username, password, is_admin, email, address) VALUES (@Username, @Password, @IsAdmin, @Email, @Address)";
                SqlCommand command = new SqlCommand(insertQuery, connection);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", passwordHash);
                command.Parameters.AddWithValue("@IsAdmin", 0);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Address", address);

                command.ExecuteNonQuery();
            }
            this.Close();
        }

        public bool IsUserNameExists(string username)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string selectQuery = "SELECT COUNT(*) FROM Users WHERE username = @Username";
                SqlCommand cmd = new SqlCommand(selectQuery, connection);
                cmd.Parameters.AddWithValue("@Username", username);

                int count = (int)cmd.ExecuteScalar();

                return count > 0;
            }
        }
        private bool IsValidEmail(string email)
        {
            string emailPattern = @"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$";
            return Regex.IsMatch(email, emailPattern);
        }
        public byte[] HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
                return sha256.ComputeHash(passwordBytes);
            }
        }
        private bool IsValidPassword(string password1, string password2)
        {
            bool passwordsMatch = !string.IsNullOrWhiteSpace(password1) && !string.IsNullOrWhiteSpace(password2) && password1 == password2;
            if (!passwordsMatch)
            {
                return false;
            }
            return true;
        }
    }
}
