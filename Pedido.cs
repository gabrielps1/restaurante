using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio
{
    internal class Pedido
    {
        private string nome;
        private double valorTotal;
        private double calorias;

        public string Nome { get => nome; set => nome = value; }
        public double ValorTotal { get => valorTotal; set => valorTotal = value; }
        public double Calorias { get => calorias; set => calorias = value; }


    }
}
