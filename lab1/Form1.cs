using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace lab1
{
    public partial class Form1 : Form
    {
        string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=5sem;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_5semDataSet1.distributor' table. You can move, or remove it, as needed.
            this.distributorTableAdapter.Fill(this._5semDataSet1.distributor);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox2.Text) &&
                !string.IsNullOrWhiteSpace(textBox3.Text) &&
                !string.IsNullOrWhiteSpace(textBox4.Text))
            {

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO distributor (fName, phone, fk_goods) VALUES (@Value1, @Value2, @Value3)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Value1", textBox2.Text);
                        command.Parameters.AddWithValue("@Value2", textBox3.Text);
                        command.Parameters.AddWithValue("@Value3", textBox4.Text);
                        command.ExecuteNonQuery();
                    }
                }
            }
            RefreshData();
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; 
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox2.Text) &&
            !string.IsNullOrWhiteSpace(textBox3.Text) &&
            !string.IsNullOrWhiteSpace(textBox4.Text))
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox2.Text) &&
            !string.IsNullOrWhiteSpace(textBox3.Text) &&
            !string.IsNullOrWhiteSpace(textBox4.Text))
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox2.Text) &&
            !string.IsNullOrWhiteSpace(textBox3.Text) &&
            !string.IsNullOrWhiteSpace(textBox4.Text))
            {
                button1.Enabled = true; 
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                button2.Enabled = true;
                button3.Enabled = true;
            }
            else
            {
                button2.Enabled = false;
                button3.Enabled = false;
            }
            if (!string.IsNullOrWhiteSpace(textBox5.Text) &&
                !string.IsNullOrWhiteSpace(textBox1.Text))
            {
                button4.Enabled = true;
            }
            else
            {
                button4.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                
                string selectedColumn = "";
                if (radioButton1.Checked)
                {
                    selectedColumn = "fName";
                }
                else if (radioButton2.Checked)
                {
                    selectedColumn = "phone";
                }
                else if (radioButton3.Checked)
                {
                    selectedColumn = "fk_goods";
                }

                string condition = "";
                if (radioButton4.Checked)
                {
                    condition = ">";
                }
                else if (radioButton5.Checked)
                {
                    condition = "<";
                }
                else if (radioButton6.Checked)
                {
                    condition = ">=";
                }
                else if (radioButton7.Checked)
                {
                    condition = "<=";
                }
                else if (radioButton8.Checked)
                {
                    condition = "=";
                }
                else if (radioButton9.Checked)
                {
                    condition = "!=";
                }

                string valueToDelete = textBox1.Text;
                
                string query = $"DELETE FROM distributor WHERE {selectedColumn} {condition} @ValueToDelete";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ValueToDelete", valueToDelete);
                    command.ExecuteNonQuery();
                }
            }
            RefreshData();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string selectedColumn = "";
                if (radioButton1.Checked)
                {
                    selectedColumn = "fName";
                }
                else if (radioButton2.Checked)
                {
                    selectedColumn = "phone";
                }
                else if (radioButton3.Checked)
                {
                    selectedColumn = "fk_goods";
                }

                string condition = "";
                if (radioButton4.Checked)
                {
                    condition = ">";
                }
                else if (radioButton5.Checked)
                {
                    condition = "<";
                }
                else if (radioButton6.Checked)
                {
                    condition = ">=";
                }
                else if (radioButton7.Checked)
                {
                    condition = "<=";
                }
                else if (radioButton8.Checked)
                {
                    condition = "=";
                }
                else if (radioButton9.Checked)
                {
                    condition = "!=";
                }

                string valueToUpdate = textBox1.Text;
                string newValue = textBox5.Text;

                string query = $"UPDATE distributor SET {selectedColumn} = @NewValue WHERE {selectedColumn} {condition} @ValueToUpdate";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NewValue", newValue);
                    command.Parameters.AddWithValue("@ValueToUpdate", valueToUpdate);
                    command.ExecuteNonQuery();
                }
            }
            RefreshData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string selectedColumn = "";
                if (radioButton1.Checked)
                {
                    selectedColumn = "fName";
                }
                else if (radioButton2.Checked)
                {
                    selectedColumn = "phone";
                }
                else if (radioButton3.Checked)
                {
                    selectedColumn = "fk_goods";
                }

                string condition = "";
                if (radioButton4.Checked)
                {
                    condition = ">";
                }
                else if (radioButton5.Checked)
                {
                    condition = "<";
                }
                else if (radioButton6.Checked)
                {
                    condition = ">=";
                }
                else if (radioButton7.Checked)
                {
                    condition = "<=";
                }
                else if (radioButton8.Checked)
                {
                    condition = "=";
                }
                else if (radioButton9.Checked)
                {
                    condition = "!=";
                }

                string valueToSearch = textBox1.Text;

                string query = $"SELECT * FROM distributor WHERE {selectedColumn} {condition} @ValueToSearch";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ValueToSearch", valueToSearch);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dataGridView3.DataSource = dataTable;
                    }
                }
            }
            RefreshData();
        }

        private void textBox5_TextChanged_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox5.Text) && 
                !string.IsNullOrWhiteSpace(textBox1.Text))
            {
                button4.Enabled = true;
            }
            else
            {
                button4.Enabled = false;
            }
        }
        private void RefreshData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM distributor";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dataGridView3.DataSource = dataTable;
                    }
                }
            }
        }

    }
}
