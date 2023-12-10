namespace lab10
{
    public partial class Form1 : Form
    {
        private ApplicationContext db;
        public Form1()
        {
            InitializeComponent();
            db = new ApplicationContext();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DisplayData();
        }
        private void DisplayData()
        {
            var allTickets = db.TicketPrices.ToList();

            dataGridView1.DataSource = allTickets;

            dataGridView1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Select the type of ticket.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string selectedTypeString = comboBox1.SelectedItem.ToString();

            if (!Enum.TryParse(selectedTypeString, out TicketType selectedType))
            {
                MessageBox.Show("Select the correct ticket type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int price;

            if (!int.TryParse(textBox1.Text, out price))
            {
                MessageBox.Show("Enter the correct price.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            TicketPrice newTicketPrice = new TicketPrice
            {
                Price = price,
                Type = selectedType
            };

            db.TicketPrices.Add(newTicketPrice);
            db.SaveChanges();

            DisplayData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox2.Text, out int priceToDelete))
            {
                MessageBox.Show("Enter the correct price to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var ticketsToDelete = db.TicketPrices.Where(t => t.Price == priceToDelete).ToList();
            foreach (var ticket in ticketsToDelete)
            {
                db.TicketPrices.Remove(ticket);
            }

            db.SaveChanges();

            DisplayData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox2.Text, out int searchPrice))
            {
                MessageBox.Show("Enter the correct price for the search.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var foundTickets = db.TicketPrices.Where(t => t.Price == searchPrice).ToList();

            dataGridView1.DataSource = foundTickets;
            dataGridView1.Refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox3.Text, out int oldPrice))
            {
                MessageBox.Show("Enter the correct old price to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(textBox4.Text, out int newPrice))
            {
                MessageBox.Show("Enter the correct new price to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var ticketsToUpdate = db.TicketPrices.Where(t => t.Price == oldPrice).ToList();

            foreach (var ticket in ticketsToUpdate)
            {
                ticket.Price = newPrice;
            }
            db.SaveChanges();

            DisplayData();
        }
    }
}