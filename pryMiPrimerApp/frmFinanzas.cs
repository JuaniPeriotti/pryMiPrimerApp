using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryMiPrimerApp
{
    public partial class frmFinanzas : Form
    {
        //zona declaración de variables globales al formualrio

        decimal varDeposito;
        decimal varAlquiler;
        decimal varImpuestos;
        decimal varComida;
        decimal varVarios;
        decimal varTotal;

        public frmFinanzas()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            varDeposito = 0;
            varAlquiler = 0;
            varImpuestos = 0;
            varComida = 0;
            varVarios = 0;
            varTotal = 0;
        }

        private void cmdGrabar_Click(object sender, EventArgs e)
        {
            varDeposito = Convert.ToDecimal(txtDeposito.Text);
            varAlquiler = Convert.ToDecimal(txtAlquiler.Text);
            varImpuestos = Convert.ToDecimal(txtimpuestos.Text);
            varComida = Convert.ToDecimal(txtComida.Text);
            varVarios = Convert.ToDecimal(txtVarios.Text);
            varTotal = Convert.ToDecimal(txtVarios.Text);

            varTotal = varDeposito - (varAlquiler + varImpuestos + varComida);

            lblTotal.Text = varTotal.ToString();
        }
    }
}
