using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace precioiva
{
    public partial class Form1 : Form
    {
        Calculoprecio calculoprecio = new Calculoprecio();
        public Form1()
        {
            InitializeComponent();
        }

        private void Btncalcular_Click(object sender, EventArgs e)
        {
            calculoprecio.setPrecio(double.Parse(txtprecio.Text));

            lbliva.Text = calculoprecio.calcularIva().ToString();
            lbliva.Visible = true;
            lbldescuento.Text = calculoprecio.calcularDescuento().ToString();
            lbldescuento.Visible = true;
            lbltotal.Text = calculoprecio.calcularPrecio().ToString();
            lbltotal.Visible = true;
        }
    }
}
