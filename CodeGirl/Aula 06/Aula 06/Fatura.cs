using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_06
{
    public class Fatura
    {
        public int numeroFatura;
        public string descricaoProdutos;
        public int quantidadeProduto;
        public double precoUnitario;


        public Fatura(int numeroFatura, string descricaoProdutos, int quantidadeProduto, double precoUnitario)
        {
            this.numeroFatura = numeroFatura;
            this.descricaoProdutos = descricaoProdutos;
            this.quantidadeProduto = quantidadeProduto;
            this.precoUnitario = precoUnitario;

        }

        public int Numero_Fatura
        {
            get { return numeroFatura; }
            set { numeroFatura = value; }
           
        }

        public string DescricaoProdutos
        {
            get { return descricaoProdutos; }
            set { descricaoProdutos = value; }
        }

        public double PrecoUnitario
        {
            get { return precoUnitario; }
            set { precoUnitario = value; }
        }

        public int QuantidadeProduto
        {
            get { return quantidadeProduto; }
            set { quantidadeProduto = value; }
        }

      
        public void TotalFatura()
        {
            double TF = this.precoUnitario * this.quantidadeProduto;
            Console.WriteLine("O valor total de sua fatura foi: " + TF);
        }
     
    }
}
