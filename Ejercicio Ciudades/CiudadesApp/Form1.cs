using CiudadesLibrary1.Dao;
using CiudadesLibrary1.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CiudadesApp
{
    public partial class Form1 : Form
    {
        CiudadDao lista = new CiudadDao();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Ciudad ciudad = new Ciudad();
            ciudad.Nombre = tbNombre.Text;
            ciudad.poblacion = int.Parse(tbPoblacion.Text);
            ciudad.FechaFundacion = dtpFundacion.Value;

            lista.AgregarCiudad(ciudad);
            llenarDataGrid();
        }

        private void llenarDataGrid()
        {
            dgvRegistros.DataSource = lista.MostrarCiudad();
            dgvRegistros.Refresh();
        }
    }
}
