using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsPseudo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtRadio_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(TxtRadio.Text, out double ValorRadio)) ;
            else
            {
                TxtRadio.Text = "0";
                MessageBox.Show("Valor inválido");

            }
        }

        private void TxtGeneratriz_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(TxtGeneratriz.Text, out double ValorGeneratriz)) ;
            else
            {
                TxtGeneratriz.Text = "0";
                MessageBox.Show("Valor inválido");


            }
        }

        private void TxtAltura_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(TxtAltura.Text, out double ValorAltura)) ;
            else
            {
                TxtAltura.Text = "0";
                MessageBox.Show("Valor inválido");
            }
        }

        private void BtnSumar_Click(object sender, EventArgs e)
        {
            double ValorRadio = double.Parse(TxtRadio.Text);
            double ValorGeneratriz = double.Parse(TxtGeneratriz.Text);
            double ValorAltura = double.Parse(TxtAltura.Text);

            double Area = Math.PI * ValorRadio * (ValorRadio + ValorGeneratriz);
            double Volumen = (Math.PI * Math.Pow(ValorRadio, 2) * ValorAltura) / 3;

            TxtArea.Text = Area.ToString(".00") + " cm2";
            TxtVolumen.Text = Volumen.ToString(".00") + " cm3";
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            TxtAltura.Text = "0";
            TxtArea.Text = "0";
            TxtGeneratriz.Text = "0";
            TxtVolumen.Text = "0";
            TxtRadio.Text = "0";
        }
    }

} 
