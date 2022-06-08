using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Faça um programa que pergunte ao usuário ano de nascimento e imprima sua idade.
           
           // Console.WriteLine("Que ano você nasceu ?");
            //int ano = int.Parse(Console.ReadLine());
            //Convert.ToInt32(Console.ReadLine());
            //int idade = 2022 - ano;
           // Console.WriteLine(idade);


            //2.Escreva um programa que leia 10 valores inteiros e ao final exiba a soma dos números.

            int num1,num2,num3,num4,num5,num6,num7,num8,num9,num10;
            num1 = 10;
            num2 = 20; 
            num3 = 30;
            num4 = 31;
            num5 = 32;
            num6 = 33;
            num7 = 42;
            num8 = 43;
            num9 = 54;
            num10 = 50;
            int somaTotal = (num1 + num2 +num3 +num4+num5+num6+num7+num8+num9+num10);
            Console.WriteLine(somaTotal);



         
            //3.Escreva um programa que leia o número de horas trabalhadas e um funcionário,
            //o valor que recebe por hora e calcula o salário desse funcionário. A seguir,
            //mostre o número e o salário do funcionário, com duas casas decimais.
            //
            //
            //
            //
            //
            //
            //4.Leia um valor inteiro correspondente à idade de uma pessoa e mostre-a em anos, meses e dias.
            //Obs.: apenas para facilitar o cálculo, considere todo ano com 365 dias e todo mês com 30 dias.
            //Nos casos de teste nunca haverá uma situação que permite 12 meses e alguns dias, como 360, 363
            //ou 364.Este é apenas um exercício com objetivo de testar raciocínio matemático simples.
            //



            //
            //5.Construa um conversor de moedas:Crie um programa que solicite um um valor em real ao usuário
            //e converta esse valor, para:
            //DOLAR
            //EURO
            //LIBRA ESTERLINA
            //DÓLAR CANADENSE
            //PESO ARGENTINO
            //PESO CHILENO
            //Para esse exercício você precisará realizar uma pesquisa para saber a cotação de cada moeda em real.
            //Mostrar o resultado no formato símbolo da moeda e valor, como o exemplo R$ 10,00 para a moeda real.


        }
    }
}
