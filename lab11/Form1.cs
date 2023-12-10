using System.Data;
using System.Data.SQLite;

namespace lab11
{
    public partial class Form1 : Form
    {
        SQLiteConnection conn;
        public Form1()
        {
            InitializeComponent();
            conn = new SQLiteConnection("Data Source=lab11.db");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            LoadDataIntoDataGridView(dataGridView1, "Select * FROM Visitors");
            LoadDataIntoDataGridView(dataGridView2, "Select * FROM Coaches");
        }

        private void LoadDataIntoDataGridView(DataGridView dataGridView, string query)
        {
            try
            {
                conn.Open();

                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, conn))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                conn.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string newCoachName = textBox1.Text.Trim();

                if (!string.IsNullOrEmpty(newCoachName))
                {
                    using (SQLiteConnection conn = new SQLiteConnection("Data Source=lab11.db"))
                    {
                        conn.Open();

                        string insertCoachQuery = $"INSERT INTO Coaches (Name) VALUES ('{newCoachName}')";
                        using (SQLiteCommand cmd = new SQLiteCommand(insertCoachQuery, conn))
                        {
                            cmd.ExecuteNonQuery();
                        }
                    }

                    LoadData();
                }
                else
                {
                    MessageBox.Show("Please enter a coach name.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string coachNameToDelete = textBox2.Text.Trim();

                if (!string.IsNullOrEmpty(coachNameToDelete))
                {
                    using (SQLiteConnection conn = new SQLiteConnection("Data Source=lab11.db"))
                    {
                        conn.Open();

                        string getCoachIdQuery = $"SELECT ID FROM Coaches WHERE Name = '{coachNameToDelete}'";
                        int coachIdToDelete;
                        using (SQLiteCommand cmd = new SQLiteCommand(getCoachIdQuery, conn))
                        {
                            object result = cmd.ExecuteScalar();
                            if (result != null && int.TryParse(result.ToString(), out coachIdToDelete))
                            {
                                string deleteCoachQuery = $"DELETE FROM Coaches WHERE ID = {coachIdToDelete}";
                                using (SQLiteCommand deleteCmd = new SQLiteCommand(deleteCoachQuery, conn))
                                {
                                    deleteCmd.ExecuteNonQuery();
                                }
                                LoadData();
                            }
                            else
                            {
                                MessageBox.Show("Coach not found.");
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a coach name.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string searchCoachName = textBox2.Text.Trim();

                if (!string.IsNullOrEmpty(searchCoachName))
                {
                    string searchQuery = $"Select * FROM Coaches WHERE Name LIKE '%{searchCoachName}%'";
                    LoadDataIntoDataGridView(dataGridView2, searchQuery);
                }
                else
                {
                    MessageBox.Show("Please enter a coach name to search.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string oldCoachName = textBox3.Text.Trim();
                string newCoachName = textBox4.Text.Trim();

                if (!string.IsNullOrEmpty(oldCoachName) && !string.IsNullOrEmpty(newCoachName))
                {
                    using (SQLiteConnection conn = new SQLiteConnection("Data Source=lab11.db"))
                    {
                        conn.Open();

                        string updateQuery = $"UPDATE Coaches SET Name = '{newCoachName}' WHERE Name = '{oldCoachName}'";
                        using (SQLiteCommand cmd = new SQLiteCommand(updateQuery, conn))
                        {
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                LoadData();
                            }
                            else
                            {
                                MessageBox.Show("No coach found with the provided old name.");
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please enter both old and new coach names.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sortOrder = (comboBox1.SelectedItem.ToString() == "A-Z") ? "ASC" : "DESC";

            LoadDataIntoDataGridView(dataGridView2, $"SELECT * FROM Coaches ORDER BY Name {sortOrder}");
        }
    }
}