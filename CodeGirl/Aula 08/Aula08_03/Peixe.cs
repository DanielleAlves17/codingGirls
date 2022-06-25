using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula08_03
{
    class Peixe : Animal
    {
        public string caracteristica { get; set; }

        //public Peixe()
        //{

        //}

        //esse abaixo é construtor da classe filha, usando a mãe
        public Peixe(string nome, int numeroPatas, string cor, string ambiente, double velocidadeMedia, string caracteristica)
            : base(nome, numeroPatas, cor, ambiente, velocidadeMedia) // serve para pegar os parametros da classe mãe 
        {

            this.caracteristica = caracteristica;
        }

        public override void Dados()
        {
            Console.WriteLine("----------Relatorio do pet----------");
            Console.WriteLine("O nome do animal é " + this.nome);
            Console.WriteLine("O numero de patas que possui são " + this.numeroPatas);
            Console.WriteLine("Sua cor é " + this.cor);
            Console.WriteLine("Seu ambiente é o " + this.ambiente);
            Console.WriteLine("A velocidade média que chega é de " + this.velocidadeMedia + " km/h");
            Console.WriteLine("Esse peixe é : " + this.caracteristica);
        }


    }
}
