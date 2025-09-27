using Monto.Dao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblMonto_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double precio = double.Parse(tbPrecio.Text);
            lblMonto.Text = "Precio: " + precio + " Monto: " + Calculo.CalcularMonto(precio);
        }

        private void btnCalcularRef_Click(object sender, EventArgs e)
        {
            double precio = double.Parse(tbPrecio.Text);
            lblMonto.Text = " Monto: " + Calculo.CalcularMonto(ref precio) + " Precio: " + precio;
        }
    }
}
