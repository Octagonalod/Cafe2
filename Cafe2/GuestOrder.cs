using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BunifuAnimatorNS;

namespace Cafe2
{
    public partial class GuestOrder : Form
    {
        public GuestOrder()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\f4nde\source\repos\Cafe2\Cafe2\Cafe.mdf;Integrated Security=True");
        void populate()
        {
            Con.Open();
            string query = "select * from ItemTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ItemsGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        void filterbycategory()
        {
            Con.Open();
            string query = "select * from ItemTbl where ItemCat = '" + categorycb.SelectedItem.ToString() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ItemsGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        int num = 0;
        int price, total;
        string item, cat;

        DataTable table = new DataTable();
        int flag = 0;
        int sum = 0;

        private void label5_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 login = new Form1();
            login.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (QtyTb.Text == "")
            {
                MessageBox.Show("What is the number og item");
            }
            else if (flag == 0)
            {
                MessageBox.Show("Select the product to be Ordered");
            }
            else
            {
                num = num + 1;
                total = price * Convert.ToInt32(QtyTb.Text);
                table.Rows.Add(num, item, cat, price, total);
                OrdersGv.DataSource = table;
                flag = 1;
            }
            sum = sum + total;
            LabelAmnt.Text = "" + sum;
        }

        private void ItemsGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ItemsGV.SelectedRows.Count > 0)
            {
                item = ItemsGV.SelectedRows[0].Cells[1].Value.ToString();
                cat = ItemsGV.SelectedRows[0].Cells[2].Value.ToString();
                price = Convert.ToInt32(ItemsGV.SelectedRows[0].Cells[3].Value.ToString());
                flag = 1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string query = "insert into OrdersTbl values(" + OrderNumTb.Text + ", '" + Datelbl.Text + "', '" + SellerNameTb.Text + "'," + LabelAmnt.Text + ")";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Order Successfuly Created");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Plese Enter a OrderNum ");
            }
            finally
            {
                Con.Close();
            }


        }

        private void button7_Click(object sender, EventArgs e)
        {
            table.Rows.Clear();
            sum = 0;
            LabelAmnt.Text = "" + sum;
        }

        private void GuestOrder_Load(object sender, EventArgs e)
        {
            populate();
            table.Columns.Add("Num", typeof(int));
            table.Columns.Add("Item", typeof(string));
            table.Columns.Add("Category", typeof(string));
            table.Columns.Add("UnitPrice", typeof(int));
            table.Columns.Add("Total", typeof(int));
            OrdersGv.DataSource = table;
            Datelbl.Text = DateTime.Today.Day.ToString()+"/"+ DateTime.Today.Month.ToString() + "/"+ DateTime.Today.Year.ToString() + "/";
        }

        private void categorycb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            filterbycategory();
        }
    }
}
