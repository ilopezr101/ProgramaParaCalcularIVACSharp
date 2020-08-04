using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcularIVA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lbliva_Click(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double subtotal = double.Parse(txtingresovalor.Text);

            double calcular = 0;

            double iva = subtotal * 0.19;
            double total = iva + subtotal;

            lbliva.Text = Convert.ToString(String.Format("{0:n0}", iva));
            lblvalorfinal.Text = Convert.ToString(String.Format("{0:n0}", total));





        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtingresovalor_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtingresovalor.Text = String.Empty;
            lbliva.Text = String.Empty;
            lblvalorfinal.Text = String.Empty;
            txtingresovalor.Focus();
        }
    }
}
