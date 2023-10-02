using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4
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
            // TODO: This line of code loads data into the '_5semDataSet.showcase' table. You can move, or remove it, as needed.
            this.showcaseTableAdapter.Fill(this._5semDataSet.showcase);

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Access the underlying data source object (assuming it's a DataRow)
                DataRowView dataRowView = (DataRowView)selectedRow.DataBoundItem;

                // Assuming you have an "image" column in your DataTable
                byte[] imageData = (byte[])dataRowView["image"];

                if (imageData != null && imageData.Length > 0)
                {
                    using (MemoryStream stream = new MemoryStream(imageData))
                    {
                        // Load the image from the byte array and display it in the PictureBox
                        pictureBox1.Image = Image.FromStream(stream);
                    }
                }
                else
                {
                    // Clear the PictureBox if no image is available for the selected row
                    pictureBox1.Image = null;
                }
            }
            else
            {
                // Clear the PictureBox if no row is selected
                pictureBox1.Image = null;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.gif)|*.jpg; *.jpeg; *.png; *.gif";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBox2.Image = Image.FromFile(openFileDialog.FileName);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Please enter a detail.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if an image is selected
            if (pictureBox2.Image == null)
            {
                MessageBox.Show("Please select an image.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Convert the image to a byte array
                byte[] imageData;
                using (MemoryStream stream = new MemoryStream())
                {
                    pictureBox2.Image.Save(stream, ImageFormat.Jpeg); 
                    imageData = stream.ToArray();
                }

                // Insert the data into the database
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO showcase (detail, image) VALUES (@detail, @image)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@detail", textBox1.Text);
                        command.Parameters.AddWithValue("@image", imageData);
                        command.ExecuteNonQuery();
                    }
                }
                textBox1.Text = "";
                pictureBox2.Image = null;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM showcase";

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

        private void button4_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string valueToDelete = textBox1.Text;

                string query = $"DELETE FROM showcase WHERE id_s = @ValueToDelete";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ValueToDelete", valueToDelete);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
