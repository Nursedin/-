using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace የክምችት
{
    public partial class ዋና_ክምችት : Form
    {
     

        public ዋና_ክምችት()
        {
            InitializeComponent();
        }

        private void ቁሶችToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ቁሶች pro = new ቁሶች();
            pro.MdiParent = this;
            pro.Show();
        }

        private void ዋና_ክምችት_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ዋና_ክምችት_Load(object sender, EventArgs e)
        {

        }

      
    }
}
