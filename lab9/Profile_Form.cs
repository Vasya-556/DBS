using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace lab9
{
    public partial class Profile_Form : Form
    {
        private string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=lab9;Integrated Security=True";
        private string username;
        private string userId;
        private string email;
        private string address;
        private bool isUsernameChanged = false;
        private bool isPasswordChanged = false;
        private bool isAdmin;
        public Profile_Form(string username, bool isAdmin, string userId)
        {
            this.username = username;
            this.isAdmin = isAdmin;
            this.userId = userId;
            InitializeComponent();

            Username_Textbox.Text = username;
            isUsernameChanged = false;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string selectQuery = "SELECT email, address FROM Users WHERE username = @Username";
                SqlCommand cmd = new SqlCommand(selectQuery, connection);
                cmd.Parameters.AddWithValue("@Username", username);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    email = reader["email"].ToString();
                    address = reader["address"].ToString();
                }
            }

            Email_Textbox.Text = email;
            Address_Textbox.Text = address;
        }

        private void Edit_Button_Click(object sender, EventArgs e)
        {

            if (!IsValidEmail(Email_Textbox.Text))
            {
                MessageBox.Show("Wrong email", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (isUsernameChanged && !UsernameCheck())
            {
                return;
            }

            if (isPasswordChanged && !PasswordCheck())
            {
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                int rowsAffected = 0;
                string updateQuery;

                if (isUsernameChanged && isPasswordChanged)
                {
                    updateQuery = "UPDATE Users SET email = @NewEmail, address = @NewAddress, username = @NewUsername, password = @Password WHERE username = @Username";
                }
                else if (isPasswordChanged)
                {
                    updateQuery = "UPDATE Users SET email = @NewEmail, address = @NewAddress, password = @Password WHERE username = @Username";
                }
                else if (isUsernameChanged)
                {
                    updateQuery = "UPDATE Users SET email = @NewEmail, address = @NewAddress, username = @NewUsername WHERE username = @Username";
                }
                else
                {
                    updateQuery = "UPDATE Users SET email = @NewEmail, address = @NewAddress WHERE username = @Username";
                }
                
                SqlCommand cmd = new SqlCommand(updateQuery, connection);

                byte[] passwordHash = HashPassword(Password1_Textbox.Text);
                cmd.Parameters.AddWithValue("@NewEmail", Email_Textbox.Text);
                cmd.Parameters.AddWithValue("@NewAddress", Address_Textbox.Text);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@NewUsername", Username_Textbox.Text);
                cmd.Parameters.AddWithValue("@Password", passwordHash);
                rowsAffected = cmd.ExecuteNonQuery();

                username = Username_Textbox.Text;
                Password1_Textbox.Text = "";
                Password2_Textbox.Text = "";
                isUsernameChanged = false;
                isPasswordChanged = false;

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Data updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Something went wrong", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }
        private bool PasswordCheck()
        {
            string password1 = Password1_Textbox.Text;
            string password2 = Password2_Textbox.Text;
            bool passwordsMatch = !string.IsNullOrWhiteSpace(password1) && !string.IsNullOrWhiteSpace(password2) && password1 == password2;

            if (!passwordsMatch)
            {
                MessageBox.Show("Passwords do not match or are not written down. Please write it again", "Oops",MessageBoxButtons.OK, MessageBoxIcon.Error);
                Password1_Textbox.Text = "";
                Password2_Textbox.Text = "";
                isPasswordChanged = false;
                return false;
            }

            return true;
        }
        private bool UsernameCheck()
        {
            string username = Username_Textbox.Text;
            if (!string.IsNullOrWhiteSpace(username) && IsUsernameExists(username))
            {
                MessageBox.Show("Username already exists or are not written down. Please choose a different one.", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Username_Textbox.Text = "";
                isUsernameChanged = false;
                return false;
            }

            return true;
        }
        private bool IsUsernameExists(string username)
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

        private void Username_Textbox_TextChanged(object sender, EventArgs e)
        {
            isUsernameChanged = true;
        }

        private void Password1_Textbox_TextChanged(object sender, EventArgs e)
        {
            isPasswordChanged = true;
        }

        private void Back_Button_Click(object sender, EventArgs e)
        {
            Main_Form form = new Main_Form(username, isAdmin, userId);
            form.FormClosed += (s, args) =>
            {
                this.Close();
            };
            this.Hide();
            form.Show();
        }

        private void Reset_Button_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string selectQuery = "SELECT email, address FROM Users WHERE username = @Username";
                SqlCommand cmd = new SqlCommand(selectQuery, connection);
                cmd.Parameters.AddWithValue("@Username", username);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    email = reader["email"].ToString();
                    address = reader["address"].ToString();
                }
            }
            
            Username_Textbox.Text = username;
            Email_Textbox.Text = email;
            Address_Textbox.Text = address;
            Password1_Textbox.Text = "";
            Password2_Textbox.Text = "";

            isUsernameChanged = false;
            isPasswordChanged = false;
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
    }
}
