using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_07
{
    public class Aluno
    {

        private string nome;
        private string matricula;
        private double nota1;
        private double nota2;
        private int frequencia;

        public Aluno(string nome, string matricula, double nota1, double nota2, int frequencia)
        {
            this.nome = nome;
            this.matricula = matricula;
            this.nota1 = nota1;
            this.nota2 = nota2;
            this.frequencia = frequencia;
        }

        public string Nome
        {
            set { nome = value; }
        }
        public string Matricula 
            { get { return this.nome; } 
            set { matricula = value; }
        
        }
        
        public double Nota1
        {
            get { return nota1; }
            set { nota1 = value; }
        }

        public double Nota2
        {
            get { return nota2; }
            set { nota2 = value; }
        }

        public void NotaFinal()
        {
            double NF = (this.nota1 + this.nota2) / 2;
            Console.WriteLine($"Sua média final foi: {NF}");
        }




    }
}
