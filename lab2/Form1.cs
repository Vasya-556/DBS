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
using System.Xml.Linq;

namespace lab2
{
    public partial class Form1 : Form
    {
        private string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=5sem;Integrated Security=True";
        private SqlConnection connection;

        private DataSet dataSet;
        private SqlDataAdapter adapter;
        public Form1()
        {
            InitializeComponent();
            dataSet = new DataSet();
            adapter = new SqlDataAdapter();

            connection = new SqlConnection(connectionString);
            connection.Open();

            adapter.SelectCommand = new SqlCommand("SELECT * FROM distributor", connection);
            adapter.Fill(dataSet, "DistributorData");

            dataGridView1.DataSource = dataSet.Tables["DistributorData"];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlDataAdapter adapter = new SqlDataAdapter())
                {
                    adapter.SelectCommand = new SqlCommand("SELECT * FROM distributor", connection);
                    SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

                    DataRow newRow = dataSet.Tables["DistributorData"].NewRow();
                    newRow["fName"] = textBox1.Text;
                    newRow["phone"] = Convert.ToInt32(textBox2.Text);
                    newRow["fk_goods"] = Convert.ToInt32(textBox3.Text);
                    dataSet.Tables["DistributorData"].Rows.Add(newRow);

                    adapter.Update(dataSet, "DistributorData");
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text) &&
                !string.IsNullOrWhiteSpace(textBox2.Text) &&
                !string.IsNullOrWhiteSpace(textBox3.Text)){
                button1.Enabled = true;
            }
            else { 
                button1.Enabled = false; 
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text) &&
                !string.IsNullOrWhiteSpace(textBox2.Text) &&
                !string.IsNullOrWhiteSpace(textBox3.Text))
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
            if (!string.IsNullOrWhiteSpace(textBox1.Text) &&
                !string.IsNullOrWhiteSpace(textBox2.Text) &&
                !string.IsNullOrWhiteSpace(textBox3.Text))
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
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

            string valueToDelete = textBox4.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = $"DELETE FROM distributor WHERE {selectedColumn} {condition} @ValueToDelete";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ValueToDelete", valueToDelete);
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        dataSet.Tables["DistributorData"].Clear();
                        adapter.Fill(dataSet, "DistributorData");
                    }
                }
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox4.Text))
            {
                button2.Enabled = true;
                button3.Enabled = true;
            }
            else
            {
                button2.Enabled = false;
                button3.Enabled = false;
            }
            if (!string.IsNullOrWhiteSpace(textBox4.Text) &&
                !string.IsNullOrWhiteSpace(textBox5.Text))
            {
                button4.Enabled = true;
            }
            else
            {
                button4.Enabled = false;
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox4.Text) &&
                !string.IsNullOrWhiteSpace(textBox5.Text))
            {
                button4.Enabled = true;
            }
            else
            {
                button4.Enabled = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
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

            string valueToSearch = textBox4.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = $"SELECT * FROM distributor WHERE {selectedColumn} {condition} @ValueToSearch";

                using (SqlDataAdapter searchAdapter = new SqlDataAdapter(query, connection))
                {
                    searchAdapter.SelectCommand.Parameters.AddWithValue("@ValueToSearch", valueToSearch);
                    DataSet searchDataSet = new DataSet();
                    searchAdapter.Fill(searchDataSet, "SearchResults");

                    dataGridView1.DataSource = searchDataSet.Tables["SearchResults"];
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
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

            string valueToUpdate = textBox4.Text;
            string newValue = textBox5.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = $"UPDATE distributor SET {selectedColumn} = @NewValue WHERE {selectedColumn} {condition} @ValueToUpdate";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NewValue", newValue);
                    command.Parameters.AddWithValue("@ValueToUpdate", valueToUpdate);
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        dataSet.Tables["DistributorData"].Clear();
                        adapter.Fill(dataSet, "DistributorData");
                    }
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM distributor";

                using (SqlDataAdapter showAllAdapter = new SqlDataAdapter(query, connection))
                {
                    DataSet showAllDataSet = new DataSet();
                    showAllAdapter.Fill(showAllDataSet, "AllData");

                    dataGridView1.DataSource = showAllDataSet.Tables["AllData"];
                }
            }
        }
    }
}
