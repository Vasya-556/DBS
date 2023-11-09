namespace lab9
{
    partial class Admin_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Form));
            this.ProductsTable = new System.Windows.Forms.DataGridView();
            this.product_id_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isorderedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Send = new System.Windows.Forms.DataGridViewButtonColumn();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lab9DataSet = new lab9.lab9DataSet();
            this.productsTableAdapter = new lab9.lab9DataSetTableAdapters.ProductsTableAdapter();
            this.Table_Combobox = new System.Windows.Forms.ComboBox();
            this.Back_Button = new System.Windows.Forms.Button();
            this.AddData_Button = new System.Windows.Forms.Button();
            this.RemoveData_Button = new System.Windows.Forms.Button();
            this.UpdateData_Button = new System.Windows.Forms.Button();
            this.SearchData_Button = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NotOrderedProducts_radiobutton = new System.Windows.Forms.RadioButton();
            this.OrderedProducts_Radiobutton = new System.Windows.Forms.RadioButton();
            this.AllProducts_radiobutton = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.UsersTable = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.is_admin = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CategoriesTable = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.OrdersTable = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.order_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriesTableAdapter = new lab9.lab9DataSetTableAdapters.CategoriesTableAdapter();
            this.ordersTableAdapter = new lab9.lab9DataSetTableAdapters.OrdersTableAdapter();
            this.usersTableAdapter = new lab9.lab9DataSetTableAdapters.UsersTableAdapter();
            this.SendAllOrderedProducts_Button = new System.Windows.Forms.Button();
            this.RefreshData_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lab9DataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsersTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoriesTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductsTable
            // 
            this.ProductsTable.AutoGenerateColumns = false;
            this.ProductsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.product_id_,
            this.productnameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.categoryidDataGridViewTextBoxColumn,
            this.isorderedDataGridViewCheckBoxColumn,
            this.Send});
            this.ProductsTable.DataSource = this.productsBindingSource;
            this.ProductsTable.Location = new System.Drawing.Point(12, 78);
            this.ProductsTable.Name = "ProductsTable";
            this.ProductsTable.RowHeadersWidth = 51;
            this.ProductsTable.RowTemplate.Height = 24;
            this.ProductsTable.Size = new System.Drawing.Size(787, 150);
            this.ProductsTable.TabIndex = 1;
            this.ProductsTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductsTable_CellContentClick);
            this.ProductsTable.SelectionChanged += new System.EventHandler(this.ProductsTable_SelectionChanged);
            // 
            // product_id_
            // 
            this.product_id_.DataPropertyName = "product_id";
            this.product_id_.HeaderText = "Id";
            this.product_id_.MinimumWidth = 6;
            this.product_id_.Name = "product_id_";
            this.product_id_.ReadOnly = true;
            this.product_id_.Width = 80;
            // 
            // productnameDataGridViewTextBoxColumn
            // 
            this.productnameDataGridViewTextBoxColumn.DataPropertyName = "product_name";
            this.productnameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.productnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productnameDataGridViewTextBoxColumn.Name = "productnameDataGridViewTextBoxColumn";
            this.productnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.productnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceDataGridViewTextBoxColumn.Width = 80;
            // 
            // categoryidDataGridViewTextBoxColumn
            // 
            this.categoryidDataGridViewTextBoxColumn.DataPropertyName = "category_id";
            this.categoryidDataGridViewTextBoxColumn.HeaderText = "Category id";
            this.categoryidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.categoryidDataGridViewTextBoxColumn.Name = "categoryidDataGridViewTextBoxColumn";
            this.categoryidDataGridViewTextBoxColumn.ReadOnly = true;
            this.categoryidDataGridViewTextBoxColumn.Width = 90;
            // 
            // isorderedDataGridViewCheckBoxColumn
            // 
            this.isorderedDataGridViewCheckBoxColumn.DataPropertyName = "is_ordered";
            this.isorderedDataGridViewCheckBoxColumn.HeaderText = "is ordered";
            this.isorderedDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.isorderedDataGridViewCheckBoxColumn.Name = "isorderedDataGridViewCheckBoxColumn";
            this.isorderedDataGridViewCheckBoxColumn.ReadOnly = true;
            this.isorderedDataGridViewCheckBoxColumn.Width = 80;
            // 
            // Send
            // 
            this.Send.HeaderText = "";
            this.Send.MinimumWidth = 6;
            this.Send.Name = "Send";
            this.Send.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Send.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Send.Text = "send";
            this.Send.UseColumnTextForButtonValue = true;
            this.Send.Width = 50;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.lab9DataSet;
            // 
            // lab9DataSet
            // 
            this.lab9DataSet.DataSetName = "lab9DataSet";
            this.lab9DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // Table_Combobox
            // 
            this.Table_Combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Table_Combobox.FormattingEnabled = true;
            this.Table_Combobox.Location = new System.Drawing.Point(556, 12);
            this.Table_Combobox.Name = "Table_Combobox";
            this.Table_Combobox.Size = new System.Drawing.Size(121, 24);
            this.Table_Combobox.TabIndex = 2;
            this.Table_Combobox.SelectedIndexChanged += new System.EventHandler(this.Table_Combobox_SelectedIndexChanged);
            // 
            // Back_Button
            // 
            this.Back_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Back_Button.BackgroundImage")));
            this.Back_Button.Location = new System.Drawing.Point(12, 12);
            this.Back_Button.Name = "Back_Button";
            this.Back_Button.Size = new System.Drawing.Size(64, 60);
            this.Back_Button.TabIndex = 3;
            this.Back_Button.UseVisualStyleBackColor = true;
            this.Back_Button.Click += new System.EventHandler(this.Back_Button_Click);
            // 
            // AddData_Button
            // 
            this.AddData_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddData_Button.BackgroundImage")));
            this.AddData_Button.Location = new System.Drawing.Point(152, 12);
            this.AddData_Button.Name = "AddData_Button";
            this.AddData_Button.Size = new System.Drawing.Size(64, 60);
            this.AddData_Button.TabIndex = 4;
            this.AddData_Button.UseVisualStyleBackColor = true;
            this.AddData_Button.Click += new System.EventHandler(this.AddData_Button_Click);
            // 
            // RemoveData_Button
            // 
            this.RemoveData_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RemoveData_Button.BackgroundImage")));
            this.RemoveData_Button.Location = new System.Drawing.Point(222, 12);
            this.RemoveData_Button.Name = "RemoveData_Button";
            this.RemoveData_Button.Size = new System.Drawing.Size(64, 60);
            this.RemoveData_Button.TabIndex = 5;
            this.RemoveData_Button.UseVisualStyleBackColor = true;
            this.RemoveData_Button.Click += new System.EventHandler(this.RemoveData_Button_Click);
            // 
            // UpdateData_Button
            // 
            this.UpdateData_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("UpdateData_Button.BackgroundImage")));
            this.UpdateData_Button.Location = new System.Drawing.Point(362, 12);
            this.UpdateData_Button.Name = "UpdateData_Button";
            this.UpdateData_Button.Size = new System.Drawing.Size(64, 60);
            this.UpdateData_Button.TabIndex = 6;
            this.UpdateData_Button.UseVisualStyleBackColor = true;
            this.UpdateData_Button.Click += new System.EventHandler(this.UpdateData_Button_Click);
            // 
            // SearchData_Button
            // 
            this.SearchData_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SearchData_Button.BackgroundImage")));
            this.SearchData_Button.Location = new System.Drawing.Point(292, 12);
            this.SearchData_Button.Name = "SearchData_Button";
            this.SearchData_Button.Size = new System.Drawing.Size(64, 60);
            this.SearchData_Button.TabIndex = 7;
            this.SearchData_Button.UseVisualStyleBackColor = true;
            this.SearchData_Button.Click += new System.EventHandler(this.SearchData_Button_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NotOrderedProducts_radiobutton);
            this.groupBox1.Controls.Add(this.OrderedProducts_Radiobutton);
            this.groupBox1.Controls.Add(this.AllProducts_radiobutton);
            this.groupBox1.Location = new System.Drawing.Point(12, 234);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Show ";
            // 
            // NotOrderedProducts_radiobutton
            // 
            this.NotOrderedProducts_radiobutton.AutoSize = true;
            this.NotOrderedProducts_radiobutton.Location = new System.Drawing.Point(6, 73);
            this.NotOrderedProducts_radiobutton.Name = "NotOrderedProducts_radiobutton";
            this.NotOrderedProducts_radiobutton.Size = new System.Drawing.Size(155, 20);
            this.NotOrderedProducts_radiobutton.TabIndex = 2;
            this.NotOrderedProducts_radiobutton.Text = "Not ordered products";
            this.NotOrderedProducts_radiobutton.UseVisualStyleBackColor = true;
            this.NotOrderedProducts_radiobutton.CheckedChanged += new System.EventHandler(this.NotOrderedProducts_radiobutton_CheckedChanged);
            // 
            // OrderedProducts_Radiobutton
            // 
            this.OrderedProducts_Radiobutton.AutoSize = true;
            this.OrderedProducts_Radiobutton.Location = new System.Drawing.Point(6, 47);
            this.OrderedProducts_Radiobutton.Name = "OrderedProducts_Radiobutton";
            this.OrderedProducts_Radiobutton.Size = new System.Drawing.Size(133, 20);
            this.OrderedProducts_Radiobutton.TabIndex = 1;
            this.OrderedProducts_Radiobutton.Text = "Ordered products";
            this.OrderedProducts_Radiobutton.UseVisualStyleBackColor = true;
            this.OrderedProducts_Radiobutton.CheckedChanged += new System.EventHandler(this.OrderedProducts_Radiobutton_CheckedChanged);
            // 
            // AllProducts_radiobutton
            // 
            this.AllProducts_radiobutton.AutoSize = true;
            this.AllProducts_radiobutton.Checked = true;
            this.AllProducts_radiobutton.Location = new System.Drawing.Point(6, 21);
            this.AllProducts_radiobutton.Name = "AllProducts_radiobutton";
            this.AllProducts_radiobutton.Size = new System.Drawing.Size(98, 20);
            this.AllProducts_radiobutton.TabIndex = 0;
            this.AllProducts_radiobutton.TabStop = true;
            this.AllProducts_radiobutton.Text = "All products";
            this.AllProducts_radiobutton.UseVisualStyleBackColor = true;
            this.AllProducts_radiobutton.CheckedChanged += new System.EventHandler(this.AllProducts_radiobutton_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(805, 77);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // UsersTable
            // 
            this.UsersTable.AutoGenerateColumns = false;
            this.UsersTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsersTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.usernameDataGridViewTextBoxColumn,
            this.is_admin,
            this.Column2});
            this.UsersTable.DataSource = this.usersBindingSource;
            this.UsersTable.Location = new System.Drawing.Point(12, 78);
            this.UsersTable.Name = "UsersTable";
            this.UsersTable.RowHeadersWidth = 51;
            this.UsersTable.RowTemplate.Height = 24;
            this.UsersTable.Size = new System.Drawing.Size(787, 150);
            this.UsersTable.TabIndex = 32;
            this.UsersTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UsersTable_CellContentClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "id";
            this.Id.HeaderText = "id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 80;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "username";
            this.usernameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.ReadOnly = true;
            this.usernameDataGridViewTextBoxColumn.Width = 125;
            // 
            // is_admin
            // 
            this.is_admin.DataPropertyName = "is_admin";
            this.is_admin.HeaderText = "is admin";
            this.is_admin.MinimumWidth = 6;
            this.is_admin.Name = "is_admin";
            this.is_admin.ReadOnly = true;
            this.is_admin.Width = 80;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column2.Text = "Change User Rights";
            this.Column2.UseColumnTextForButtonValue = true;
            this.Column2.Width = 120;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.lab9DataSet;
            // 
            // CategoriesTable
            // 
            this.CategoriesTable.AutoGenerateColumns = false;
            this.CategoriesTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CategoriesTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.category_name});
            this.CategoriesTable.DataSource = this.categoriesBindingSource;
            this.CategoriesTable.Location = new System.Drawing.Point(12, 78);
            this.CategoriesTable.Name = "CategoriesTable";
            this.CategoriesTable.RowHeadersWidth = 51;
            this.CategoriesTable.RowTemplate.Height = 24;
            this.CategoriesTable.Size = new System.Drawing.Size(787, 150);
            this.CategoriesTable.TabIndex = 30;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "category_id";
            this.dataGridViewTextBoxColumn4.HeaderText = "Id";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 90;
            // 
            // category_name
            // 
            this.category_name.DataPropertyName = "category_name";
            this.category_name.HeaderText = "Name";
            this.category_name.MinimumWidth = 6;
            this.category_name.Name = "category_name";
            this.category_name.ReadOnly = true;
            this.category_name.Width = 125;
            // 
            // categoriesBindingSource
            // 
            this.categoriesBindingSource.DataMember = "Categories";
            this.categoriesBindingSource.DataSource = this.lab9DataSet;
            // 
            // OrdersTable
            // 
            this.OrdersTable.AutoGenerateColumns = false;
            this.OrdersTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrdersTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.user_id,
            this.order_date,
            this.product_id});
            this.OrdersTable.DataSource = this.ordersBindingSource;
            this.OrdersTable.Location = new System.Drawing.Point(12, 78);
            this.OrdersTable.Name = "OrdersTable";
            this.OrdersTable.RowHeadersWidth = 51;
            this.OrdersTable.RowTemplate.Height = 24;
            this.OrdersTable.Size = new System.Drawing.Size(787, 150);
            this.OrdersTable.TabIndex = 31;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "product_id";
            this.dataGridViewTextBoxColumn5.HeaderText = "Id";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 80;
            // 
            // user_id
            // 
            this.user_id.DataPropertyName = "user_id";
            this.user_id.HeaderText = "user id";
            this.user_id.MinimumWidth = 6;
            this.user_id.Name = "user_id";
            this.user_id.ReadOnly = true;
            this.user_id.Width = 125;
            // 
            // order_date
            // 
            this.order_date.DataPropertyName = "order_date";
            this.order_date.HeaderText = "order date";
            this.order_date.MinimumWidth = 6;
            this.order_date.Name = "order_date";
            this.order_date.ReadOnly = true;
            this.order_date.Width = 125;
            // 
            // product_id
            // 
            this.product_id.DataPropertyName = "product_id";
            this.product_id.HeaderText = "product id";
            this.product_id.MinimumWidth = 6;
            this.product_id.Name = "product_id";
            this.product_id.ReadOnly = true;
            this.product_id.Width = 125;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.lab9DataSet;
            // 
            // categoriesTableAdapter
            // 
            this.categoriesTableAdapter.ClearBeforeFill = true;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // SendAllOrderedProducts_Button
            // 
            this.SendAllOrderedProducts_Button.Location = new System.Drawing.Point(432, 12);
            this.SendAllOrderedProducts_Button.Name = "SendAllOrderedProducts_Button";
            this.SendAllOrderedProducts_Button.Size = new System.Drawing.Size(118, 42);
            this.SendAllOrderedProducts_Button.TabIndex = 28;
            this.SendAllOrderedProducts_Button.Text = "Send all ordered products";
            this.SendAllOrderedProducts_Button.UseVisualStyleBackColor = true;
            this.SendAllOrderedProducts_Button.Click += new System.EventHandler(this.SendAllOrderedProducts_Button_Click);
            // 
            // RefreshData_Button
            // 
            this.RefreshData_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RefreshData_Button.BackgroundImage")));
            this.RefreshData_Button.Location = new System.Drawing.Point(82, 12);
            this.RefreshData_Button.Name = "RefreshData_Button";
            this.RefreshData_Button.Size = new System.Drawing.Size(64, 60);
            this.RefreshData_Button.TabIndex = 33;
            this.RefreshData_Button.UseVisualStyleBackColor = true;
            this.RefreshData_Button.Click += new System.EventHandler(this.RefreshData_Button_Click);
            // 
            // Admin_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 352);
            this.Controls.Add(this.RefreshData_Button);
            this.Controls.Add(this.SendAllOrderedProducts_Button);
            this.Controls.Add(this.UsersTable);
            this.Controls.Add(this.OrdersTable);
            this.Controls.Add(this.SearchData_Button);
            this.Controls.Add(this.UpdateData_Button);
            this.Controls.Add(this.AddData_Button);
            this.Controls.Add(this.CategoriesTable);
            this.Controls.Add(this.RemoveData_Button);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Back_Button);
            this.Controls.Add(this.Table_Combobox);
            this.Controls.Add(this.ProductsTable);
            this.Name = "Admin_Form";
            this.Text = "Admin_Form";
            this.Load += new System.EventHandler(this.Admin_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductsTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lab9DataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsersTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoriesTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ProductsTable;
        private lab9DataSet lab9DataSet;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private lab9DataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.ComboBox Table_Combobox;
        private System.Windows.Forms.Button Back_Button;
        private System.Windows.Forms.Button AddData_Button;
        private System.Windows.Forms.Button RemoveData_Button;
        private System.Windows.Forms.Button UpdateData_Button;
        private System.Windows.Forms.Button SearchData_Button;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton NotOrderedProducts_radiobutton;
        private System.Windows.Forms.RadioButton OrderedProducts_Radiobutton;
        private System.Windows.Forms.RadioButton AllProducts_radiobutton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView CategoriesTable;
        private System.Windows.Forms.DataGridView UsersTable;
        private System.Windows.Forms.DataGridView OrdersTable;
        private System.Windows.Forms.BindingSource categoriesBindingSource;
        private lab9DataSetTableAdapters.CategoriesTableAdapter categoriesTableAdapter;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private lab9DataSetTableAdapters.OrdersTableAdapter ordersTableAdapter;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private lab9DataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn category_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn order_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn is_admin;
        private System.Windows.Forms.DataGridViewButtonColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_id_;
        private System.Windows.Forms.DataGridViewTextBoxColumn productnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isorderedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Send;
        private System.Windows.Forms.Button SendAllOrderedProducts_Button;
        private System.Windows.Forms.Button RefreshData_Button;
    }
}