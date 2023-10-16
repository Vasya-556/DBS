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
    public partial class Search : Form
    {
        private string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=5sem;Integrated Security=True";
        private string table;
        public Search(string table)
        {
            InitializeComponent();
            this.table = table;
            this.Size = new System.Drawing.Size(340,200);
            if (table == "worker")
            {
                radioButton7.Text = "id_w";
                radioButton8.Text = "Initial";
                radioButton9.Text = "position";
                radioButton10.Text = "fk_goods";
                radioButton11.Text = "fk_checks";

                radioButton12.Visible = false;
            }
            else if (table == "checks")
            {
                radioButton7.Text = "id_c";
                radioButton8.Text = "fSum";
                radioButton9.Text = "fDate";
                radioButton10.Text = "fk_goods";
                radioButton11.Text = "fk_worker";

                radioButton12.Visible = false;
            }
            else if (table == "goods")
            {
                radioButton7.Text = "id_g";
                radioButton8.Text = "fName";
                radioButton9.Text = "fCount";
                radioButton10.Text = "Price";
                radioButton11.Text = "fk_checks";
                radioButton12.Text = "fk_distributor";

            }
            else if (table == "distributor")
            {
                radioButton7.Text = "id_d";
                radioButton8.Text = "fName";
                radioButton9.Text = "phone";
                radioButton10.Text = "fk_goods";

                radioButton11.Visible = false;
                radioButton12.Visible = false;
            }
        }

        private void Search_button_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string condition;
                if (radioButton1.Checked)
                {
                    condition = ">";
                }
                else if (radioButton2.Checked)
                {
                    condition = "<";
                }
                else if (radioButton3.Checked)
                {
                    condition = "!=";
                }
                else if (radioButton4.Checked)
                {
                    condition = "<=";
                }
                else if (radioButton5.Checked)
                {
                    condition = ">=";
                }
                else
                {
                    condition = "=";
                }

                string column;
                if (table == "worker")
                {
                    if (radioButton7.Checked)
                    {
                        column = "id_w";
                    }
                    else if (radioButton8.Checked)
                    {
                        column = "Initial";
                    }
                    else if (radioButton9.Checked)
                    {
                        column = "position";
                    }
                    else if (radioButton10.Checked)
                    {
                        column = "fk_goods";
                    }
                    else
                    {
                        column = "fk_checks";
                    }
                }
                else if (table == "checks")
                {
                    if (radioButton7.Checked)
                    {
                        column = "id_c";
                    }
                    else if (radioButton8.Checked)
                    {
                        column = "fSum";
                    }
                    else if (radioButton9.Checked)
                    {
                        column = "fdate";
                    }
                    else if (radioButton10.Checked)
                    {
                        column = "fk_goods";
                    }
                    else
                    {
                        column = "fk_worker";
                    }
                }
                else if (table == "goods")
                {
                    if (radioButton7.Checked)
                    {
                        column = "id_g";
                    }
                    else if (radioButton8.Checked)
                    {
                        column = "fName";
                    }
                    else if (radioButton9.Checked)
                    {
                        column = "fCount";
                    }
                    else if (radioButton10.Checked)
                    {
                        column = "Price";
                    }
                    else if (radioButton11.Checked)
                    {
                        column = "fk_checks";
                    }
                    else
                    {
                        column = "fk_distributor";
                    }
                }
                else
                {
                    if (radioButton7.Checked)
                    {
                        column = "id_d";
                    }
                    else if (radioButton8.Checked)
                    {
                        column = "fName";
                    }
                    else if (radioButton9.Checked)
                    {
                        column = "phone";
                    }
                    else
                    {
                        column = "fk_goods";
                    }
                }

                string valueToSearch = textBox1.Text;

                string query = $"SELECT * FROM {table} WHERE {column} {condition} @ValueToSearch";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ValueToSearch", valueToSearch);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        _table.DataSource = dataTable;
                    }
                }
                _table.Visible = true;
                if (table == "worker")
                {
                    _table.Size = new Size(570, 200);
                    this.Size = new System.Drawing.Size(610, 400);
                }
                else if (table == "checks")
                {
                    _table.Size = new Size(570, 200);
                    this.Size = new System.Drawing.Size(610, 400);
                }
                else if (table == "goods")
                {
                    _table.Size = new Size(700, 200);
                    this.Size = new System.Drawing.Size(740, 400);
                }
                else if (table == "distributor")
                {
                    _table.Size = new Size(470, 200);
                    this.Size = new System.Drawing.Size(510, 400);
                }
            }
        }
    }
}
