using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_Grafica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (rbArea.Checked == true)
            {
                double raio = Convert.ToDouble(txtRaio.Text);
                double area = Math.PI * Math.Pow(raio, 2);
                lbResultado.Text = "AREA =" + area.ToString("N3");
            }
            if (rbPerimetro.Checked == true)
            {
                double raio = Convert.ToDouble(txtRaio.Text);
                double perimetro = 2 * Math.PI * raio;
                lbResultado.Text = "PERIMETRO = "
                    + perimetro.ToString("N3");
            }
            if (rbVolume.Checked == true)
            {
                double raio = Convert.ToDouble(txtRaio.Text);
                double volume = 3f / 4f * Math.PI * Math.Pow(raio, 3);
                lbResultado.Text = "VOLUME =" + volume.ToString("N3");
            }
            if (opDesenhar.Checked == true)
                PlotarCirculo();
            else
                pnDesenho.CreateGraphics().Clear(
                    pnDesenho.BackColor);
        }

        private void PlotarCirculo()
        {
            Graphics tela = pnDesenho.CreateGraphics();
            Pen caneta = new Pen(Color.DarkOrange, 3);
            double d = Convert.ToDouble(txtRaio.Text)*2;
            int cx = pnDesenho.Width / 2;
            int cy = pnDesenho.Height / 2;
            tela.Clear(pnDesenho.BackColor);
            tela.DrawEllipse(caneta,(int) (cx - d/2), (int) (cy - d/2),
                (int)d, (int)d);
            tela.DrawRectangle(caneta, (int)(cx - d / 2), (int)(cy - d / 2),
                (int)d, (int)d);
            tela.DrawLine(caneta, 0, cy, pnDesenho.Width, cy);
            tela.DrawLine(caneta, cx, 0, cx, pnDesenho.Height);
           

        }
        private void lbResultado_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
