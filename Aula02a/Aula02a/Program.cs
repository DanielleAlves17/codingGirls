using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula02a
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Faça um programa que pergunte ao usuário ano de nascimento e imprima sua idade.

            Console.WriteLine("Qual o ano do seu nascimento: ");
            int ano = int.Parse(Console.ReadLine());
            //    //Convert.ToInt32(Console.ReadLine());
            int idade = 2022 - ano;
            Console.WriteLine(idade);



            // Escreva um programa que leia o número de horas trabalhadas e um funcionário,
            // o valor que recebe por hora e calcula o salário desse funcionário.
            // A seguir, mostre o número e o salário do funcionário, com duas casas decimais.

            float horasTrabalhadas = 6.00f;
            String funcionario = "Jorde";
            float salarioBase = 1000.00f;
            float salario; 
            salario = ( salarioBase * horasTrabalhadas);

            Console.WriteLine(funcionario + " trabalha " + horasTrabalhadas + " horas e recebe: $" + salario);

            // Leia um valor inteiro correspondente à idade de uma pessoa e mostre-a em anos, meses e dias.
            //Obs.: apenas para facilitar o cálculo, considere todo ano com 365 dias e todo mês com 30 dias.
            //Nos casos de teste nunca haverá uma situação que permite 12 meses e alguns dias,
            //como 360, 363 ou 364.Este é apenas um exercício com objetivo de testar raciocínio matemático simples.

            Console.WriteLine("Escreva sua idade");
            float idade2 = float.Parse(Console.ReadLine());
            float meses = idade2 * 12;
            float dias = meses * 30;
            Console.WriteLine(idade2 +" anos, " + meses +" meses. "+ dias+ " dias.");


            //  Construa um conversor de moedas:
            //  Crie um programa que solicite um um valor em real ao usuário e converta esse valor, para:
            //DOLAR
            //EURO
            //LIBRA ESTERLINA
            //DÓLAR CANADENSE
            //PESO ARGENTINO
            //PESO CHILENO
            //Para esse exercício você precisará realizar uma pesquisa para saber a cotação de cada moeda
            //em real.Mostrar o resultado no formato símbolo da moeda e valor, como o exemplo R$ 10,00 para
            //a moeda real.

            Console.WriteLine("Escreva o valor que deseja converter: ");
            double real = double.Parse(Console.ReadLine());
            double dolar = real * 0.21;
            double euro = real * 0.19;
            double libra = real * 0.16;
            double canada = real * 0.26;
            double argentinaPeso = real * 24.90;
            double chilePeso = real * 169.35;

            Console.WriteLine($"O valor de {real} é {dolar} dólares; {euro} euros; {libra} libras esterlinas; {canada} dólares canadenses; {argentinaPeso} pesos argentinos e {chilePeso} pesos chilenos.");
                
        }
    }
}
