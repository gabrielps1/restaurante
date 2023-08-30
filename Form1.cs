using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio
{
    public partial class Form1 : Form
    {

        private double calorias;
        private double preco;

        private double[] caloriasPao = {8, 10.5 };
        private double[] caloriasCarne = {12.8, 7.2};
        private double[] caloriasComplemento = { 0, 0.3, 5.5, 9.3 };

        private double[] precoPao = { 6, 3 };
        private double[] precoCarne = { 12.5, 9.3 };
        private double[] precoComplemento = { 0, 2.0, 0.8, 4.3 };

       
        Pedido P = null; 

        public Form1()
        {
            InitializeComponent();
        }

        private void btnFechado_Click(object sender, EventArgs e)
        {
            calorias = 0;
            preco = 0;

            if (rdbAmericano.Checked == true)
            {
                calorias += caloriasPao[0];
                preco += precoPao[0];
            }
            else
            {                           
                calorias += caloriasPao[1];
                preco += precoPao[1];                
            }

            if (rdbPicanha.Checked == true)
            {
                calorias += caloriasCarne[0];
                preco += precoCarne[0];
            }
            else
            {
                calorias += caloriasCarne[1];
                preco += precoCarne[1];
            }

            if (ckbAlface.Checked == true)
            {
                calorias += caloriasComplemento[0];
                preco += precoComplemento[0];
            }

            if (ckbPicles.Checked == true)
            {
                calorias += caloriasComplemento[1];
                preco += precoComplemento[1];
            }

            if (ckbCebola.Checked == true)
            {
                calorias += caloriasComplemento[2];
                preco += precoComplemento[2];
            }

            if (ckbMaionese.Checked == true)
            {
                calorias += caloriasComplemento[3];
                preco += precoComplemento[3];
            }

            lblResultado.Text = txtNome.Text + " seu sanduiche tem";
            lblResultado.Text += calorias.ToString(" 0.00 calorias ") + "e ficou em R$ ";
            lblResultado.Text += preco.ToString("0.00");

            P = new Pedido();
            P.Nome = txtNome.Text;
            P.Calorias = calorias;
            P.ValorTotal = preco;
            Program.ListaPedido.Add(P);


        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }
    }
}