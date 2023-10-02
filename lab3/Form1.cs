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
    public partial class Form1 : Form
    {
        private string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=lab3;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            bool isAdmin;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please fill in both login and password fields.");
                return;
            }

            if (CheckCredentials(username, password, out isAdmin))
            {
                Form2 form2 = new Form2(isAdmin);
                form2.FormClosed += (s, args) =>
                {
                    this.Show();
                };
                this.Hide(); 
                form2.Show();

                textBox1.Text = "";
                textBox2.Text = "";
            }
            else
            {
                MessageBox.Show("Invalid login or password. Please try again.");
            }
        }

        private bool CheckCredentials(string username, string password, out bool isAdmin)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string selectQuery = "SELECT COUNT(*), MAX(CAST(is_admin AS INT)) FROM users WHERE username = @Username AND password = @Password";
                SqlCommand cmd = new SqlCommand(selectQuery, connection);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    int count = reader.GetInt32(0);
                    int isAdminValue = reader.GetInt32(1);

                    isAdmin = isAdminValue == 1;

                    return count > 0;
                }
            }

            isAdmin = false; 
            return false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form form3 = new Form3();

            form3.FormClosed += (s, args) =>
            {
                this.Show();
            };
            this.Hide();
            form3.Show();

            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}
