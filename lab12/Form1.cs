using Google.Cloud.Firestore;
using System.Windows.Forms;

namespace lab12
{
    public partial class Form1 : Form
    {
        //https://console.firebase.google.com/u/0/project/petshop-1840a/firestore/data/~2Fchecks~2FCobnNC2KS9ym8CTbuYA5
        private FirestoreDb database;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + @"petshop-1840a-firebase-adminsdk-h6xr0-4389421df2.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);
            database = FirestoreDb.Create("petshop-1840a");
            LoadData();
        }
        private void LoadData()
        {
            ClearDataGridView(dataGridView1);
            ClearDataGridView(dataGridView2);
            ClearDataGridView(dataGridView3);
            ClearDataGridView(dataGridView4);

            GetAllDocuments("worker", dataGridView1);
            GetAllDocuments("distributor", dataGridView2);
            GetAllDocuments("checks", dataGridView3);
            GetAllDocuments("goods", dataGridView4);
        }

        private void ClearDataGridView(DataGridView dataGridView)
        {
            dataGridView.Rows.Clear();
            dataGridView.Refresh();
        }
        async void GetAllDocuments(string nameOfCollection, DataGridView dataGridView)
        {
            Query collectionQuery = database.Collection(nameOfCollection);
            QuerySnapshot snapshot = await collectionQuery.GetSnapshotAsync();

            foreach (DocumentSnapshot docSnapshot in snapshot.Documents)
            {
                if (docSnapshot.Exists)
                {
                    switch (nameOfCollection)
                    {
                        case "checks":
                            Checks checksData = docSnapshot.ConvertTo<Checks>();
                            dataGridView.Rows.Add(
                                docSnapshot.Id,
                                checksData?.fSum,
                                checksData?.fdate,
                                checksData?.fk_goods,
                                checksData?.fk_worker
                            );
                            break;

                        case "goods":
                            Goods goodsData = docSnapshot.ConvertTo<Goods>();
                            dataGridView.Rows.Add(
                                docSnapshot.Id,
                                goodsData?.fName,
                                goodsData?.fCount,
                                goodsData?.Price,
                                goodsData?.fk_checks,
                                goodsData?.fk_distributor
                            );
                            break;

                        case "distributor":
                            Distributor distributorData = docSnapshot.ConvertTo<Distributor>();
                            dataGridView.Rows.Add(
                                docSnapshot.Id,
                                distributorData?.fName,
                                distributorData?.phone,
                                distributorData?.fk_goods
                            );
                            break;

                        case "worker":
                            Worker workerData = docSnapshot.ConvertTo<Worker>();
                            dataGridView.Rows.Add(
                                docSnapshot.Id,
                                workerData?.Initial,
                                workerData?.position,
                                workerData?.fk_goods,
                                workerData?.fk_checks
                            );
                            break;


                        default:
                            break;
                    }
                }
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string Name = textBox1.Text;
                int Phone = int.Parse(textBox2.Text);
                int fk_goods = int.Parse(textBox3.Text);

                Distributor newDistributor = new Distributor
                {
                    fName = Name,
                    phone = Phone,
                    fk_goods = fk_goods
                };

                try
                {
                    DocumentReference docRef = await database.Collection("distributor").AddAsync(newDistributor);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error adding distributor: {ex.Message}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string Name = textBox6.Text;

                if (string.IsNullOrWhiteSpace(Name))
                {
                    MessageBox.Show("Please enter a distributor name to delete.");
                    return;
                }

                try
                {
                    QuerySnapshot querySnapshot = await database.Collection("distributor")
                        .WhereEqualTo("fName", Name)
                        .GetSnapshotAsync();

                    foreach (DocumentSnapshot documentSnapshot in querySnapshot.Documents)
                    {
                        await documentSnapshot.Reference.DeleteAsync();
                    }

                    MessageBox.Show($"Distributor with name '{Name}' deleted successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting distributor by name: {ex.Message}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private async void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string distributorNameToSearch = textBox6.Text;

                if (string.IsNullOrWhiteSpace(distributorNameToSearch))
                {
                    MessageBox.Show("Please enter a distributor name to search.");
                    return;
                }

                QuerySnapshot querySnapshot = await database.Collection("distributor")
                    .WhereEqualTo("fName", distributorNameToSearch)
                    .GetSnapshotAsync();

                dataGridView2.Rows.Clear();

                foreach (DocumentSnapshot documentSnapshot in querySnapshot.Documents)
                {
                    Distributor foundDistributor = documentSnapshot.ConvertTo<Distributor>();

                    if (foundDistributor != null)
                    {
                        dataGridView2.Rows.Add(foundDistributor.fName, foundDistributor.fName, foundDistributor.phone, foundDistributor.fk_goods);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private async void button5_Click(object sender, EventArgs e)
        {
            try
            {
                string oldName = textBox4.Text;
                string newName = textBox5.Text; 
                int newPhone = int.Parse(textBox7.Text);
                int newGoods = int.Parse(textBox8.Text);

                if (string.IsNullOrWhiteSpace(oldName))
                {
                    MessageBox.Show("Please enter the old distributor name to update.");
                    return;
                }

                QuerySnapshot querySnapshot = await database.Collection("distributor")
                    .WhereEqualTo("fName", oldName)
                    .GetSnapshotAsync();

                foreach (DocumentSnapshot documentSnapshot in querySnapshot.Documents)
                {
                    Distributor existingDistributor = documentSnapshot.ConvertTo<Distributor>();

                    if (existingDistributor != null)
                    {
                        existingDistributor.fName = string.IsNullOrWhiteSpace(newName) ? existingDistributor.fName : newName;
                        existingDistributor.phone = newPhone;
                        existingDistributor.fk_goods = newGoods;

                        await documentSnapshot.Reference.SetAsync(existingDistributor);

                        return;
                    }
                }

                MessageBox.Show($"Distributor with name '{oldName}' not found.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating distributor: {ex.Message}");
            }
        }
    }
}
