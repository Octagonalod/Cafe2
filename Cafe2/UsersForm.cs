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

namespace Cafe2
{
    public partial class UsersForm : Form
    {
        public UsersForm()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\f4nde\source\repos\Cafe2\Cafe2\Cafe.mdf;Integrated Security=True");
        void populate()
        {
            Con.Open();
            string query = "select * from UsersTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            UsersGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            UserOrder uorder= new UserOrder();
            uorder.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ItemForm item = new ItemForm();
            item.Show();
            this.Hide();
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
            if (!string.IsNullOrEmpty(unameTb.Text) && !string.IsNullOrEmpty(UphoneTb.Text) && !string.IsNullOrEmpty(UpassTb.Text))
            {
                Con.Open();
                string query = "insert into UsersTbl values('" + unameTb.Text + "', '" + UphoneTb.Text + "', '" + UpassTb.Text + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User Successfuly Created");
                Con.Close();
                populate();
            }
            else
            {
                MessageBox.Show("Fill all the data");
            }
        }

        private void UsersForm_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void UsersGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (UsersGV.SelectedRows.Count > 0)
            {
                unameTb.Text = UsersGV.SelectedRows[0].Cells[0].Value.ToString();
                UphoneTb.Text = UsersGV.SelectedRows[0].Cells[1].Value.ToString();
                UpassTb.Text = UsersGV.SelectedRows[0].Cells[2].Value.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (UphoneTb.Text == "")
            {
                MessageBox.Show("Select user to be deleted");
            }
            else
            {
                Con.Open();
                string query = "delete from UsersTbl where UserPhone = '" + UphoneTb.Text + "'";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User deleted");
                Con.Close() ;
                populate();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(UphoneTb.Text == "" || UpassTb.Text == "" || unameTb.Text == "")
            {
                MessageBox.Show("Fill all the fields");
            }
            else
            {
                Con.Open();
                string query = "update UsersTbl set UserName='" + unameTb.Text + "',UserPassword='" + UpassTb.Text +"' where UserPhone='"+ UphoneTb.Text +"'";   
                SqlCommand cmd= new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User Updated");
                Con.Close();
                populate();
            }
        }
    }
}
