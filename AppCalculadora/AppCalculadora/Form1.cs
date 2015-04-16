using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCalculadora
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
            
          


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            float numero1, numero2, suma, resta, dividir, multiplicar;
            numero1 = float.Parse(txtnum1.Text);
            numero2 = float.Parse(txtnun2.Text);
            suma = numero1 + numero2;
            resta = numero1 - numero2;
            //producto y divicion
            if (rbsuma.Checked == true)
            {
                txtresultado.Text = suma.ToString();
            }
            if (rbrestar.Checked == true)
            {
                txtresultado.Text = resta.ToString();
            }


            if (rbdividir.Checked == true)
            {
                txtresultado.Text = dividir.ToString();

            }


            if (rbmultiplicar.Checked == true)
            {
                txtresultado.Text = multiplicar.ToString();

            }
        }
    }
}
