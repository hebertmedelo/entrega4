using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppChetBox
{
    public partial class btnselecionar : Form
    {
        public btnselecionar()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnselecionar_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (chkopcion1.Checked == true)
            {
                MessageBox.Show("amarillo");
               
            }
          
            if (chkopcion2.Checked == true)
            {
                MessageBox.Show("azul");
            }
          
            if (chkopcion3.Checked == true)
            {
                MessageBox.Show("rojo");
            }
            
        }

        private void chkopcion1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
