using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace promedio_de_notas
{
    public partial class FrmNotas : Form
    {
        public FrmNotas()
        {
            InitializeComponent();
        }
        public void Limpia()
        {
            txtNombre.Clear();
            txtNota1.Clear();
            txtNota2.Clear();
            txtNota3.Clear();
            txtNota4.Clear();
            txtCondicion.Clear();
            txtNotaBaja.Clear();
            txtPromedio.Clear();
        }
        public void Salida()
        {
            DialogResult result = MessageBox.Show("¿Estás seguro de que deseas salir?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                Application.Exit();
            }
            else
            {

            }
        }
        public void calcularTodo()
        {
            double nt1, nt2, nt3, nt4, notaMini;
            nt1 = double.Parse(txtNota1.Text);
            nt2 = double.Parse(txtNota2.Text);
            nt3 = double.Parse(txtNota3.Text);
            nt4 = double.Parse(txtNota4.Text);

            notaMini = Math.Min(Math.Min(nt1, nt2), Math.Min(nt3, nt4));

            txtNotaBaja.Text = notaMini.ToString();

            double suma, prom;

            suma = nt1 + nt2 + nt3 + nt4 - notaMini;
            prom = suma / 3;

            txtPromedio.Text = prom.ToString("N2");
            string mensaje;
            if (prom > 90)
            {
                mensaje = "EXCELENTE";
                txtCondicion.Text = mensaje;
            }
            else if (prom <= 90 && prom > 80)
            {
                mensaje = "MUY BUENO";
                txtCondicion.Text = mensaje;
            }
            else if (prom <= 80 && prom > 70)
            {
                mensaje = "BUENO";
                txtCondicion.Text = mensaje;
            }
            else if (prom <= 70 && prom >= 60)
            {
                mensaje = "REGULAR";

                txtCondicion.Text = mensaje;
            }
            else if (prom < 60)
            {
                mensaje = "REPROBADO";
                txtCondicion.Text = mensaje;
            }

        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpia();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            calcularTodo();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Salida();
        }

        private void txtNota1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; 
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; 
            }
        }
    }
}
