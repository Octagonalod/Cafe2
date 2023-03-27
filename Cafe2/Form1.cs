using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Data.SqlClient;


namespace Cafe2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\f4nde\source\repos\Cafe2\Cafe2\Cafe.mdf;Integrated Security=True");
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            GuestOrder guest= new GuestOrder();
            guest.Show();
        }
        public static string user;
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            user = UnameTb.Text;
            if (UnameTb.Text == "" || PasswordTb.Text == "")
            {
                MessageBox.Show("Enter username or/and password");
            }
            else
            {
                Con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select count(*) from UsersTbl where UserName = '"+UnameTb.Text+"' and UserPassword = '"+PasswordTb.Text+"'", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString()== "1")
                {
                    UserOrder userOrder= new UserOrder();
                    userOrder.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong User name or Password");
                }    
                Con.Close(); 
            }
        }
    }
}
