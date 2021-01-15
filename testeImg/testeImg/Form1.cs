using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace testeImg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAcender_Click(object sender, EventArgs e)
        {
            picLampada.Image = testeImg.Properties.Resources.LampadaAcesa;
            lblEstado.Text = "1";
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            picLampada.Image = testeImg.Properties.Resources.LampadaApagada;
            lblEstado.Text = "0";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (lblEstado.Text == "1") 
            {
                picLampada.Image = Properties.Resources.LampadaApagada;
                lblEstado.Text = "0";
            }
            else
            {
                picLampada.Image = Properties.Resources.LampadaAcesa;
                lblEstado.Text = "1";
            }
        }

        private void picLampada_DoubleClick(object sender, EventArgs e)
        {
            timer1.Enabled = ! timer1.Enabled;
        }

        private void clicou_no_botao(object sender, EventArgs e)
        {
            Button remetente = (Button)sender;

            lblSaida.Text = remetente.Text;
        }

        
    }
}
