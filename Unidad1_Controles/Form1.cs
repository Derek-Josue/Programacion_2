using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unidad1_Controles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("formulario cargado correctamente");
        }

        private void btnBoton1_Click(object sender, EventArgs e)
        {
            saludar();
        }

        private void saludar() {
            string nombre = txtNombre.Text;
            MessageBox.Show("Hola " + nombre + ", bienvenido a la programación en C#");      
        }

    }
}
