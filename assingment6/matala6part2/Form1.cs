using System.Data;
using System.Xml.Linq;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace matala6part2
{
    public partial class Form1 : Form
    {
        Store store;
        public Form1()
        {
            InitializeComponent();
            store = new Store();
        }
        private void Form1_Load_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = store.ItemsTable();
        }
        private void btnFilter_Click_1(object sender, EventArgs e)
        {
            int price = int.Parse(txtFilter.Text);
            dataGridView1.DataSource = store.FilterByAbovePrice(price);
        }

        private void btnCancelFilter_Click_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = store.ItemsTable();
            txtFilter.Clear();
        }

        private void btnInsert_Click_1(object sender, EventArgs e)
        {
            Item newItem = new Item(txtName.Text, txtDesc.Text, int.Parse(txtPrice.Text));
            DataTable updatedTable = store.InsertItem(newItem);

            if (updatedTable != null)
            {
                dataGridView1.DataSource = updatedTable;
                MessageBox.Show("Item added to memory!");
            }
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            int code = int.Parse(txtCode.Text);
            DataTable updatedTable = store.DeleteItem(code);

            if (updatedTable != null)
            {
                dataGridView1.DataSource = updatedTable;
                MessageBox.Show("Item deleted from memory!");
            }
            else
            {
                MessageBox.Show("Code not found!");
            }
        }
        private void btnUpdateDB_Click_1(object sender, EventArgs e)
        {
            DataTable currentTable = (DataTable)dataGridView1.DataSource;
            store.Update(currentTable);
            MessageBox.Show("Database updated successfully!");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtCode.Text = row.Cells["Code"].Value.ToString();
            }
        }
    }
}
