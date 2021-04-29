using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Abstracción
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FacturaA factA = new FacturaA("Factura A para Octavio", 500,"20-33333333-3");
            FacturaB factB = new FacturaB("Factura B para Alejandro", "20-33333333-3");
            FacturaC factC = new FacturaC("Factura C para Montoto", "20-33333333-3");

            MessageBox.Show(factA.RetornarNroCuit());
            MessageBox.Show(factB.RetornarNroCuit());
            MessageBox.Show(factC.RetornarNroCuit());
        }
    }
}
