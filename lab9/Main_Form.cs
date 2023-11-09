using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab9
{
    public partial class Main_Form : Form
    {
        private string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=lab9;Integrated Security=True";
        private bool isAdmin;
        private string username;
        private string userId;
        private string Category = "All";
        private string SubCategory = "All";
        private int SubCategoryId = 0;
        public Main_Form(string username, bool isAdmin, string userId)
        {
            InitializeComponent();
            this.isAdmin = isAdmin;
            this.username = username;
            this.userId = userId;

            if (isAdmin)
            {
                AdminPanel_Button.Visible = true;
            }
        }

        private void Profile_Button_Click(object sender, EventArgs e)
        {
            Profile_Form form = new Profile_Form(username, isAdmin, userId);
            
            form.FormClosed += (s, args) =>
            {
                this.Close();
            };
            this.Hide();
            form.Show();
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Products WHERE is_ordered = 0";

                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    DataSet dataset = new DataSet();

                    adapter.Fill(dataset, "Products");

                    DataTable table = dataset.Tables["Products"];

                    ProductsTable.DataSource = table;
                }
            }

            List<ComboBoxData_Class> CategoriesList = new List<ComboBoxData_Class>();
            List<ComboBoxData_Class> SubCategoriesList = new List<ComboBoxData_Class>();

            CategoriesList.Add(new ComboBoxData_Class(){ ID = "00", Name = "All" });
            CategoriesList.Add(new ComboBoxData_Class(){ ID = "01", Name = "Animals" });
            CategoriesList.Add(new ComboBoxData_Class(){ ID = "02", Name = "Food" });
            CategoriesList.Add(new ComboBoxData_Class(){ ID = "03", Name = "Hygiene Products" });
            CategoriesList.Add(new ComboBoxData_Class(){ ID = "04", Name = "Medicine and Vitamins" });
            CategoriesList.Add(new ComboBoxData_Class(){ ID = "05", Name = "Other"});

            SubCategoriesList.Add(new ComboBoxData_Class() { ID = "01", Name = "All" });
            SubCategoriesList.Add(new ComboBoxData_Class() { ID = "06", Name = "Mammals" });
            SubCategoriesList.Add(new ComboBoxData_Class() { ID = "07", Name = "Rodents" });
            SubCategoriesList.Add(new ComboBoxData_Class() { ID = "08", Name = "Reptiles" });
            SubCategoriesList.Add(new ComboBoxData_Class() { ID = "09", Name = "Birds" });
            SubCategoriesList.Add(new ComboBoxData_Class() { ID = "10", Name = "Fish" });
            SubCategoriesList.Add(new ComboBoxData_Class() { ID = "11", Name = "Dry Food" });
            SubCategoriesList.Add(new ComboBoxData_Class() { ID = "12", Name = "Wet Food" });
            SubCategoriesList.Add(new ComboBoxData_Class() { ID = "13", Name = "Bird Food" });
            SubCategoriesList.Add(new ComboBoxData_Class() { ID = "14", Name = "Shampoo" });
            SubCategoriesList.Add(new ComboBoxData_Class() { ID = "15", Name = "Litter" });
            SubCategoriesList.Add(new ComboBoxData_Class() { ID = "16", Name = "Tray" });
            SubCategoriesList.Add(new ComboBoxData_Class() { ID = "17", Name = "Flea Medication" });
            SubCategoriesList.Add(new ComboBoxData_Class() { ID = "18", Name = "Worm Medication" });
            SubCategoriesList.Add(new ComboBoxData_Class() { ID = "19", Name = "Wound Care" });
            SubCategoriesList.Add(new ComboBoxData_Class() { ID = "20", Name = "Accessories" });
            SubCategoriesList.Add(new ComboBoxData_Class() { ID = "21", Name = "Toys" });

            Categories_Combobox.DataSource = CategoriesList;
            Categories_Combobox.ValueMember = "ID";
            Categories_Combobox.DisplayMember = "Name";

            SubCategories_Combobox.DataSource = SubCategoriesList;
            SubCategories_Combobox.ValueMember = "ID";
            SubCategories_Combobox.DisplayMember = "Name";
        }

        private void Back_Button_Click(object sender, EventArgs e)
        {
            SignIn_Form form = new SignIn_Form();
            form.FormClosed += (s, args) =>
            {
                this.Close();
            };
            this.Hide();
            form.Show();
        }

        private void AdminPanel_Button_Click(object sender, EventArgs e)
        {
            Admin_Form form = new Admin_Form(username, userId);
            form.FormClosed += (s, args) =>
            {
                this.Close();
            };
            this.Hide();
            form.Show();
        }

        private void Categories_Combobox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            List<ComboBoxData_Class> SubCategoriesList = new List<ComboBoxData_Class>();

            SubCategoriesList.Add(new ComboBoxData_Class() { ID = "00", Name = "All" });

            ComboBoxData_Class obj = (ComboBoxData_Class)Categories_Combobox.SelectedItem;

            if (obj.Name == "Animals")
            {
                SubCategoriesList.Add(new ComboBoxData_Class() { ID = "06", Name = "Mammals" });
                SubCategoriesList.Add(new ComboBoxData_Class() { ID = "07", Name = "Rodents" });
                SubCategoriesList.Add(new ComboBoxData_Class() { ID = "08", Name = "Reptiles" });
                SubCategoriesList.Add(new ComboBoxData_Class() { ID = "09", Name = "Birds" });
                SubCategoriesList.Add(new ComboBoxData_Class() { ID = "10", Name = "Fish" });
            }
            else if (obj.Name == "Food")
            {
                SubCategoriesList.Add(new ComboBoxData_Class() { ID = "11", Name = "Dry Food" });
                SubCategoriesList.Add(new ComboBoxData_Class() { ID = "12", Name = "Wet Food" });
                SubCategoriesList.Add(new ComboBoxData_Class() { ID = "13", Name = "Bird Food" });
            }
            else if (obj.Name == "Hygiene Products")
            {
                SubCategoriesList.Add(new ComboBoxData_Class() { ID = "14", Name = "Shampoo" });
                SubCategoriesList.Add(new ComboBoxData_Class() { ID = "15", Name = "Litter" });
                SubCategoriesList.Add(new ComboBoxData_Class() { ID = "16", Name = "Tray" });
            }
            else if (obj.Name == "Medicine and Vitamins")
            {
                SubCategoriesList.Add(new ComboBoxData_Class() { ID = "17", Name = "Flea Medication" });
                SubCategoriesList.Add(new ComboBoxData_Class() { ID = "18", Name = "Worm Medication" });
                SubCategoriesList.Add(new ComboBoxData_Class() { ID = "19", Name = "Wound Care" });
            }
            else if (obj.Name == "Other")
            {
                SubCategoriesList.Add(new ComboBoxData_Class() { ID = "20", Name = "Accessories" });
                SubCategoriesList.Add(new ComboBoxData_Class() { ID = "21", Name = "Toys" });
            }
            else
            {
                SubCategoriesList.Add(new ComboBoxData_Class() { ID = "06", Name = "Mammals" });
                SubCategoriesList.Add(new ComboBoxData_Class() { ID = "07", Name = "Rodents" });
                SubCategoriesList.Add(new ComboBoxData_Class() { ID = "08", Name = "Reptiles" });
                SubCategoriesList.Add(new ComboBoxData_Class() { ID = "09", Name = "Birds" });
                SubCategoriesList.Add(new ComboBoxData_Class() { ID = "10", Name = "Fish" });
                SubCategoriesList.Add(new ComboBoxData_Class() { ID = "11", Name = "Dry Food" });
                SubCategoriesList.Add(new ComboBoxData_Class() { ID = "12", Name = "Wet Food" });
                SubCategoriesList.Add(new ComboBoxData_Class() { ID = "13", Name = "Bird Food" });
                SubCategoriesList.Add(new ComboBoxData_Class() { ID = "14", Name = "Shampoo" });
                SubCategoriesList.Add(new ComboBoxData_Class() { ID = "15", Name = "Litter" });
                SubCategoriesList.Add(new ComboBoxData_Class() { ID = "16", Name = "Tray" });
                SubCategoriesList.Add(new ComboBoxData_Class() { ID = "17", Name = "Flea Medication" });
                SubCategoriesList.Add(new ComboBoxData_Class() { ID = "18", Name = "Worm Medication" });
                SubCategoriesList.Add(new ComboBoxData_Class() { ID = "19", Name = "Wound Care" });
                SubCategoriesList.Add(new ComboBoxData_Class() { ID = "20", Name = "Accessories" });
                SubCategoriesList.Add(new ComboBoxData_Class() { ID = "21", Name = "Toys" });
            }
            SubCategories_Combobox.DataSource = SubCategoriesList;
            SubCategories_Combobox.ValueMember = "ID";
            SubCategories_Combobox.DisplayMember = "Name";

            Category = obj.Name;
         
            Filter();
        }

        private void SubCategories_Combobox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ComboBoxData_Class obj = (ComboBoxData_Class)SubCategories_Combobox.SelectedItem;
            SubCategory = obj.Name;
            SubCategoryId = Convert.ToInt32(obj.ID);
            
            Filter();
        }

        private void Filter()
        {
            string FilterQuery;
            if (SubCategory != "All")
            {
                FilterQuery = $"SELECT * FROM Products WHERE category_id = {SubCategoryId} AND is_ordered = 0";
            }
            else
            {
                if (Category == "All")
                {
                    FilterQuery = "SELECT * FROM products WHERE is_ordered = 0;";
                }
                else if (Category == "Animals")
                {
                    FilterQuery = $"SELECT * FROM Products WHERE category_id IN (6, 7, 8, 9, 10) AND is_ordered = 0;";
                }
                else if (Category == "Food")
                {
                    FilterQuery = $"SELECT * FROM Products WHERE category_id IN (11, 12, 13) AND is_ordered = 0;";
                }
                else if (Category == "Hygiene Products")
                {
                    FilterQuery = $"SELECT * FROM Products WHERE category_id IN (14, 15, 16) AND is_ordered = 0;";
                }
                else if (Category == "Medicine and Vitamins")
                {
                    FilterQuery = $"SELECT * FROM Products WHERE category_id IN (17, 18, 19) AND is_ordered = 0;";
                }
                else
                {
                    FilterQuery = $"SELECT * FROM Products WHERE category_id IN (20, 21) AND is_ordered = 0;";
                }
            }

            // run query
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                
                SqlCommand command = new SqlCommand(FilterQuery, connection);
                command.ExecuteNonQuery();
                
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                ProductsTable.DataSource = dataTable;
            }
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            Main_Form_Load(sender, e);

            Categories_Combobox_SelectionChangeCommitted(sender, e);
            SubCategories_Combobox_SelectionChangeCommitted(sender, e);

            Filter();
        }

        private void ProductsTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int yourButtonColumnIndex = ProductsTable.Columns["is_ordered"].Index;
            
            if (e.ColumnIndex == yourButtonColumnIndex && e.RowIndex >= 0)
            {
                int productId = Convert.ToInt32(ProductsTable.Rows[e.RowIndex].Cells["product_id"].Value);

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string updateQuery = "UPDATE Products SET is_ordered = 1 WHERE product_id = @ProductId";
                    SqlCommand updateCommand = new SqlCommand(updateQuery, connection);
                    updateCommand.Parameters.AddWithValue("@ProductId", productId);
                    int rowsUpdated = updateCommand.ExecuteNonQuery();

                    if (rowsUpdated > 0)
                    {
                        Refresh_Click(sender, e);

                        string insertQuery = "INSERT INTO Orders (user_id, product_id, order_date) " +
                                            "VALUES (@User_id, @ProductId, GETDATE())";
                        SqlCommand insertCommand = new SqlCommand(insertQuery, connection);
                        insertCommand.Parameters.AddWithValue("@User_id", userId);
                        insertCommand.Parameters.AddWithValue("@ProductId", productId);
                        insertCommand.ExecuteNonQuery();
                    }
                }
            }
        }

        private void SortingTable_Combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedSortOption = SortingTable_Combobox.SelectedItem.ToString();

            switch (selectedSortOption)
            {
                case "Name(A-Z)":
                    ProductsTable.Sort(ProductsTable.Columns["product_name"], ListSortDirection.Ascending);
                    break;
                case "Name(Z-A)":
                    ProductsTable.Sort(ProductsTable.Columns["product_name"], ListSortDirection.Descending);
                    break;
                case "Price(0-9)":
                    ProductsTable.Sort(ProductsTable.Columns["price"], ListSortDirection.Ascending);
                    break;
                case "Price(9-0)":
                    ProductsTable.Sort(ProductsTable.Columns["price"], ListSortDirection.Descending);
                    break;
                default:
                    break;
            }
        }

        private void Search_Button_Click(object sender, EventArgs e)
        {
            string productName = ProductName_Textbox.Text;
            string price = Price_Textbox.Text;

            string query;

            try
            {
                if (string.IsNullOrEmpty(productName) && !string.IsNullOrEmpty(price))
                {
                    query = $"SELECT * FROM products WHERE price = {price}";
                }
                else if (!string.IsNullOrEmpty(productName) && string.IsNullOrEmpty(price))
                {
                    query = $"SELECT * FROM products WHERE product_name = '{productName}'";
                }
                else if (!string.IsNullOrEmpty(productName) && !string.IsNullOrEmpty(price))
                {
                    query = $"SELECT * FROM products WHERE product_name = '{productName}' AND price = {price}";
                }
                else
                {
                    MessageBox.Show("Please enter either product name or price.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        DataSet dataset = new DataSet();
                        adapter.Fill(dataset, "Products");

                        DataTable table = dataset.Tables["Products"];
                        ProductsTable.DataSource = table;
                    }
                }
            }
            catch  
            {
                MessageBox.Show("Something went wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ProductsTable_SelectionChanged(object sender, EventArgs e)
        {
            if (ProductsTable.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = ProductsTable.SelectedRows[0];
                DataRowView dataRowView = (DataRowView)selectedRow.DataBoundItem;

                if (dataRowView["product_photo"] != DBNull.Value)
                {
                    byte[] imageData = (byte[])dataRowView["product_photo"];

                    if (imageData != null && imageData.Length > 0)
                    {
                        using (MemoryStream stream = new MemoryStream(imageData))
                        {
                            pictureBox1.Image = Image.FromStream(stream);
                        }
                    }
                    else
                    {
                        pictureBox1.Image = null;
                    }
                }
                else
                {
                    pictureBox1.Image = null;
                }
            }
            else
            {
                pictureBox1.Image = null;
            }
        }
    }
}