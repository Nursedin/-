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
    public partial class ቁሶች : Form
    {
        public ቁሶች()
        {
            InitializeComponent();
        }

        private void ቁሶች_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            loadData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
             SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-32UGJES\SQLEXPRESS;Initial Catalog=Stock;Integrated Security=True");
            //insert Logic
            con.Open();
            bool status = false;
            if (comboBox1.SelectedIndex == 0)
            {
                status = true;
            }
            else
            {
                status = false;
            }
           var sqlQuery="";
           if(IfProductsExists(con,textBox1.Text))

           {
               sqlQuery=@"UPDATE [dbo].[Products] SET [ProductName] = '" + textBox2.Text + "',[ProductSturus] ='" + status + "'WHERE [ProductID] = '" + textBox1.Text + "'";
           }
           else
           {
               sqlQuery=@"INSERT INTO [dbo].[Products]([ProductID],[ProductName],[ProductSturus]) VALUES
                                     ('" + textBox1.Text + "','" + textBox2.Text + "','" + status + "')";
           }


            SqlCommand cmd = new SqlCommand(sqlQuery, con);
            cmd.ExecuteNonQuery();
            con.Close();

            // To read
            loadData();

        }

        private bool IfProductsExists(SqlConnection con,string ProductID)
        
        {
            SqlDataAdapter sda = new SqlDataAdapter("select 1 from [Products] WHERE [ProductID]='" + ProductID + "' ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if(dt.Rows.Count > 0)
                return true;
            else
                return false;
        }
        public void loadData()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-32UGJES\SQLEXPRESS;Initial Catalog=Stock;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("select * from [dbo].[Products]", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = item["ProductID"].ToString();
                dataGridView1.Rows[n].Cells[1].Value = item["ProductName"].ToString();
                if ((bool)item["ProductSturus"])
                {
                    dataGridView1.Rows[n].Cells[2].Value = "ንቁ";
                }
                else
                {
                    dataGridView1.Rows[n].Cells[2].Value = "አግልግሎት የማይስጥ";
                }

            }
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            if (dataGridView1.SelectedRows[0].Cells[2].Value.ToString() == "ንቁ")
            {
                comboBox1.SelectedIndex = 0;
            }
            else
            {
                comboBox1.SelectedIndex = 1; 
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-32UGJES\SQLEXPRESS;Initial Catalog=Stock;Integrated Security=True");
            var sqlQuery = "";
            if (IfProductsExists(con, textBox1.Text))
            {
                con.Open();
                sqlQuery = @"DELETE from [dbo].[Products] WHERE [ProductID] = '" + textBox1.Text + "'";
                SqlCommand cmd = new SqlCommand(sqlQuery, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            else
            {
                MessageBox.Show("የተመዘገበ ዳታ የለም.......!");
            }
            // To read
            loadData();
        }
    }
}
