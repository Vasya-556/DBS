using System;
using System.Collections;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lab9
{
    public partial class Working_Form : Form
    {
        private string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=lab9;Integrated Security=True";
        private string actionName;
        private System.Windows.Forms.TextBox ProductName_Textbox = new System.Windows.Forms.TextBox();
        private System.Windows.Forms.TextBox Price_Textbox = new System.Windows.Forms.TextBox();
        private System.Windows.Forms.ComboBox CategoryId_Combobox = new System.Windows.Forms.ComboBox();
        private System.Windows.Forms.PictureBox ProductPhoto_Picturebox = new System.Windows.Forms.PictureBox();
        private System.Windows.Forms.Button SelectPhotoName_Button = new System.Windows.Forms.Button();
        private System.Windows.Forms.Button ClearPictureBox_Button = new System.Windows.Forms.Button();
        private System.Windows.Forms.Button AddProduct_Button = new System.Windows.Forms.Button();
        private System.Windows.Forms.Button RemoveProduct_Button = new System.Windows.Forms.Button();
        private System.Windows.Forms.Button UpdateProduct_Button = new System.Windows.Forms.Button();
        private System.Windows.Forms.Button SearchProduct_Button = new System.Windows.Forms.Button();
        private System.Windows.Forms.ComboBox SelectColumn_Combobox = new System.Windows.Forms.ComboBox();
        private System.Windows.Forms.ComboBox SelectCondition_Combobox = new System.Windows.Forms.ComboBox();
        private System.Windows.Forms.TextBox Select_Textbox = new System.Windows.Forms.TextBox();
        private System.Windows.Forms.DataGridView Product_Table = new System.Windows.Forms.DataGridView();
        private System.Windows.Forms.TextBox NewValue_Textbox = new System.Windows.Forms.TextBox();
        private string selectedColumn = "product_id";

        public Working_Form(string actionName)
        {
            InitializeComponent();
            this.actionName = actionName;
        }

        private void Working_Form_Load(object sender, EventArgs e)
        {
            List<ComboBoxData_Class> Categories_List = new List<ComboBoxData_Class>();
            List<ComboBoxData_Class> Column_List = new List<ComboBoxData_Class>();
            List<ComboBoxData_Class> Condition_List = new List<ComboBoxData_Class>();

            Categories_List.Add(new ComboBoxData_Class() { ID = "00", Name = "Unkown" });

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT category_id, category_name FROM Categories";
                using (SqlCommand command = new SqlCommand(query, connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int category_id = reader.GetInt32(0);
                        string category_name = reader.GetString(1);
                        Categories_List.Add(new ComboBoxData_Class() { ID = category_id.ToString(), Name = category_name });
                    }
                }
            }

            Column_List.Add(new ComboBoxData_Class() { ID = "01", Name = "Id" });
            Column_List.Add(new ComboBoxData_Class() { ID = "02", Name = "Name" });
            Column_List.Add(new ComboBoxData_Class() { ID = "03", Name = "Price" });

            Condition_List.Add(new ComboBoxData_Class() { ID = "01", Name = ">" });
            Condition_List.Add(new ComboBoxData_Class() { ID = "02", Name = "<" });
            Condition_List.Add(new ComboBoxData_Class() { ID = "03", Name = ">=" });
            Condition_List.Add(new ComboBoxData_Class() { ID = "04", Name = "<=" });
            Condition_List.Add(new ComboBoxData_Class() { ID = "05", Name = "=" });
            Condition_List.Add(new ComboBoxData_Class() { ID = "06", Name = "!=" });

            ProductName_Textbox.Name = "ProductName_Textbox";
            ProductName_Textbox.Size = new Size(150, 20);
            ProductName_Textbox.Location = new Point(10, 10);

            Price_Textbox.Name = "Price_Textbox";
            Price_Textbox.Size = new Size(150, 20);
            Price_Textbox.Location = new Point(10, 40);
            Price_Textbox.KeyPress += Price_Textbox_KeyPress;

            CategoryId_Combobox.Name = "CategoryId_Combobox";
            CategoryId_Combobox.Size = new Size(150, 20);
            CategoryId_Combobox.Location = new Point(10, 70);
            CategoryId_Combobox.DropDownStyle = ComboBoxStyle.DropDownList;

            CategoryId_Combobox.DataSource = Categories_List;
            CategoryId_Combobox.ValueMember = "ID";
            CategoryId_Combobox.DisplayMember = "Name";
            CategoryId_Combobox.SelectionChangeCommitted += Categories_Combobox_SelectionChangeCommitted;
            
            ProductPhoto_Picturebox.Name = "ProductPhoto_Picturebox"; 
            ProductPhoto_Picturebox.Size = new Size(100, 100);
            ProductPhoto_Picturebox.Location = new Point(10, 110); 

            SelectPhotoName_Button.Name = "SelectPhotoName_Button";
            SelectPhotoName_Button.Text = "Select photo";
            SelectPhotoName_Button.Size = new Size(50, 50);
            SelectPhotoName_Button.Location = new Point(170, 10);
            SelectPhotoName_Button.Click += SelectPhotoName_Button_Click;

            ClearPictureBox_Button.Name = "ClearPictureBox_Button";
            ClearPictureBox_Button.Text = "Clear";
            ClearPictureBox_Button.Size = new Size(50, 50);
            ClearPictureBox_Button.Location = new Point(170, 70);
            ClearPictureBox_Button.Click += ClearPictureBox_Button_Click;

            AddProduct_Button.Name = "AddProduct_Button";
            AddProduct_Button.Text = "Add";
            AddProduct_Button.Size = new Size(50, 50);
            AddProduct_Button.Location = new Point(170, 130);
            AddProduct_Button.Click += AddProduct_Button_Click;

            RemoveProduct_Button.Name = "RemoveProduct_Button";
            RemoveProduct_Button.Text = "Remove";
            RemoveProduct_Button.Size = new Size(55, 50);
            RemoveProduct_Button.Location = new Point(170, 10);
            RemoveProduct_Button.Click += RemoveProduct_Button_Click;

            UpdateProduct_Button.Name = "UpdateProduct_Button";
            UpdateProduct_Button.Text = "Update";
            UpdateProduct_Button.Size = new Size(50, 50);
            UpdateProduct_Button.Location = new Point(170, 10);
            UpdateProduct_Button.Click += UpdateProduct_Button_Click;

            SearchProduct_Button.Name = "SearchProduct_Button";
            SearchProduct_Button.Text = "Search";
            SearchProduct_Button.Size = new Size(50, 50);
            SearchProduct_Button.Location = new Point(170, 10);
            SearchProduct_Button.Click += SearchProduct_Button_Click;

            SelectColumn_Combobox.Name = "SelectColumn_Combobox";
            SelectColumn_Combobox.Size = new Size(150, 20);
            SelectColumn_Combobox.Location = new Point(10, 100);
            SelectColumn_Combobox.DropDownStyle = ComboBoxStyle.DropDownList;
            SelectColumn_Combobox.SelectedIndexChanged += SelectColumn_Combobox_SelectedIndexChanged;

            SelectColumn_Combobox.DataSource = Column_List;
            SelectColumn_Combobox.ValueMember = "ID";
            SelectColumn_Combobox.DisplayMember = "Name";

            SelectCondition_Combobox.Name = "SelectCondition_Combobox";
            SelectCondition_Combobox.Size = new Size(150, 20);
            SelectCondition_Combobox.Location = new Point(10, 130);
            SelectCondition_Combobox.DropDownStyle = ComboBoxStyle.DropDownList;

            SelectCondition_Combobox.DataSource = Condition_List;
            SelectCondition_Combobox.ValueMember = "ID";
            SelectCondition_Combobox.DisplayMember = "Name";

            Select_Textbox.Name = "Select_Textbox";
            Select_Textbox.Size = new Size(150, 20);
            Select_Textbox.Location = new Point(10, 10);

            NewValue_Textbox.Name = "NewValue_Textbox";
            NewValue_Textbox.Size = new Size(150, 20);
            NewValue_Textbox.Location = new Point(10, 40);

            Product_Table.Name = "Product_Table";
            Product_Table.Size = new Size(560, 150);
            Product_Table.Location = new Point(10, 190);

            DataGridViewColumn productIdColumn = new DataGridViewTextBoxColumn();
            productIdColumn.HeaderText = "Product ID";
            productIdColumn.DataPropertyName = "product_id"; 

            DataGridViewColumn productNameColumn = new DataGridViewTextBoxColumn();
            productNameColumn.HeaderText = "Product Name";
            productNameColumn.DataPropertyName = "product_name";

            DataGridViewColumn priceColumn = new DataGridViewTextBoxColumn();
            priceColumn.HeaderText = "Price";
            priceColumn.DataPropertyName = "price";

            DataGridViewColumn categoryIdColumn = new DataGridViewTextBoxColumn();
            categoryIdColumn.HeaderText = "Category ID";
            categoryIdColumn.DataPropertyName = "category_id";

            DataGridViewColumn isOrderedColumn = new DataGridViewCheckBoxColumn();
            isOrderedColumn.HeaderText = "Is Ordered";
            isOrderedColumn.DataPropertyName = "is_ordered";

            Product_Table.Columns.AddRange(productIdColumn, productNameColumn, priceColumn, categoryIdColumn, isOrderedColumn);

            if (actionName == "Add")
            {
                this.Size = new Size(245,260);
                this.Controls.Add(ProductName_Textbox);
                this.Controls.Add(Price_Textbox);
                this.Controls.Add(CategoryId_Combobox);
                this.Controls.Add(ProductPhoto_Picturebox);
                this.Controls.Add(SelectPhotoName_Button);
                this.Controls.Add(ClearPictureBox_Button);
                this.Controls.Add(AddProduct_Button);
            }
            else if (actionName == "Update")
            {
                this.Size = new Size(245,200);
                this.Controls.Add(CategoryId_Combobox);
                this.Controls.Add(SelectColumn_Combobox);
                this.Controls.Add(SelectCondition_Combobox);
                this.Controls.Add(Select_Textbox);
                this.Controls.Add(NewValue_Textbox);
                this.Controls.Add(UpdateProduct_Button);
            }
            else if(actionName == "Remove")
            {
                this.Size = new Size(245,200);
                this.Controls.Add(CategoryId_Combobox);
                this.Controls.Add(SelectColumn_Combobox);
                this.Controls.Add(SelectCondition_Combobox);
                this.Controls.Add(Select_Textbox);
                this.Controls.Add(RemoveProduct_Button);
            }
            else
            {
                this.Size = new Size(595,385);
                this.Controls.Add(CategoryId_Combobox);
                this.Controls.Add(SelectColumn_Combobox);
                this.Controls.Add(SelectCondition_Combobox);
                this.Controls.Add(Select_Textbox);
                this.Controls.Add(Product_Table);
                this.Controls.Add(SearchProduct_Button);
            }
        }

        private void SelectColumn_Combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = (string)SelectColumn_Combobox.SelectedValue;
            if (selectedValue == "01")
            {
                selectedColumn = "product_id";
            }
            else if (selectedValue == "02") 
            {
                selectedColumn = "product_name";
            }
            else
            {
                selectedColumn = "price";
            }
        }

        private void SearchProduct_Button_Click(object sender, EventArgs e)
        {
            try
            {
                string valueToSearch = Select_Textbox.Text;
                string categoryId = (string)CategoryId_Combobox.SelectedValue;
                string condition = SelectCondition_Combobox.Text;

                string query;

                if (categoryId == "00")
                {
                    query = $"SELECT * FROM Products WHERE {selectedColumn} {condition} '{valueToSearch}'";
                }
                else
                {
                    query = $"SELECT * FROM Products WHERE {selectedColumn} {condition} '{valueToSearch}' AND category_id = {categoryId}";
                }

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataReader reader = command.ExecuteReader();

                        Product_Table.Rows.Clear();

                        while (reader.Read())
                        {
                            Product_Table.Rows.Add(
                                reader["product_id"],
                                reader["product_name"],
                                reader["price"],
                                reader["category_id"],
                                reader["is_ordered"]
                            );
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateProduct_Button_Click(object sender, EventArgs e)
        {
            try
            {
                string valueToUpdate = Select_Textbox.Text;
                string categoryId = (string)CategoryId_Combobox.SelectedValue;
                string condition = SelectCondition_Combobox.Text;
                string newValue = NewValue_Textbox.Text;

                string query;

                if (categoryId == "00")
                {
                    query = $"UPDATE Products SET {selectedColumn} = '{newValue}' WHERE {selectedColumn} {condition} '{valueToUpdate}'";
                }
                else
                {
                    query = $"UPDATE Products SET {selectedColumn} = '{newValue}' WHERE {selectedColumn} {condition} '{valueToUpdate}' AND category_id = {categoryId}";
                }
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RemoveProduct_Button_Click(object sender, EventArgs e)
        {
            try
            {
                string valueToRemove = Select_Textbox.Text;
                string categoryId = (string)CategoryId_Combobox.SelectedValue;
                string condition = SelectCondition_Combobox.Text;

                string query;

                if (categoryId == "00")
                {
                    query = $"DELETE FROM Products WHERE {selectedColumn} {condition} '{valueToRemove}'";
                }
                else
                {
                    query = $"DELETE FROM Products WHERE {selectedColumn} {condition} '{valueToRemove}' AND category_id = {categoryId}";
                }

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Price_Textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Price_Textbox.Text.Contains("."))
            {
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }
            }
            else
            {
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != '.')
                {
                    e.Handled = true;
                }
            }
        }

        private void Categories_Combobox_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void AddProduct_Button_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ProductName_Textbox.Text)
                && !string.IsNullOrEmpty(Price_Textbox.Text)
                && CategoryId_Combobox.SelectedIndex > 0)
            {
                string name = ProductName_Textbox.Text;
                string price = Price_Textbox.Text;
                string categoryId = (string)CategoryId_Combobox.SelectedValue;
                byte[] productPhoto = null;
                
                string query;
                
                try
                {
                    if (ProductPhoto_Picturebox.Image == null)
                    {
                        query = "INSERT INTO Products (product_name, price, category_id) VALUES (@Value1, @Value2, @Value3)";

                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            connection.Open();
                            using (SqlCommand command = new SqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@Value1", name);
                                command.Parameters.AddWithValue("@Value2", price);
                                command.Parameters.AddWithValue("@Value3", categoryId);
                                command.ExecuteNonQuery();
                            }
                        }
                    }
                    else
                    {
                        query = "INSERT INTO Products (product_name, price, category_id, product_photo) VALUES (@Value1, @Value2, @Value3, @Value4)";
                        if (ProductPhoto_Picturebox.Image != null)
                        {
                            using (MemoryStream stream = new MemoryStream())
                            {
                                ProductPhoto_Picturebox.Image.Save(stream, ImageFormat.Jpeg);
                                productPhoto = stream.ToArray();
                            }
                        }

                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            connection.Open();
                            using (SqlCommand command = new SqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@Value1", name);
                                command.Parameters.AddWithValue("@Value2", price);
                                command.Parameters.AddWithValue("@Value3", categoryId);
                                command.Parameters.AddWithValue("@Value4", productPhoto);
                                command.ExecuteNonQuery();
                            }
                        }
                    }
                
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                ProductName_Textbox.Text = "";
                Price_Textbox.Text = "";
                ProductPhoto_Picturebox.Image = null;
            }
        }

        private void ClearPictureBox_Button_Click(object sender, EventArgs e)
        {
            ProductPhoto_Picturebox.Image = null;
        }

        private void SelectPhotoName_Button_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.gif)|*.jpg; *.jpeg; *.png; *.gif";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    ProductPhoto_Picturebox.Image = Image.FromFile(openFileDialog.FileName);
                }
            }
        }
    }
}
