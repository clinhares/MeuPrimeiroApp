using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeuPrimeiroApp
{
    public partial class Form1 : Form
    {
        Carro carro;

        public Form1()
        {
            InitializeComponent();
            carro = new Carro();
        }

        private void BtnLigar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(carro.Ligar());
        }

        private void BtnDesligar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(carro.Desligar());
        }

        private void BtnDetalhes_Click(object sender, EventArgs e)
        {
            MessageBox.Show(carro.Detalhes());
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var valor1 = 10;
            var valor2 = 0;

            //teste

            var resultado = valor1 / valor2;

            MessageBox.Show(resultado.ToString());
        }
    }
}
