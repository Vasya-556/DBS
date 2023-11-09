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

namespace lab7
{
    public partial class Form1 : Form
    {
        private string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=lab6;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lab6DataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.lab6DataSet.Products);

        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            string productName = Add_textbox.Text;

            if (!string.IsNullOrEmpty(productName))
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand("AddProduct", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@ProductName", productName);
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                        {
                            DataTable dataTable = new DataTable();
                            dataTable.Load(reader);

                            dataGridView1.DataSource = dataTable;
                        }
                        else
                        {
                            MessageBox.Show("This is new name for table!", "Result",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        }
                    }

                    connection.Close();
                }
            }
            Add_textbox.Text = "";
        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            string productName = Delete_textbox.Text;

            if (!string.IsNullOrEmpty(productName))
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand("DeleteProduct", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@ProductName", productName);
                        cmd.ExecuteNonQuery();
                    }

                    connection.Close();
                }
            }
            Delete_textbox.Text = "";
        }

        private void Refresh_button_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Products";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dataGridView1.DataSource = dataTable;
                    }
                }
            }
        }
    }
}
