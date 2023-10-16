namespace lab5
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.worker_table = new System.Windows.Forms.DataGridView();
            this.idwDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.initialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fkgoodsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fkchecksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._5semDataSet = new lab5._5semDataSet();
            this.distributor_table = new System.Windows.Forms.DataGridView();
            this.iddDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fkgoodsDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.distributorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.checks_table = new System.Windows.Forms.DataGridView();
            this.idcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fSumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fkgoodsDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fkworkerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.add_button = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            this.refresh_button = new System.Windows.Forms.Button();
            this.search_button = new System.Windows.Forms.Button();
            this.update_button = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radio_goods = new System.Windows.Forms.RadioButton();
            this.radio_distributor = new System.Windows.Forms.RadioButton();
            this.radio_checks = new System.Windows.Forms.RadioButton();
            this.radio_worker = new System.Windows.Forms.RadioButton();
            this.goods_table = new System.Windows.Forms.DataGridView();
            this.idgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fkchecksDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fkdistributorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workerTableAdapter = new lab5._5semDataSetTableAdapters.workerTableAdapter();
            this.checksTableAdapter = new lab5._5semDataSetTableAdapters.checksTableAdapter();
            this.goodsTableAdapter = new lab5._5semDataSetTableAdapters.goodsTableAdapter();
            this.distributorTableAdapter = new lab5._5semDataSetTableAdapters.distributorTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.worker_table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._5semDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.distributor_table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.distributorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checks_table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checksBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.goods_table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // worker_table
            // 
            this.worker_table.AutoGenerateColumns = false;
            this.worker_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.worker_table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idwDataGridViewTextBoxColumn,
            this.initialDataGridViewTextBoxColumn,
            this.positionDataGridViewTextBoxColumn,
            this.fkgoodsDataGridViewTextBoxColumn,
            this.fkchecksDataGridViewTextBoxColumn});
            this.worker_table.DataSource = this.workerBindingSource;
            this.worker_table.Location = new System.Drawing.Point(12, 78);
            this.worker_table.Name = "worker_table";
            this.worker_table.RowHeadersWidth = 51;
            this.worker_table.Size = new System.Drawing.Size(928, 325);
            this.worker_table.TabIndex = 0;
            // 
            // idwDataGridViewTextBoxColumn
            // 
            this.idwDataGridViewTextBoxColumn.DataPropertyName = "id_w";
            this.idwDataGridViewTextBoxColumn.HeaderText = "id_w";
            this.idwDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idwDataGridViewTextBoxColumn.Name = "idwDataGridViewTextBoxColumn";
            this.idwDataGridViewTextBoxColumn.ReadOnly = true;
            this.idwDataGridViewTextBoxColumn.Width = 125;
            // 
            // initialDataGridViewTextBoxColumn
            // 
            this.initialDataGridViewTextBoxColumn.DataPropertyName = "Initial";
            this.initialDataGridViewTextBoxColumn.HeaderText = "Initial";
            this.initialDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.initialDataGridViewTextBoxColumn.Name = "initialDataGridViewTextBoxColumn";
            this.initialDataGridViewTextBoxColumn.Width = 125;
            // 
            // positionDataGridViewTextBoxColumn
            // 
            this.positionDataGridViewTextBoxColumn.DataPropertyName = "position";
            this.positionDataGridViewTextBoxColumn.HeaderText = "position";
            this.positionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.positionDataGridViewTextBoxColumn.Name = "positionDataGridViewTextBoxColumn";
            this.positionDataGridViewTextBoxColumn.Width = 125;
            // 
            // fkgoodsDataGridViewTextBoxColumn
            // 
            this.fkgoodsDataGridViewTextBoxColumn.DataPropertyName = "fk_goods";
            this.fkgoodsDataGridViewTextBoxColumn.HeaderText = "fk_goods";
            this.fkgoodsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fkgoodsDataGridViewTextBoxColumn.Name = "fkgoodsDataGridViewTextBoxColumn";
            this.fkgoodsDataGridViewTextBoxColumn.Width = 125;
            // 
            // fkchecksDataGridViewTextBoxColumn
            // 
            this.fkchecksDataGridViewTextBoxColumn.DataPropertyName = "fk_checks";
            this.fkchecksDataGridViewTextBoxColumn.HeaderText = "fk_checks";
            this.fkchecksDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fkchecksDataGridViewTextBoxColumn.Name = "fkchecksDataGridViewTextBoxColumn";
            this.fkchecksDataGridViewTextBoxColumn.Width = 125;
            // 
            // workerBindingSource
            // 
            this.workerBindingSource.DataMember = "worker";
            this.workerBindingSource.DataSource = this._5semDataSet;
            // 
            // _5semDataSet
            // 
            this._5semDataSet.DataSetName = "_5semDataSet";
            this._5semDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // distributor_table
            // 
            this.distributor_table.AutoGenerateColumns = false;
            this.distributor_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.distributor_table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iddDataGridViewTextBoxColumn,
            this.fNameDataGridViewTextBoxColumn1,
            this.phoneDataGridViewTextBoxColumn,
            this.fkgoodsDataGridViewTextBoxColumn2});
            this.distributor_table.DataSource = this.distributorBindingSource;
            this.distributor_table.Location = new System.Drawing.Point(12, 78);
            this.distributor_table.Name = "distributor_table";
            this.distributor_table.RowHeadersWidth = 51;
            this.distributor_table.Size = new System.Drawing.Size(760, 325);
            this.distributor_table.TabIndex = 1;
            this.distributor_table.Visible = false;
            // 
            // iddDataGridViewTextBoxColumn
            // 
            this.iddDataGridViewTextBoxColumn.DataPropertyName = "id_d";
            this.iddDataGridViewTextBoxColumn.HeaderText = "id_d";
            this.iddDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iddDataGridViewTextBoxColumn.Name = "iddDataGridViewTextBoxColumn";
            this.iddDataGridViewTextBoxColumn.ReadOnly = true;
            this.iddDataGridViewTextBoxColumn.Width = 125;
            // 
            // fNameDataGridViewTextBoxColumn1
            // 
            this.fNameDataGridViewTextBoxColumn1.DataPropertyName = "fName";
            this.fNameDataGridViewTextBoxColumn1.HeaderText = "fName";
            this.fNameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.fNameDataGridViewTextBoxColumn1.Name = "fNameDataGridViewTextBoxColumn1";
            this.fNameDataGridViewTextBoxColumn1.Width = 125;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "phone";
            this.phoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.Width = 125;
            // 
            // fkgoodsDataGridViewTextBoxColumn2
            // 
            this.fkgoodsDataGridViewTextBoxColumn2.DataPropertyName = "fk_goods";
            this.fkgoodsDataGridViewTextBoxColumn2.HeaderText = "fk_goods";
            this.fkgoodsDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.fkgoodsDataGridViewTextBoxColumn2.Name = "fkgoodsDataGridViewTextBoxColumn2";
            this.fkgoodsDataGridViewTextBoxColumn2.Width = 125;
            // 
            // distributorBindingSource
            // 
            this.distributorBindingSource.DataMember = "distributor";
            this.distributorBindingSource.DataSource = this._5semDataSet;
            // 
            // checks_table
            // 
            this.checks_table.AutoGenerateColumns = false;
            this.checks_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.checks_table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idcDataGridViewTextBoxColumn,
            this.fSumDataGridViewTextBoxColumn,
            this.fdateDataGridViewTextBoxColumn,
            this.fkgoodsDataGridViewTextBoxColumn1,
            this.fkworkerDataGridViewTextBoxColumn});
            this.checks_table.DataSource = this.checksBindingSource;
            this.checks_table.Location = new System.Drawing.Point(12, 78);
            this.checks_table.Name = "checks_table";
            this.checks_table.RowHeadersWidth = 51;
            this.checks_table.Size = new System.Drawing.Size(928, 325);
            this.checks_table.TabIndex = 2;
            this.checks_table.Visible = false;
            // 
            // idcDataGridViewTextBoxColumn
            // 
            this.idcDataGridViewTextBoxColumn.DataPropertyName = "id_c";
            this.idcDataGridViewTextBoxColumn.HeaderText = "id_c";
            this.idcDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idcDataGridViewTextBoxColumn.Name = "idcDataGridViewTextBoxColumn";
            this.idcDataGridViewTextBoxColumn.ReadOnly = true;
            this.idcDataGridViewTextBoxColumn.Width = 125;
            // 
            // fSumDataGridViewTextBoxColumn
            // 
            this.fSumDataGridViewTextBoxColumn.DataPropertyName = "fSum";
            this.fSumDataGridViewTextBoxColumn.HeaderText = "fSum";
            this.fSumDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fSumDataGridViewTextBoxColumn.Name = "fSumDataGridViewTextBoxColumn";
            this.fSumDataGridViewTextBoxColumn.Width = 125;
            // 
            // fdateDataGridViewTextBoxColumn
            // 
            this.fdateDataGridViewTextBoxColumn.DataPropertyName = "fdate";
            this.fdateDataGridViewTextBoxColumn.HeaderText = "fdate";
            this.fdateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fdateDataGridViewTextBoxColumn.Name = "fdateDataGridViewTextBoxColumn";
            this.fdateDataGridViewTextBoxColumn.Width = 125;
            // 
            // fkgoodsDataGridViewTextBoxColumn1
            // 
            this.fkgoodsDataGridViewTextBoxColumn1.DataPropertyName = "fk_goods";
            this.fkgoodsDataGridViewTextBoxColumn1.HeaderText = "fk_goods";
            this.fkgoodsDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.fkgoodsDataGridViewTextBoxColumn1.Name = "fkgoodsDataGridViewTextBoxColumn1";
            this.fkgoodsDataGridViewTextBoxColumn1.Width = 125;
            // 
            // fkworkerDataGridViewTextBoxColumn
            // 
            this.fkworkerDataGridViewTextBoxColumn.DataPropertyName = "fk_worker";
            this.fkworkerDataGridViewTextBoxColumn.HeaderText = "fk_worker";
            this.fkworkerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fkworkerDataGridViewTextBoxColumn.Name = "fkworkerDataGridViewTextBoxColumn";
            this.fkworkerDataGridViewTextBoxColumn.Width = 125;
            // 
            // checksBindingSource
            // 
            this.checksBindingSource.DataMember = "checks";
            this.checksBindingSource.DataSource = this._5semDataSet;
            // 
            // add_button
            // 
            this.add_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("add_button.BackgroundImage")));
            this.add_button.Location = new System.Drawing.Point(12, 12);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(64, 60);
            this.add_button.TabIndex = 3;
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // delete_button
            // 
            this.delete_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("delete_button.BackgroundImage")));
            this.delete_button.Location = new System.Drawing.Point(82, 12);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(64, 60);
            this.delete_button.TabIndex = 4;
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // refresh_button
            // 
            this.refresh_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("refresh_button.BackgroundImage")));
            this.refresh_button.Location = new System.Drawing.Point(152, 12);
            this.refresh_button.Name = "refresh_button";
            this.refresh_button.Size = new System.Drawing.Size(64, 60);
            this.refresh_button.TabIndex = 5;
            this.refresh_button.UseVisualStyleBackColor = true;
            this.refresh_button.Click += new System.EventHandler(this.refresh_button_Click);
            // 
            // search_button
            // 
            this.search_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("search_button.BackgroundImage")));
            this.search_button.Location = new System.Drawing.Point(292, 12);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(64, 60);
            this.search_button.TabIndex = 6;
            this.search_button.UseVisualStyleBackColor = true;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // update_button
            // 
            this.update_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("update_button.BackgroundImage")));
            this.update_button.Location = new System.Drawing.Point(222, 12);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(64, 60);
            this.update_button.TabIndex = 7;
            this.update_button.UseVisualStyleBackColor = true;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radio_goods);
            this.groupBox1.Controls.Add(this.radio_distributor);
            this.groupBox1.Controls.Add(this.radio_checks);
            this.groupBox1.Controls.Add(this.radio_worker);
            this.groupBox1.Location = new System.Drawing.Point(362, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 60);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "select a table";
            // 
            // radio_goods
            // 
            this.radio_goods.AutoSize = true;
            this.radio_goods.Location = new System.Drawing.Point(257, 20);
            this.radio_goods.Name = "radio_goods";
            this.radio_goods.Size = new System.Drawing.Size(69, 20);
            this.radio_goods.TabIndex = 3;
            this.radio_goods.Text = "Goods";
            this.radio_goods.UseVisualStyleBackColor = true;
            this.radio_goods.CheckedChanged += new System.EventHandler(this.radio_worker_CheckedChanged_1);
            // 
            // radio_distributor
            // 
            this.radio_distributor.AutoSize = true;
            this.radio_distributor.Location = new System.Drawing.Point(163, 21);
            this.radio_distributor.Name = "radio_distributor";
            this.radio_distributor.Size = new System.Drawing.Size(88, 20);
            this.radio_distributor.TabIndex = 2;
            this.radio_distributor.Text = "Distributor";
            this.radio_distributor.UseVisualStyleBackColor = true;
            this.radio_distributor.CheckedChanged += new System.EventHandler(this.radio_worker_CheckedChanged_1);
            // 
            // radio_checks
            // 
            this.radio_checks.AutoSize = true;
            this.radio_checks.Location = new System.Drawing.Point(84, 21);
            this.radio_checks.Name = "radio_checks";
            this.radio_checks.Size = new System.Drawing.Size(73, 20);
            this.radio_checks.TabIndex = 1;
            this.radio_checks.Text = "Checks";
            this.radio_checks.UseVisualStyleBackColor = true;
            this.radio_checks.CheckedChanged += new System.EventHandler(this.radio_worker_CheckedChanged_1);
            // 
            // radio_worker
            // 
            this.radio_worker.AutoSize = true;
            this.radio_worker.Checked = true;
            this.radio_worker.Location = new System.Drawing.Point(6, 21);
            this.radio_worker.Name = "radio_worker";
            this.radio_worker.Size = new System.Drawing.Size(72, 20);
            this.radio_worker.TabIndex = 0;
            this.radio_worker.TabStop = true;
            this.radio_worker.Text = "Worker";
            this.radio_worker.UseVisualStyleBackColor = true;
            this.radio_worker.CheckedChanged += new System.EventHandler(this.radio_worker_CheckedChanged_1);
            // 
            // goods_table
            // 
            this.goods_table.AutoGenerateColumns = false;
            this.goods_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.goods_table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idgDataGridViewTextBoxColumn,
            this.fNameDataGridViewTextBoxColumn,
            this.fCountDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.fkchecksDataGridViewTextBoxColumn1,
            this.fkdistributorDataGridViewTextBoxColumn});
            this.goods_table.DataSource = this.goodsBindingSource;
            this.goods_table.Location = new System.Drawing.Point(12, 78);
            this.goods_table.Name = "goods_table";
            this.goods_table.RowHeadersWidth = 51;
            this.goods_table.Size = new System.Drawing.Size(1095, 325);
            this.goods_table.TabIndex = 9;
            this.goods_table.Visible = false;
            // 
            // idgDataGridViewTextBoxColumn
            // 
            this.idgDataGridViewTextBoxColumn.DataPropertyName = "id_g";
            this.idgDataGridViewTextBoxColumn.HeaderText = "id_g";
            this.idgDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idgDataGridViewTextBoxColumn.Name = "idgDataGridViewTextBoxColumn";
            this.idgDataGridViewTextBoxColumn.ReadOnly = true;
            this.idgDataGridViewTextBoxColumn.Width = 125;
            // 
            // fNameDataGridViewTextBoxColumn
            // 
            this.fNameDataGridViewTextBoxColumn.DataPropertyName = "fName";
            this.fNameDataGridViewTextBoxColumn.HeaderText = "fName";
            this.fNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fNameDataGridViewTextBoxColumn.Name = "fNameDataGridViewTextBoxColumn";
            this.fNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // fCountDataGridViewTextBoxColumn
            // 
            this.fCountDataGridViewTextBoxColumn.DataPropertyName = "fCount";
            this.fCountDataGridViewTextBoxColumn.HeaderText = "fCount";
            this.fCountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fCountDataGridViewTextBoxColumn.Name = "fCountDataGridViewTextBoxColumn";
            this.fCountDataGridViewTextBoxColumn.Width = 125;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.Width = 125;
            // 
            // fkchecksDataGridViewTextBoxColumn1
            // 
            this.fkchecksDataGridViewTextBoxColumn1.DataPropertyName = "fk_checks";
            this.fkchecksDataGridViewTextBoxColumn1.HeaderText = "fk_checks";
            this.fkchecksDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.fkchecksDataGridViewTextBoxColumn1.Name = "fkchecksDataGridViewTextBoxColumn1";
            this.fkchecksDataGridViewTextBoxColumn1.Width = 125;
            // 
            // fkdistributorDataGridViewTextBoxColumn
            // 
            this.fkdistributorDataGridViewTextBoxColumn.DataPropertyName = "fk_distributor";
            this.fkdistributorDataGridViewTextBoxColumn.HeaderText = "fk_distributor";
            this.fkdistributorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fkdistributorDataGridViewTextBoxColumn.Name = "fkdistributorDataGridViewTextBoxColumn";
            this.fkdistributorDataGridViewTextBoxColumn.Width = 125;
            // 
            // goodsBindingSource
            // 
            this.goodsBindingSource.DataMember = "goods";
            this.goodsBindingSource.DataSource = this._5semDataSet;
            // 
            // workerTableAdapter
            // 
            this.workerTableAdapter.ClearBeforeFill = true;
            // 
            // checksTableAdapter
            // 
            this.checksTableAdapter.ClearBeforeFill = true;
            // 
            // goodsTableAdapter
            // 
            this.goodsTableAdapter.ClearBeforeFill = true;
            // 
            // distributorTableAdapter
            // 
            this.distributorTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 450);
            this.Controls.Add(this.goods_table);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.update_button);
            this.Controls.Add(this.search_button);
            this.Controls.Add(this.refresh_button);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.checks_table);
            this.Controls.Add(this.distributor_table);
            this.Controls.Add(this.worker_table);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.worker_table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._5semDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.distributor_table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.distributorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checks_table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checksBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.goods_table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView worker_table;
        private System.Windows.Forms.DataGridView distributor_table;
        private System.Windows.Forms.DataGridView checks_table;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button refresh_button;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radio_distributor;
        private System.Windows.Forms.RadioButton radio_checks;
        private System.Windows.Forms.RadioButton radio_worker;
        private System.Windows.Forms.RadioButton radio_goods;
        private System.Windows.Forms.DataGridView goods_table;
        private _5semDataSet _5semDataSet;
        private System.Windows.Forms.BindingSource workerBindingSource;
        private _5semDataSetTableAdapters.workerTableAdapter workerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idwDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn initialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fkgoodsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fkchecksDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource checksBindingSource;
        private _5semDataSetTableAdapters.checksTableAdapter checksTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fSumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fkgoodsDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fkworkerDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource goodsBindingSource;
        private _5semDataSetTableAdapters.goodsTableAdapter goodsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fkchecksDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fkdistributorDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource distributorBindingSource;
        private _5semDataSetTableAdapters.distributorTableAdapter distributorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iddDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fkgoodsDataGridViewTextBoxColumn2;
    }
}

