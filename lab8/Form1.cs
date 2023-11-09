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

namespace lab8
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
            // TODO: This line of code loads data into the 'lab6DataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.lab6DataSet.Customers);
            // TODO: This line of code loads data into the 'lab6DataSet.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.lab6DataSet.Orders);
            // TODO: This line of code loads data into the 'lab6DataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.lab6DataSet.Products);
            // TODO: This line of code loads data into the 'lab6DataSet.Categories' table. You can move, or remove it, as needed.
            this.categoriesTableAdapter.Fill(this.lab6DataSet.Categories);
            // TODO: This line of code loads data into the 'lab6DataSet.Suppliers' table. You can move, or remove it, as needed.
            this.suppliersTableAdapter.Fill(this.lab6DataSet.Suppliers);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT category_id, name FROM Categories";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                cmbCategories.DataSource = dataTable;
                cmbCategories.DisplayMember = "name"; 
                cmbCategories.ValueMember = "category_id"; 
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT product_id, name FROM Products";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                cmbProducts.DataSource = dataTable;
                cmbProducts.DisplayMember = "name";
                cmbProducts.ValueMember = "product_id";
            }
        }

        private void DisplaySupplierForProduct_Click(object sender, EventArgs e)
        {
            int productId = Convert.ToInt32(cmbProducts.SelectedValue);

            string query = "SELECT S.name, S.contact_info FROM Suppliers S " +
                   "JOIN Products P ON S.supplier_id = P.supplier_id " +
                   "WHERE P.product_id = @productId";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@productId", productId);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridViewSupplierInfo.DataSource = dataTable;
            }
        }

        private void DisplayProductsInCategory_Click(object sender, EventArgs e)
        {
            int categoryId = Convert.ToInt32(cmbCategories.SelectedValue);

            string query = "SELECT name, price FROM Products " +
                   "WHERE category_id = @categoryId";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@categoryId", categoryId);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridViewProducts.DataSource = dataTable;
            }
        }

        private void DisplayOrdersForCustomers_Click(object sender, EventArgs e)
        {
            string query = "SELECT C.first_name, C.last_name, O.order_id, O.order_date, O.status " +
                   "FROM Customers C " +
                   "LEFT JOIN Orders O ON C.customer_id = O.customer_id " +
                   "ORDER BY C.customer_id, O.order_id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // Відображення списку замовлень для кожного клієнта та клієнтів для кожного замовлення на DataGridView на формі
                dataGridViewOrdersForCustomers.DataSource = dataTable;
            }
        }
    }
}
