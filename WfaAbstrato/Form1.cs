using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WfaAbstrato
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbForma.Text)
            {
                case "Quadrado":
                    SelecionarQuadrado();
                    break;
                case "Triangulo":
                    SelecionarTriangulo();
                    break;
                default:
                    break;                    
            }
        }

        private void SelecionarQuadrado()
        {
            ExibirBase(true);
            ExibirAltura(false);
            ExibirRaio(false);

            cmbTipo.Visible = false;
        }

        private void ExibirRaio(bool visible)
        {
            lblRaio.Visible = txtRaio.Visible = visible;
        }

        private void ExibirAltura(bool visible)
        {
            lblAltura.Visible = txtAltura.Visible = visible;
        }

        private void ExibirBase(bool visible)
        {
            lblBase.Visible = txtBase.Visible = visible;
        }

        private void SelecionarTriangulo()
        {
            cmbTipo.Visible = true;
            ExibirBase(true);
            ExibirAltura(true);
            ExibirRaio(false);
        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            if(cmbForma.Text.Equals("Quadrado"))
            {
                FormaGeometrica quadrado = new Quadrado()
                {
                    Lado = Convert.ToDouble(txtBase.Text)
                };
                cmbObjetos.Items.Add(quadrado);

           
            }
        }

        private void cmbObjetos_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormaGeometrica obj = cmbObjetos.SelectedItem as FormaGeometrica;

            txtArea.Text = obj.CalcularArea().ToString();
            txtPerimetro.Text = obj.CalcularPerimetro().ToString();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
