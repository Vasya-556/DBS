using Neo4j.Driver;

namespace lab14
{
    public partial class Form1 : Form
    {
        private IDriver driver = GraphDatabase.Driver("bolt://localhost:7687", AuthTokens.Basic("neo4j", "88888888"));
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            driver?.Dispose();
        }

        private void LoadData()
        {
            try
            {
                using (var session = driver.AsyncSession())
                {
                    var result = session.ReadTransactionAsync(async transaction =>
                    {
                        var cursor = await transaction.RunAsync("MATCH (w:Worker) RETURN w");
                        return await cursor.ToListAsync();
                    });

                    dataGridView1.Rows.Clear();

                    foreach (var record in result.Result)
                    {
                        var worker = record["w"].As<INode>().Properties;
                        dataGridView1.Rows.Add(worker["id_w"], worker["Initial"], worker["position"]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading Worker data: {ex.Message}");
            }

            try
            {
                using (var session = driver.AsyncSession())
                {
                    var result = session.ReadTransactionAsync(async transaction =>
                    {
                        var cursor = await transaction.RunAsync("MATCH (c:Checks) RETURN c");
                        return await cursor.ToListAsync();
                    });

                    dataGridView2.Rows.Clear();

                    foreach (var record in result.Result)
                    {
                        var checks = record["c"].As<INode>().Properties;
                        dataGridView2.Rows.Add(checks["id_c"], checks["fSum"], checks["fdate"]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading Checks data: {ex.Message}");
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Dictionary<string, object> values = new Dictionary<string, object>
                {
                    {"id_c", int.Parse(textBox1.Text)},
                    {"fSum", double.Parse(textBox2.Text)},
                    {"fdate", DateTime.Parse(textBox3.Text)}
                };

                using (var session = driver.AsyncSession())
                {
                    var result = session.WriteTransactionAsync(async transaction =>
                    {
                        var result = await transaction.RunAsync("CREATE (c:Checks {id_c: $id_c, fSum: $fSum, fdate: date($fdate)})", values);
                        return result;
                    });

                    MessageBox.Show("Checks added successfully!");
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
                Dictionary<string, object> values = new Dictionary<string, object>
                {
                    {"id_w", int.Parse(textBox4.Text)},
                    {"Initial", textBox5.Text},
                    {"position", textBox6.Text}
                };

                using (var session = driver.AsyncSession())
                {
                    var result = session.WriteTransactionAsync(async transaction =>
                    {
                        var result = await transaction.RunAsync("CREATE (w:Worker {id_w: $id_w, Initial: $Initial, position: $position})", values);
                        return result;
                    });

                    MessageBox.Show("Worker added successfully!");
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
                int checksIdToDelete = int.Parse(textBox7.Text);

                using (var session = driver.AsyncSession())
                {
                    var result = session.WriteTransactionAsync(async transaction =>
                    {
                        var result = await transaction.RunAsync("MATCH (c:Checks {id_c: $id_c}) DETACH DELETE c", new { id_c = checksIdToDelete });
                        return result;
                    });

                    MessageBox.Show("Checks deleted successfully!");
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
                int workerIdToDelete = int.Parse(textBox8.Text);

                using (var session = driver.AsyncSession())
                {
                    var result = session.WriteTransactionAsync(async transaction =>
                    {
                        var result = await transaction.RunAsync("MATCH (w:Worker {id_w: $id_w}) DETACH DELETE w", new { id_w = workerIdToDelete });
                        return result;
                    });

                    MessageBox.Show("Worker deleted successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int checksId = int.Parse(textBox10.Text);
            try
            {
                using (var session = driver.AsyncSession())
                {
                    var result = session.ReadTransactionAsync(async transaction =>
                    {
                        var cursor = await transaction.RunAsync("MATCH (c:Checks {id_c: $id_c}) RETURN c", new { id_c = checksId });
                        return await cursor.ToListAsync();
                    });

                    dataGridView2.Rows.Clear();

                    foreach (var record in result.Result)
                    {
                        var checks = record["c"].As<INode>().Properties;
                        dataGridView2.Rows.Add(checks["id_c"], checks["fSum"], checks["fdate"]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching Checks data: {ex.Message}");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int workerId = int.Parse(textBox9.Text);
            try
            {
                using (var session = driver.AsyncSession())
                {
                    var result = session.ReadTransactionAsync(async transaction =>
                    {
                        var cursor = await transaction.RunAsync("MATCH (w:Worker {id_w: $id_w}) RETURN w", new { id_w = workerId });
                        return await cursor.ToListAsync();
                    });

                    dataGridView1.Rows.Clear();

                    foreach (var record in result.Result)
                    {
                        var worker = record["w"].As<INode>().Properties;
                        dataGridView1.Rows.Add(worker["id_w"], worker["Initial"], worker["position"]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching Worker data: {ex.Message}");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int workerId = int.Parse(textBox11.Text);
            int checksId = int.Parse(textBox12.Text);
            try
            {
                using (var session = driver.AsyncSession())
                {
                    var result = session.WriteTransactionAsync(async transaction =>
                    {
                        await transaction.RunAsync(
                            "MATCH (w:Worker {id_w: $workerId}), (c:Checks {id_c: $checksId}) CREATE (w)-[:HAS_CHECK]->(c)",
                            new { workerId, checksId });

                        return "Relationship added successfully!";
                    });

                    MessageBox.Show(result.Result);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding relationship: {ex.Message}");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int workerId = int.Parse(textBox13.Text);
            int checksId = int.Parse(textBox14.Text);
            try
            {
                using (var session = driver.AsyncSession())
                {
                    var result = session.WriteTransactionAsync(async transaction =>
                    {
                        await transaction.RunAsync(
                            "MATCH (w:Worker {id_w: $workerId})-[r:HAS_CHECK]->(c:Checks {id_c: $checksId}) DELETE r",
                            new { workerId, checksId });

                        return "Relationship deleted successfully!";
                    });

                    MessageBox.Show(result.Result);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting relationship: {ex.Message}");
            }
        }
    }
}
