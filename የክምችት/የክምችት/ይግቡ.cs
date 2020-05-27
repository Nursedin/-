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

namespace የክምችት
{
    public partial class ይግቡ : Form
    {
        public ይግቡ()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Clear();
            textBox1.Focus();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //To_do: Check login user name & Password
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-32UGJES\SQLEXPRESS;Initial Catalog=Stock;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter(@"SELECT *
              FROM [dbo].[Login] where UserName='"+ textBox1.Text +"' and Password='"+ textBox2.Text +"'",con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if(dt.Rows.Count==1)
                {
                    this.Hide();
                    ዋና_ክምችት Main = new ዋና_ክምችት();
                    Main.Show();
                }
            else
            {
                MessageBox.Show("የተሳሳተ መለያ ስምና የይለፍ ቃል ነው….!", "ስህተት", MessageBoxButtons.OK, MessageBoxIcon.Error);
                label1_Click(sender, e);
            }
        }
    }
}
