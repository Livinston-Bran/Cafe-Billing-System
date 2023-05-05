using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Cafe_Billing
{
    public partial class dashboard : Form
    {
        DataTable BillTB = new DataTable("BillTB");
        int index;
        public dashboard()
        {
            InitializeComponent();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            dashboard dash = new dashboard();
            this.Hide();
            dash.Show();
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            Products products = new Products();
            this.Hide();
            products.Show();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            ItemBox.ResetText();
            PriceBox.ResetText();
            QuantityBox.ResetText();
            TotalBox.ResetText();
        }

        
        private void guna2Button4_Click(object sender, EventArgs e)
        {
           

            BillTB.Rows.Add(ItemBox.Text, PriceBox.Text, QuantityBox.Text);

            double sum = 0;

            for (int row = 0; row < dgvAdmin_Bill.Rows.Count; row++)
            {
                sum = sum + Convert.ToInt32(dgvAdmin_Bill.Rows[row].Cells[2].Value);
            }
            TotalBox.Text = sum.ToString();


        }

        private void dashboard_Load(object sender, EventArgs e)
        {
            BillTB.Columns.Add("Item", Type.GetType("System.String"));
            BillTB.Columns.Add("Unit Price", Type.GetType("System.Int32"));
            BillTB.Columns.Add("Quantity", Type.GetType("System.Int32"));
            BillTB.Columns.Add("Total", Type.GetType("System.Int32"));

            dgvAdmin_Bill.DataSource = BillTB;
        }

        decimal amount;
        private void guna2Button5_Click(object sender, EventArgs e)
        {
                index = dgvAdmin_Bill.CurrentCell.RowIndex;
                dgvAdmin_Bill.Rows.RemoveAt(index);      
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Rest Cafe Management System ", new Font("Ubuntu", 23, FontStyle.Bold), Brushes.SandyBrown, new Point(190, 10));

            e.Graphics.DrawString("Invoice ", new Font("Ubuntu", 21, FontStyle.Bold), Brushes.Black, new Point(350, 60));

            e.Graphics.DrawString("Date: " + DateTime.Now.ToShortDateString(), new Font("Ubuntu", 16, FontStyle.Regular), Brushes.Black, new Point(350, 100));

            e.Graphics.DrawString("_________________________________________________________________________", new Font("Ubuntu", 20, FontStyle.Regular), Brushes.Black, new Point(0, 120));

            Bitmap objbmp = new Bitmap(this.dgvAdmin_Bill.Width, this.dgvAdmin_Bill.Height);
            dgvAdmin_Bill.DrawToBitmap(objbmp, new Rectangle(0, 0, this.dgvAdmin_Bill.Width, this.dgvAdmin_Bill.Height));
            e.Graphics.DrawImage(objbmp, 100, 200);

            e.Graphics.DrawString("_________________________________________________________________________", new Font("Ubuntu", 20, FontStyle.Regular), Brushes.Black, new Point(0, 600));

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }
    }
}
