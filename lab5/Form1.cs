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

namespace lab5
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        private string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=5sem;Integrated Security=True";
        private string table = "worker";
        public Form1()
        {
            InitializeComponent();
            toolTip1.SetToolTip(add_button, "add data to the table");
            toolTip1.SetToolTip(delete_button, "delete data from the table");
            toolTip1.SetToolTip(refresh_button, "refresh table");
            toolTip1.SetToolTip(update_button, "update data in table");
            toolTip1.SetToolTip(search_button, "search data in table");
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            Add add = new Add(table);
            add.Show();
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            Delete delete = new Delete(table);
            delete.Show();
        }

        private void refresh_button_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM worker";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        worker_table.DataSource = dataTable;
                    }
                }

                query = "SELECT * FROM checks";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        checks_table.DataSource = dataTable;
                    }
                }

                query = "SELECT * FROM goods";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        goods_table.DataSource = dataTable;
                    }
                }

                query = "SELECT * FROM distributor";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        distributor_table.DataSource = dataTable;
                    }
                }
            }

        }

        private void search_button_Click(object sender, EventArgs e)
        {
            Search search = new Search(table);
            search.Show();
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            Update update = new Update(table);
            update.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_5semDataSet.distributor' table. You can move, or remove it, as needed.
            this.distributorTableAdapter.Fill(this._5semDataSet.distributor);
            // TODO: This line of code loads data into the '_5semDataSet.goods' table. You can move, or remove it, as needed.
            this.goodsTableAdapter.Fill(this._5semDataSet.goods);
            // TODO: This line of code loads data into the '_5semDataSet.checks' table. You can move, or remove it, as needed.
            this.checksTableAdapter.Fill(this._5semDataSet.checks);
            // TODO: This line of code loads data into the '_5semDataSet.worker' table. You can move, or remove it, as needed.
            this.workerTableAdapter.Fill(this._5semDataSet.worker);

        }

        private void radio_worker_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radio_worker.Checked)
            {
                table = "worker";
                worker_table.Visible = true;
                checks_table.Visible = false;
                goods_table.Visible = false;
                distributor_table.Visible = false;
            }
            else if (radio_checks.Checked)
            {
                table = "checks";
                worker_table.Visible = false;
                checks_table.Visible = true;
                goods_table.Visible = false;
                distributor_table.Visible = false;
            }
            else if (radio_goods.Checked)
            {
                table = "goods";
                worker_table.Visible = false;
                checks_table.Visible = false;
                goods_table.Visible = true;
                distributor_table.Visible = false;
            }
            else if (radio_distributor.Checked)
            {
                table = "distributor";
                worker_table.Visible = false;
                checks_table.Visible = false;
                goods_table.Visible = false;
                distributor_table.Visible = true;
            }
        }
    }
}