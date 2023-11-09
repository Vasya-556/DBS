using System;
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
    public partial class Admin_Form : Form
    {
        private string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=lab9;Integrated Security=True";
        private string username;
        private string userId;
        public Admin_Form(string username, string userId)
        {
            this.username = username;
            this.userId = userId;
            InitializeComponent();
        }

        private void Admin_Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lab9DataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.lab9DataSet.Users);
            // TODO: This line of code loads data into the 'lab9DataSet.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.lab9DataSet.Orders);
            // TODO: This line of code loads data into the 'lab9DataSet.Categories' table. You can move, or remove it, as needed.
            this.categoriesTableAdapter.Fill(this.lab9DataSet.Categories);
            // TODO: This line of code loads data into the 'lab9DataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.lab9DataSet.Products);

            List<ComboBoxData_Class> list = new List<ComboBoxData_Class>();
            list.Add(new ComboBoxData_Class() { ID = "01", Name = "Products"});
            list.Add(new ComboBoxData_Class() { ID = "02", Name = "Categories"});
            list.Add(new ComboBoxData_Class() { ID = "03", Name = "Orders" });
            if (username == "PetShop")
            {
                list.Add(new ComboBoxData_Class() { ID = "04", Name = "Users" });
            }
            Table_Combobox.DataSource = list;
            Table_Combobox.ValueMember = "ID";
            Table_Combobox.DisplayMember = "Name";
        }

        private void Back_Button_Click(object sender, EventArgs e)
        {
            Main_Form form = new Main_Form(username, true, userId);
            form.FormClosed += (s, args) =>
            {
                this.Close();
            };
            this.Hide();
            form.Show();
        }
        
        private void AddData_Button_Click(object sender, EventArgs e)
        {
            Working_Form form = new Working_Form("Add");
            form.Show();
        }
        
        private void RemoveData_Button_Click(object sender, EventArgs e)
        {
            Working_Form form = new Working_Form("Remove");
            form.Show();
        }
        
        private void UpdateData_Button_Click(object sender, EventArgs e)
        {
            Working_Form form = new Working_Form("Update");
            form.Show();
        }

        private void SearchData_Button_Click(object sender, EventArgs e)
        {
            Working_Form form = new Working_Form("Search");
            form.Show();
        }

        private void AllProducts_radiobutton_CheckedChanged(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Products";

                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    DataSet dataset = new DataSet();

                    adapter.Fill(dataset, "Products");

                    DataTable table = dataset.Tables["Products"];

                    ProductsTable.DataSource = table;
                }
            }
        }

        private void OrderedProducts_Radiobutton_CheckedChanged(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Products WHERE is_ordered = 1";

                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    DataSet dataset = new DataSet();

                    adapter.Fill(dataset, "Products");

                    DataTable table = dataset.Tables["Products"];

                    ProductsTable.DataSource = table;
                }
            }
        }

        private void NotOrderedProducts_radiobutton_CheckedChanged(object sender, EventArgs e)
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
        }
        
        private void Table_Combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Table_Combobox.SelectedItem != null)
            {
                ComboBoxData_Class selectedOption = (ComboBoxData_Class)Table_Combobox.SelectedItem;

                if (selectedOption.Name == "Products")
                {
                    ProductsTable.Visible = true;
                    groupBox1.Visible = true;
                    CategoriesTable.Visible = false;
                    OrdersTable.Visible = false;
                    UsersTable.Visible = false;
                }
                else if (selectedOption.Name == "Categories")
                {
                    ProductsTable.Visible = false;
                    pictureBox1.Image = null;
                    groupBox1.Visible = false;
                    CategoriesTable.Visible = true;
                    OrdersTable.Visible = false;
                    UsersTable.Visible = false;
                }
                else if (selectedOption.Name == "Orders")
                {
                    ProductsTable.Visible = false;
                    pictureBox1.Image = null;
                    groupBox1.Visible = false;
                    CategoriesTable.Visible = false;
                    OrdersTable.Visible = true;
                    UsersTable.Visible = false;
                }
                else
                {
                    ProductsTable.Visible = false;
                    pictureBox1.Image = null;
                    groupBox1.Visible = false;
                    CategoriesTable.Visible = false;
                    OrdersTable.Visible = false;
                    UsersTable.Visible = true;
                }
            }
        }

        private void ProductsTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int buttonColumnIndex = ProductsTable.Columns["Send"].Index;
            try
            {
                if (e.ColumnIndex == buttonColumnIndex && e.RowIndex >= 0)
                {
                    int productId = Convert.ToInt32(ProductsTable.Rows[e.RowIndex].Cells["product_id_"].Value);

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string deleteProductQuery = "DELETE FROM Products WHERE product_id = @ProductId";
                        SqlCommand deleteProductCommand = new SqlCommand(deleteProductQuery, connection);
                        deleteProductCommand.Parameters.AddWithValue("@ProductId", productId);

                        int rowsDeleted = deleteProductCommand.ExecuteNonQuery();

                        if (rowsDeleted > 0)
                        {
                            string deleteOrderQuery = "DELETE FROM Orders WHERE product_id = @ProductId";
                            SqlCommand deleteOrderCommand = new SqlCommand(deleteOrderQuery, connection);
                            deleteOrderCommand.Parameters.AddWithValue("@ProductId", productId);

                            int ordersDeleted = deleteOrderCommand.ExecuteNonQuery();

                            if (ordersDeleted > 0)
                            {
                                RefreshProductsTable(); 
                                RefreshOrdersTable(); 
                            }
                            else
                            {
                                MessageBox.Show("Error while sending a product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Error while sending a product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UsersTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    int userId = Convert.ToInt32(UsersTable.Rows[e.RowIndex].Cells["Id"].Value);

                    bool currentIsAdmin = Convert.ToBoolean(UsersTable.Rows[e.RowIndex].Cells["is_admin"].Value);

                    bool newIsAdmin = !currentIsAdmin;

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string updateQuery = "UPDATE Users SET is_admin = @IsAdmin WHERE id = @UserId";
                        SqlCommand updateCommand = new SqlCommand(updateQuery, connection);
                        updateCommand.Parameters.AddWithValue("@IsAdmin", newIsAdmin);
                        updateCommand.Parameters.AddWithValue("@UserId", userId);

                        int rowsUpdated = updateCommand.ExecuteNonQuery();

                        if (rowsUpdated == 0)
                        {
                            MessageBox.Show("Something went wrong","Oops!",MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                RefreshUserTable();
            }
            catch {
                MessageBox.Show("Something went wrong","Oops!",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefreshUserTable()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string selectQuery = "SELECT * FROM Users";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(selectQuery, connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                UsersTable.DataSource = dataTable;
            }
        }

        private void RefreshProductsTable()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string selectQuery = "SELECT * FROM Products";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(selectQuery, connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                ProductsTable.DataSource = dataTable;
            }
        }

        private void RefreshOrdersTable()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string selectQuery = "SELECT * FROM Orders";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(selectQuery, connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                OrdersTable.DataSource = dataTable;
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

        private void SendAllOrderedProducts_Button_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string selectOrderedProductsQuery = "SELECT product_id FROM Products WHERE is_ordered = 1";
                    SqlCommand selectOrderedProductsCommand = new SqlCommand(selectOrderedProductsQuery, connection);
                    List<int> orderedProductIds = new List<int>();

                    using (SqlDataReader reader = selectOrderedProductsCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int productId = reader.GetInt32(0);
                            orderedProductIds.Add(productId);
                        }
                    }

                    foreach (int productId in orderedProductIds)
                    {
                        string deleteProductQuery = "DELETE FROM Products WHERE product_id = @ProductId";
                        SqlCommand deleteProductCommand = new SqlCommand(deleteProductQuery, connection);
                        deleteProductCommand.Parameters.AddWithValue("@ProductId", productId);

                        int rowsDeleted = deleteProductCommand.ExecuteNonQuery();

                        if (rowsDeleted > 0)
                        {
                            string deleteOrderQuery = "DELETE FROM Orders WHERE product_id = @ProductId";
                            SqlCommand deleteOrderCommand = new SqlCommand(deleteOrderQuery, connection);
                            deleteOrderCommand.Parameters.AddWithValue("@ProductId", productId);

                            int ordersDeleted = deleteOrderCommand.ExecuteNonQuery();

                            if (ordersDeleted > 0)
                            {
                                RefreshOrdersTable();
                            }
                            else
                            {
                                MessageBox.Show("Error while sending a product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Error while sending a product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    RefreshProductsTable(); 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefreshData_Button_Click(object sender, EventArgs e)
        {
            RefreshProductsTable();
            RefreshOrdersTable();
            RefreshUserTable();
        }
    }
}