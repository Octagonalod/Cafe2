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
    public partial class ItemForm : Form
    {
        public ItemForm()
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
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserOrder order = new UserOrder();
            order.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            UsersForm user = new UsersForm();
            user.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 login = new Form1();
            login.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(ItemNameTb.Text == "" || ItemNumTb.Text == "" || PriceCb.Text == "" )
            {
                MessageBox.Show("Fill all the data");
            }
            else
            {
                Con.Open();
                string query = "insert into ItemTbl values('" + ItemNumTb.Text + "', '" + ItemNameTb.Text + "', '" + CatCb.SelectedItem.ToString() + "','" + PriceCb.Text + "',"+QOFCb.Text+")";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Item Successfuly Created");
                Con.Close();
                populate();
            }
        }

        private void ItemForm_Load(object sender, EventArgs e)
        {
                populate();
        }

        private void ItemsGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                if (ItemsGV.SelectedRows.Count > 0)
                {
                    ItemNumTb.Text = ItemsGV.SelectedRows[0].Cells[0].Value.ToString();
                    ItemNameTb.Text = ItemsGV.SelectedRows[0].Cells[1].Value.ToString();
                    CatCb.SelectedItem = ItemsGV.SelectedRows[0].Cells[2].Value.ToString();
                    PriceCb.Text = ItemsGV.SelectedRows[0].Cells[3].Value.ToString();
                    QOFCb.Text = ItemsGV.SelectedRows[0].Cells[4].Value.ToString();
            }
      
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ItemNumTb.Text == "")
            {
                MessageBox.Show("Select item to be deleted");
            }
            else
            {
                Con.Open();
                string query = "delete from ItemTbl where ItemNum = '" + ItemNumTb.Text + "'";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Item deleted");
                Con.Close();
                populate();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (ItemNumTb.Text == "" || ItemNameTb.Text == "" || PriceCb.Text == "")
            {
                MessageBox.Show("Fill all the fields");
            }
            else
            {
                Con.Open();
                string query = "UPDATE ItemTbl SET ItemName = '" + ItemNameTb.Text + "', ItemCat = '" + CatCb.SelectedItem.ToString() + "', ItemPrice = '" + PriceCb.Text + "', QuantityGoods = '"+QOFCb.Text+"' WHERE ItemNum = '" + ItemNumTb.Text + "'";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Item Updated");
                Con.Close();
                populate();
            }
        }
    }
  
}
