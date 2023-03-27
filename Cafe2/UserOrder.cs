﻿using System;
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
using System.Text.RegularExpressions;
using System.Security.AccessControl;

namespace Cafe2
{
    public partial class UserOrder : Form
    {
        public UserOrder()
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
            string query = "select * from ItemTbl where ItemCat = '"+ categorycb.SelectedItem.ToString() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ItemsGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        int num = 0;
        int price, total,quant;
        string item,cat;

        DataTable table = new DataTable();
        int flag = 0;
        int sum = 0;
        private void UserOrder_Load(object sender, EventArgs e)
        {
            populate();
            table.Columns.Add("Num", typeof(int));
            table.Columns.Add("Item", typeof(string));
            table.Columns.Add("Category", typeof(string));
            table.Columns.Add("UnitPrice", typeof(int));
            table.Columns.Add("Total", typeof(int));
            table.Columns.Add("Quantity", typeof(int));
            OrdersGv.DataSource = table;
            Datelbl.Text = DateTime.Today.Day.ToString() + "/" + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString() + "/";
            SellerNameTb.Text = Form1.user;
        }

        private void label5_Click(object sender, EventArgs e)
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
            else if(flag == 0)
            {
                MessageBox.Show("Select the product to be Ordered");
            }
            else
            {
                num = num + 1;
                total = price * Convert.ToInt32(QtyTb.Text);
                quant= Convert.ToInt32(QtyTb.Text);
                table.Rows.Add(num, item, cat, price,total,quant);
                OrdersGv.DataSource = table;
                flag = 1;
            }
            sum = sum + total;
            LabelAmnt.Text = "" + sum;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ItemForm Item = new ItemForm();
            Item.Show();
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            filterbycategory();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            populate();
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
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE ItemTbl SET QuantityGoods = QuantityGoods - @quant WHERE ItemName = @item", Con);
                cmd.Parameters.AddWithValue("@quant", quant);
                cmd.Parameters.AddWithValue("@item", item);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Quantity updated successfully!");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error updating quantity: " + ex.Message);
            }
            finally
            {
                Con.Close();
            }
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("SELECT QuantityGoods FROM ItemTbl WHERE ItemName = @item", Con);
                cmd.Parameters.AddWithValue("@item", item);
                int quantity = Convert.ToInt32(cmd.ExecuteScalar());
                LabelAmnt.Text = quantity.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error getting quantity: " + ex.Message);
            }
            finally
            {
                Con.Close();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
          ViewOrders view= new ViewOrders();
            view.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            table.Rows.Clear();
            sum = 0;
            LabelAmnt.Text = "" + sum;
        }

        private void LabelAmnt_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void OrdersGv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void QtyTb_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            UsersForm user = new UsersForm();
            user.Show();
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
    }
}
