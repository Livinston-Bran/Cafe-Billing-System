using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_Billing
{
    public partial class Products : Form
    {
        DataTable PrdTB = new DataTable("PrdTB");
        int index;
        public Products()
        {
            InitializeComponent();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            dashboard dash = new dashboard();
            this.Hide();
            dash.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Products products = new Products();
            this.Hide();
            products.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            ComboCategory.ResetText();
            TxtBoxItemName.ResetText();
            txtBoxPrice.ResetText();
        }
      
        private void guna2Button12_Click(object sender, EventArgs e)
        {
            DataGridViewRow newdata = dgv_product.Rows[index];
            newdata.Cells[0].Value = ComboCategory.Text;
            newdata.Cells[1].Value = TxtBoxItemName.Text;
            newdata.Cells[2].Value = txtBoxPrice.Text;
        }

        private void Products_Load(object sender, EventArgs e)
        {
            PrdTB.Columns.Add("Category", Type.GetType("System.String"));
            PrdTB.Columns.Add("Item Name", Type.GetType("System.String"));
            PrdTB.Columns.Add("Unit Price", Type.GetType("System.Int32"));
      
            dgv_product.DataSource = PrdTB;
        }

        private void guna2Button11_Click(object sender, EventArgs e)
        {
            PrdTB.Rows.Add(ComboCategory.Text, TxtBoxItemName.Text, txtBoxPrice.Text);
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            index = dgv_product.CurrentCell.RowIndex;
            dgv_product.Rows.RemoveAt(index);
        }

       

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }
    }
}
