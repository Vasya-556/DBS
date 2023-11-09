using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab9
{
    public partial class SignIn_Form : Form
    {
        private string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=lab9;Integrated Security=True";
        public SignIn_Form()
        {
            InitializeComponent();
        }

        private void SignIn_Button_Click(object sender, EventArgs e)
        {
            string username = Login_Textbox.Text;
            string password = Password_Textbox.Text;
            bool isAdmin;
            string userId;
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please fill in both login and password fields.", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (checkData(username,password, out isAdmin, out userId))
            {
                Main_Form form = new Main_Form(username, isAdmin, userId);
                form.FormClosed += (s, args) =>
                {
                    this.Close();
                };
                this.Hide();
                form.Show();

                Login_Textbox.Text = "";
                Password_Textbox.Text = "";
            }
            else
            {
                MessageBox.Show("Invalid login or password. Please try again.", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool checkData(string username, string password, out bool isAdmin, out string userId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string selectQuery = "SELECT COUNT(*), ISNULL(MAX(CAST(is_admin AS INT)), 0) AS isAdmin, MAX(password) AS hashedPassword, MAX(id) AS userId FROM Users WHERE username = @Username";
                SqlCommand cmd = new SqlCommand(selectQuery, connection);
                cmd.Parameters.AddWithValue("@Username", username);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    int count = reader.GetInt32(0);
                    int isAdminValue = reader.GetInt32(1);
                    byte[] hashedPassword = reader["hashedPassword"] as byte[];

                    isAdmin = isAdminValue == 1;
                    userId = reader["userId"].ToString();

                    if (count > 0)
                    {
                        byte[] enteredPasswordHash = HashPassword(password);

                        return StructuralComparisons.StructuralEqualityComparer.Equals(hashedPassword, enteredPasswordHash);
                    }
                }
            }
            userId = null;
            isAdmin = false;
            return false;
        }

        private void SignUp_Button_Click(object sender, EventArgs e)
        {
            SignUp_Form signUp_Form = new SignUp_Form();

            signUp_Form.FormClosed += (s, args) =>
            {
                this.Show();
            };
            this.Hide();
            signUp_Form.Show();

            Login_Textbox.Text = "";
            Password_Textbox.Text = "";
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
