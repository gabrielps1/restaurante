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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            foreach (var item in Program.ListaPedido)
            {
                if(item.Nome == txtNome.Text)
                {
                    if (item.Nome == txtNome.Text)
                        listBox1.Items.Add(item.Nome + " - R$" + item.Calorias + " - " + item.ValorTotal);
                }
            }
        }
    }
}
