namespace lab9
{
    partial class Main_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            this.ProductsTable = new System.Windows.Forms.DataGridView();
            this.product_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.is_ordered = new System.Windows.Forms.DataGridViewButtonColumn();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lab9DataSet = new lab9.lab9DataSet();
            this.Profile_Button = new System.Windows.Forms.Button();
            this.productsTableAdapter = new lab9.lab9DataSetTableAdapters.ProductsTableAdapter();
            this.Back_Button = new System.Windows.Forms.Button();
            this.AdminPanel_Button = new System.Windows.Forms.Button();
            this.Search_Button = new System.Windows.Forms.Button();
            this.Categories_Combobox = new System.Windows.Forms.ComboBox();
            this.SubCategories_Combobox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Refresh = new System.Windows.Forms.Button();
            this.SortingTable_Combobox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Price_Textbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ProductName_Textbox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lab9DataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductsTable
            // 
            this.ProductsTable.AutoGenerateColumns = false;
            this.ProductsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.product_name,
            this.product_id,
            this.price,
            this.is_ordered});
            this.ProductsTable.DataSource = this.productsBindingSource;
            this.ProductsTable.Location = new System.Drawing.Point(12, 78);
            this.ProductsTable.Name = "ProductsTable";
            this.ProductsTable.RowHeadersWidth = 51;
            this.ProductsTable.RowTemplate.Height = 24;
            this.ProductsTable.Size = new System.Drawing.Size(435, 150);
            this.ProductsTable.TabIndex = 0;
            this.ProductsTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductsTable_CellContentClick);
            this.ProductsTable.SelectionChanged += new System.EventHandler(this.ProductsTable_SelectionChanged);
            // 
            // product_name
            // 
            this.product_name.DataPropertyName = "product_name";
            this.product_name.HeaderText = "Name";
            this.product_name.MinimumWidth = 6;
            this.product_name.Name = "product_name";
            this.product_name.ReadOnly = true;
            this.product_name.Width = 125;
            // 
            // product_id
            // 
            this.product_id.DataPropertyName = "product_id";
            this.product_id.HeaderText = "product_id";
            this.product_id.MinimumWidth = 6;
            this.product_id.Name = "product_id";
            this.product_id.ReadOnly = true;
            this.product_id.Visible = false;
            this.product_id.Width = 125;
            // 
            // price
            // 
            this.price.DataPropertyName = "price";
            this.price.HeaderText = "Price";
            this.price.MinimumWidth = 6;
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.Width = 80;
            // 
            // is_ordered
            // 
            this.is_ordered.DataPropertyName = "is_ordered";
            this.is_ordered.HeaderText = "";
            this.is_ordered.MinimumWidth = 6;
            this.is_ordered.Name = "is_ordered";
            this.is_ordered.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.is_ordered.Text = "buy";
            this.is_ordered.UseColumnTextForButtonValue = true;
            this.is_ordered.Width = 50;
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
            // Profile_Button
            // 
            this.Profile_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Profile_Button.BackgroundImage")));
            this.Profile_Button.Location = new System.Drawing.Point(82, 12);
            this.Profile_Button.Name = "Profile_Button";
            this.Profile_Button.Size = new System.Drawing.Size(64, 60);
            this.Profile_Button.TabIndex = 1;
            this.Profile_Button.UseVisualStyleBackColor = true;
            this.Profile_Button.Click += new System.EventHandler(this.Profile_Button_Click);
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // Back_Button
            // 
            this.Back_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Back_Button.BackgroundImage")));
            this.Back_Button.Location = new System.Drawing.Point(12, 12);
            this.Back_Button.Name = "Back_Button";
            this.Back_Button.Size = new System.Drawing.Size(64, 60);
            this.Back_Button.TabIndex = 2;
            this.Back_Button.UseVisualStyleBackColor = true;
            this.Back_Button.Click += new System.EventHandler(this.Back_Button_Click);
            // 
            // AdminPanel_Button
            // 
            this.AdminPanel_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AdminPanel_Button.BackgroundImage")));
            this.AdminPanel_Button.Location = new System.Drawing.Point(152, 12);
            this.AdminPanel_Button.Name = "AdminPanel_Button";
            this.AdminPanel_Button.Size = new System.Drawing.Size(64, 60);
            this.AdminPanel_Button.TabIndex = 3;
            this.AdminPanel_Button.UseVisualStyleBackColor = true;
            this.AdminPanel_Button.Visible = false;
            this.AdminPanel_Button.Click += new System.EventHandler(this.AdminPanel_Button_Click);
            // 
            // Search_Button
            // 
            this.Search_Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Search_Button.BackgroundImage")));
            this.Search_Button.Location = new System.Drawing.Point(6, 64);
            this.Search_Button.Name = "Search_Button";
            this.Search_Button.Size = new System.Drawing.Size(64, 60);
            this.Search_Button.TabIndex = 5;
            this.Search_Button.UseVisualStyleBackColor = true;
            this.Search_Button.Click += new System.EventHandler(this.Search_Button_Click);
            // 
            // Categories_Combobox
            // 
            this.Categories_Combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Categories_Combobox.FormattingEnabled = true;
            this.Categories_Combobox.Location = new System.Drawing.Point(456, 36);
            this.Categories_Combobox.Name = "Categories_Combobox";
            this.Categories_Combobox.Size = new System.Drawing.Size(121, 24);
            this.Categories_Combobox.TabIndex = 6;
            this.Categories_Combobox.SelectionChangeCommitted += new System.EventHandler(this.Categories_Combobox_SelectionChangeCommitted);
            // 
            // SubCategories_Combobox
            // 
            this.SubCategories_Combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SubCategories_Combobox.FormattingEnabled = true;
            this.SubCategories_Combobox.Location = new System.Drawing.Point(583, 36);
            this.SubCategories_Combobox.Name = "SubCategories_Combobox";
            this.SubCategories_Combobox.Size = new System.Drawing.Size(121, 24);
            this.SubCategories_Combobox.TabIndex = 7;
            this.SubCategories_Combobox.SelectionChangeCommitted += new System.EventHandler(this.SubCategories_Combobox_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(453, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Categories:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(580, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "SubCategories:";
            // 
            // Refresh
            // 
            this.Refresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Refresh.BackgroundImage")));
            this.Refresh.Location = new System.Drawing.Point(383, 234);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(64, 60);
            this.Refresh.TabIndex = 10;
            this.Refresh.UseVisualStyleBackColor = true;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // SortingTable_Combobox
            // 
            this.SortingTable_Combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SortingTable_Combobox.FormattingEnabled = true;
            this.SortingTable_Combobox.Items.AddRange(new object[] {
            "Name(A-Z)",
            "Name(Z-A)",
            "Price(0-9)",
            "Price(9-0)"});
            this.SortingTable_Combobox.Location = new System.Drawing.Point(710, 36);
            this.SortingTable_Combobox.Name = "SortingTable_Combobox";
            this.SortingTable_Combobox.Size = new System.Drawing.Size(121, 24);
            this.SortingTable_Combobox.TabIndex = 11;
            this.SortingTable_Combobox.SelectedIndexChanged += new System.EventHandler(this.SortingTable_Combobox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(707, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Sort by";
            // 
            // Price_Textbox
            // 
            this.Price_Textbox.Location = new System.Drawing.Point(112, 36);
            this.Price_Textbox.Name = "Price_Textbox";
            this.Price_Textbox.Size = new System.Drawing.Size(100, 22);
            this.Price_Textbox.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(109, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Name";
            // 
            // ProductName_Textbox
            // 
            this.ProductName_Textbox.Location = new System.Drawing.Point(6, 36);
            this.ProductName_Textbox.Name = "ProductName_Textbox";
            this.ProductName_Textbox.Size = new System.Drawing.Size(100, 22);
            this.ProductName_Textbox.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ProductName_Textbox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Price_Textbox);
            this.groupBox1.Controls.Add(this.Search_Button);
            this.groupBox1.Location = new System.Drawing.Point(12, 234);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 172);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(453, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SortingTable_Combobox);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SubCategories_Combobox);
            this.Controls.Add(this.Categories_Combobox);
            this.Controls.Add(this.AdminPanel_Button);
            this.Controls.Add(this.Back_Button);
            this.Controls.Add(this.Profile_Button);
            this.Controls.Add(this.ProductsTable);
            this.Name = "Main_Form";
            this.Load += new System.EventHandler(this.Main_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductsTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lab9DataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ProductsTable;
        private System.Windows.Forms.Button Profile_Button;
        private lab9DataSet lab9DataSet;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private lab9DataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.Button Back_Button;
        private System.Windows.Forms.Button AdminPanel_Button;
        private System.Windows.Forms.Button Search_Button;
        private System.Windows.Forms.ComboBox Categories_Combobox;
        private System.Windows.Forms.ComboBox SubCategories_Combobox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.ComboBox SortingTable_Combobox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Price_Textbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ProductName_Textbox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewButtonColumn is_ordered;
    }
}