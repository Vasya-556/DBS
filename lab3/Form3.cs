using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3
{
    public partial class Form3 : Form
    {
        private string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=lab3;Integrated Security=True";
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            bool isAdmin = checkBox1.Checked;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please fill in both login and password fields.");
                return;
            }

            if (IsUsernameExists(username))
            {
                MessageBox.Show("Username already exists. Please choose a different one.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string insertQuery = "INSERT INTO users (username, password, is_admin) VALUES (@Username, @Password, @IsAdmin)";
                SqlCommand command = new SqlCommand(insertQuery, connection);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", password);
                command.Parameters.AddWithValue("@IsAdmin", isAdmin);

                command.ExecuteNonQuery();
            }

            this.Close();
        }
        private bool IsUsernameExists(string username)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string selectQuery = "SELECT COUNT(*) FROM users WHERE username = @Username";
                SqlCommand cmd = new SqlCommand(selectQuery, connection);
                cmd.Parameters.AddWithValue("@Username", username);

                int count = (int)cmd.ExecuteScalar();

                return count > 0;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
