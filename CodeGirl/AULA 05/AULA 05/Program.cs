using System;

namespace AULA_05
{
    public class Program
    {
      static void Main(string[] args)
        {
            //int[] numeroLoteria = { 4, 8, 15, 16, 23, 42, 108 };

            ////for (int i =0; i <= numeroLoteria.Length; i++ ){

            //    //Console.WriteLine(numeroLoteria[i]);
            ////}

            //foreach( int numero in numeroLoteria)
            //{
            //    Console.WriteLine(numero);
            //}

            //Gato gato1 = new Gato("Barvo","De Rua","Dócil", "Amarelo-marrom",1 );


            //    Gato gato2 = new Gato();
            //    gato2.Nome = "Balu";
            //    gato2.Raca = "Vira Lata";
            //    gato2.CorPelo = "Branco";
            //    gato2.Idade = 1;

            //    Console.WriteLine("A Raça do Gato é: " + gato2.Raca);
            //    gato2.Miar();
            //    gato2.Miar();
            //    gato2.Miar();
            //gato2.Brincar();
            //Console.WriteLine(gato2.Bagunca("sapatos"));
            //gato2.Brincar("sapatos");
            //Quando um parâmetro é passado para o método, ele é chamado de argumento.
            //Então, do exemplo acima: brinquedo é um parâmetro e Bolinha é um argumento.


            //++++++++++++++++++++++++++++++EXERCICIOS+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++


            // 1.Escreva uma classe cujos objetos representam alunos matriculados em uma disciplina.
            // Cada objeto dessa classe deve guardar os seguintes dados do aluno: matrícula, nome,
            // 2 notas de prova e 1 nota de trabalho.Escreva os seguintes métodos para esta classe:
            //Calcular média: calcula e exibe a média final do aluno com base em suas notas;
            //Calculo nota final: calcula quanto o aluno precisa tirar na prova final para ser
            //aprovado.

            AlunosAula05 aluno1 = new AlunosAula05();
            aluno1.Prova1 = 6.0;
            aluno1.Prova2 = 5.0;
            aluno1.Trabalho = 7.0;
            aluno1.MediaFinal();
            aluno1.NotaFinal();






            //2.Escreva uma classe em que cada objeto representa um vôo que acontece em determinada
            //data e em determinado horário. Cada vôo possui no máximo 100 passageiros, e a classe
            //permite controlar a ocupação das vagas.
            //A classe deve ter os seguintes métodos:
            //Ocupar Vaga: ocupa determinada cadeira do vôo, cujo número é recebido como parâmetro,
            //e retorna verdadeiro se a cadeira ainda não estiver ocupada(operação foi bem sucedida)
            //e falso caso contrário
            //Vagas Livres: retorna o número de cadeiras vagas disponíveis(não ocupadas) no vôo;
            //Cadeira Livre: Retorna o número da próxima cadeira livre;
            //Ocupa: ocupa determinada cadeira do vôo, cujo número é recebido como parâmetro. Caso a cadeira esteja ocupada exibe uma mensagem, caso esteja vazia, reserva e exibe uma mensagem de confirmação;
            //Ver horário: Imprime a data e o horário do vôo.





            //3.Crie uma classe Calculadora, que possui como métodos a multiplicação, divisão,
            //subtração e soma de dois valores e exibe para o usuário.


            CalculadoraAula05 calc1 = new CalculadoraAula05();
            CalculadoraAula05 calc2 = new CalculadoraAula05();




            Console.WriteLine(calc1.Soma());
            Console.WriteLine(calc1.Sub());
            Console.WriteLine(calc2.Divi());
            Console.WriteLine(calc2.Mult());


        }
    }
}

