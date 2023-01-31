using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DistanciaPuntosCiSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Punto1 P1 = new Punto1(Double.Parse(tbX1.Text), Double.Parse(tbY1.Text));

            tbResultado.Text = P1.DistanciaPunto2(Double.Parse(tbX2.Text), Double.Parse(tbY2.Text)).ToString();
        }
    }
}
