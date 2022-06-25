using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula08_03
{
    public class Animal
    {
        public string nome;
        public int numeroPatas;
        public string cor;
        public string ambiente;
        public double velocidadeMedia;

        public Animal(string nome, int numeroPatas, string cor, string ambiente, double velocidadeMedia)
        {
            this.nome = nome;
            this.numeroPatas = numeroPatas;
            this.cor = cor;
            this.ambiente = ambiente;
            this.velocidadeMedia = velocidadeMedia;
        }

        internal static void Add(Animal animais)
        {
            throw new NotImplementedException();
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public int NumeroPatas
        {
            get { return numeroPatas; }
            set { numeroPatas = value; }
        }
        public string Cor
        {
            get { return cor; }
            set { cor = value; }
        }

        public string Ambiente
        {
            get { return ambiente; }
            set { ambiente = value;}
        }

        public double VelocidadeMedia
        {
            get { return velocidadeMedia; }
            set { velocidadeMedia = value;}
        }

        public virtual void Dados()
        {
            Console.WriteLine("----------Relatorio do pet----------");
            Console.WriteLine("O nome do animal é " + this.nome);
            Console.WriteLine("O numero de patas que possui são " + this.numeroPatas);
            Console.WriteLine("Sua cor é " + this.cor);
            Console.WriteLine("Seu ambiente é o " + this.ambiente);
            Console.WriteLine("A velocidade média que chega é de " + this.velocidadeMedia + " km/h");

        }

        //public string ToString()
        //{
        //    return base.ToString();
        //}
    }
}


