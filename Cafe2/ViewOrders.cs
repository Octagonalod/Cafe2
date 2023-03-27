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
using System.Data.SqlClient;
namespace Cafe2
{
    public partial class ViewOrders : Form
    {
        public ViewOrders()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\f4nde\source\repos\Cafe2\Cafe2\Cafe.mdf;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        void populate()
        {
            Con.Open();
            string query = "select * from OrdersTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            OrdersGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void ViewOrders_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void OrdersGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("----------Cafe Yummyum----------", new Font("Century", 25, FontStyle.Bold), Brushes.Red, new Point(170,40));
            e.Graphics.DrawString("----------Order Summary----------",new Font("Century", 25, FontStyle.Bold), Brushes.Red, new Point(170,90));
            e.Graphics.DrawString("Number:" + OrdersGV.SelectedRows[0].Cells[0].Value.ToString(), new Font("Century", 16, FontStyle.Bold), Brushes.Black, new Point(170, 130));
            e.Graphics.DrawString("Date:" + OrdersGV.SelectedRows[0].Cells[1].Value.ToString(), new Font("Century", 16, FontStyle.Bold), Brushes.Black, new Point(170, 170));
            e.Graphics.DrawString("Seller:" + OrdersGV.SelectedRows[0].Cells[2].Value.ToString(), new Font("Century", 16, FontStyle.Bold), Brushes.Black, new Point(170, 210));
            e.Graphics.DrawString("Order Amount:" + OrdersGV.SelectedRows[0].Cells[3].Value.ToString(), new Font("Century", 16, FontStyle.Bold), Brushes.Black, new Point(170, 250));
        }
    }
    }

