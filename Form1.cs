using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class numRectangulo1 : Form
    {
        public numRectangulo1()
        {
            InitializeComponent();
        }

        private void btnArea_Click(object sender, EventArgs e)
        {
           
            decimal resultado = CAreas.Cuadrado(numCuadrado2.Value);
            lblArea.Text = resultado + "";
        }

        private void btnAreaTriangulo_Click(object sender, EventArgs e)
        {
            
            decimal resultado = CAreas.Triangulo(numDato1.Value, numDato2.Value);
            lblAreaTriangulo.Text = resultado + ""; 
        }


        private void btnAreaRectangulo_Click_1(object sender, EventArgs e)
        {
  
            decimal resultado = CAreas.Rectangulo(numDatoRectangulo.Value, numDatoRectangulo2.Value);
            lblAreaRectangulo.Text = resultado + "";

        }

        private void btnAreaRomboide_Click(object sender, EventArgs e)
        {
            
            decimal resultado = CAreas.Romboide(numDatoRomboide.Value, numDatoRomboide2.Value);
            lblAreaRomboide.Text = resultado + "";
        }

        private void btnAreaRombo_Click(object sender, EventArgs e)
        {
           
            decimal resultado = CAreas.Rombo(numDatoRombo.Value, numDatoRombo2.Value);
            lblAreaRombo.Text = resultado + "";
        }
    }
}
