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

namespace lab5
{
    public partial class Add : System.Windows.Forms.Form
    {
        private string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=5sem;Integrated Security=True";
        private string table;
        public Add(string table)
        {
            InitializeComponent();
            this.table = table;
            
            if (table == "worker")
            {
                label1.Text = "Initial";
                label2.Text = "Position";
                label3.Text = "fk_goods";
                label4.Text = "fk_checks";
                label5.Visible = false;

                textBox5.Visible = false;

                this.Size = new System.Drawing.Size(350, 110);
            }
            else if (table == "checks")
            {
                label1.Text = "fSum";
                label2.Text = "fDate(M.D.Y.)";
                label3.Text = "fk_goods";
                label4.Text = "fk_worker";
                label5.Visible = false;
                
                textBox5.Visible = false;
                this.Size = new System.Drawing.Size(350, 110);
            }
            else if (table == "goods")
            {
                label1.Text = "fName";
                label2.Text = "fCount";
                label3.Text = "Price";
                label4.Text = "fk_checks";
                label5.Text = "fk_distributor";
                this.Size = new System.Drawing.Size(430, 110);
            }
            else if (table == "distributor")
            {
                label1.Text = "fName";
                label2.Text = "phone";
                label3.Text = "fk_goods";
                label4.Visible = false;
                label5.Visible = false;

                textBox4.Visible = false;
                textBox5.Visible = false;
                this.Size = new System.Drawing.Size(270, 110);
            }
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            if (table == "worker")
            {
                try
                {
                    if (!string.IsNullOrWhiteSpace(textBox1.Text) &&
                !string.IsNullOrWhiteSpace(textBox2.Text) &&
                !string.IsNullOrWhiteSpace(textBox3.Text) &&
                !string.IsNullOrWhiteSpace(textBox4.Text))
                    {
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            connection.Open();
                            string query = "INSERT INTO worker (Initial, position, fk_goods, fk_checks) VALUES (@Value1, @Value2, @Value3, @Value4)";
                            using (SqlCommand command = new SqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@Value1", textBox1.Text);
                                command.Parameters.AddWithValue("@Value2", textBox2.Text);
                                command.Parameters.AddWithValue("@Value3", textBox3.Text);
                                command.Parameters.AddWithValue("@Value4", textBox4.Text);
                                command.ExecuteNonQuery();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Oops",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            else if (table == "checks")
            {
                try
                {
                    if (!string.IsNullOrWhiteSpace(textBox1.Text) &&
                !string.IsNullOrWhiteSpace(textBox2.Text) &&
                !string.IsNullOrWhiteSpace(textBox3.Text) &&
                !string.IsNullOrWhiteSpace(textBox4.Text))
                    {
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            connection.Open();
                            string query = "INSERT INTO checks (fSum, fdate, fk_goods, fk_worker) VALUES (@Value1, @Value2, @Value3, @Value4)";
                            using (SqlCommand command = new SqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@Value1", textBox1.Text);
                                command.Parameters.AddWithValue("@Value2", textBox2.Text);
                                command.Parameters.AddWithValue("@Value3", textBox3.Text);
                                command.Parameters.AddWithValue("@Value4", textBox4.Text);
                                command.ExecuteNonQuery();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (table == "goods")
            {
                try
                {
                    if (!string.IsNullOrWhiteSpace(textBox1.Text) &&
                !string.IsNullOrWhiteSpace(textBox2.Text) &&
                !string.IsNullOrWhiteSpace(textBox3.Text) &&
                !string.IsNullOrWhiteSpace(textBox4.Text) &&
                !string.IsNullOrWhiteSpace(textBox5.Text))
                    {
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            connection.Open();
                            string query = "INSERT INTO goods (fName, fCount, Price, fk_checks, fk_distributor) VALUES (@Value1, @Value2, @Value3, @Value4, @Value5)";
                            using (SqlCommand command = new SqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@Value1", textBox1.Text);
                                command.Parameters.AddWithValue("@Value2", textBox2.Text);
                                command.Parameters.AddWithValue("@Value3", textBox3.Text);
                                command.Parameters.AddWithValue("@Value4", textBox4.Text);
                                command.Parameters.AddWithValue("@Value5", textBox5.Text);
                                command.ExecuteNonQuery();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (table == "distributor")
            {
                try
                {
                    if (!string.IsNullOrWhiteSpace(textBox1.Text) &&
                !string.IsNullOrWhiteSpace(textBox2.Text) &&
                !string.IsNullOrWhiteSpace(textBox3.Text))
                    {
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            connection.Open();
                            string query = "INSERT INTO distributor (fName, phone, fk_goods) VALUES (@Value1, @Value2, @Value3)";
                            using (SqlCommand command = new SqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@Value1", textBox1.Text);
                                command.Parameters.AddWithValue("@Value2", textBox2.Text);
                                command.Parameters.AddWithValue("@Value3", textBox3.Text);
                                command.ExecuteNonQuery();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        this.Close();
        }
    }
}
