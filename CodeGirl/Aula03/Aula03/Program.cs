using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //int num = 10;
            //int num2 = 15;

            //Console.WriteLine($"è igual a : {num==num2}");
            //Console.WriteLine($"é diferente de : {num != num2}");
            //Console.WriteLine($"é maior que : {num > num2}");
            //Console.WriteLine($"é menor que : {num < num2}");

            //Console.WriteLine($"{num > num2 && num == num2}");
            //Console.WriteLine($"{num < num2 || num == num2}");
            //Console.WriteLine($"{!(num != num2)}");

            //Console.ReadLine();
            // tem a missão de parar a execução do programa e fazer com que
            // o computador espere a entrada de dados através do teclado do usuário



            // -------------------------    EXERCÍCIOS    ------------------------



            //1. Leia um valor de ponto flutuante com duas casas decimais. Este valor representa um valor monetário.
            //A seguir, calcule o menor número de notas e moedas possíveis no qual o valor pode ser decomposto.
            //As notas consideradas são de 100, 50, 20, 10, 5, 2.
            //Entrada: 576.73
            //Exemplo de Saída: NOTAS: 5 nota(s) de R$ 100.00 1 nota(s) de R$ 50.00 1 nota(s) de R$ 20.00 0 nota(s) de R$ 10.00
            //1 nota(s) de R$ 5.00 0 nota(s) de R$ 2.00

            float valor = 576.73f;

            float nota100 = (valor / 100);
            float rest100 = (valor % 100);
            float nota50 = rest100 / 50;
            float rest50 = rest100 % 50;
            float nota20 = (rest50 / 20);
            float rest20 = rest50 % 20;
            float nota10 = rest20 / 10;
            float rest10 = rest20 % 10;
            float nota5 = rest10 / 5;
            float rest5 = rest10 % 5;
            float nota2 = rest5 / 2;
            float rest2 = rest5 % 2;



            Console.WriteLine($" São {Math.Floor(nota100)} notas de 100 , são {Math.Floor(nota50)} notas de 50, são { Math.Floor(nota20)} notas de 20, são {Math.Floor(nota10)} notas de 10, são {Math.Floor(nota5)} notas de 5 e {Math.Floor(nota2)} notas de 2 e restou {rest2.ToString("N2")}");




            //2.Faça um programa que leia três valores e apresente o maior dos três valores lidos
            //seguido da mensagem “x é o maior”.
            //Exemplo de Entrada 7 14 106
            //Exemplo de Saída 106 é o maior

            int a = 7;
            int b = 14;
            int c = 106;
            if (a > b && a > c)
            {
                Console.WriteLine(" O maior valor dos três é :" + a);
            }
            else if (b > c && b > a)
            {
                Console.WriteLine("O maior valor dos três é: " + b);
            }
            else Console.WriteLine("O maior valor dos três é " + c);




            //3.Leia 3 valores que são as três notas de um aluno. A seguir, calcule a média do aluno.
            //Considere que cada nota pode ir de 0 até 10.0, sempre com uma casa decimal.
            //Imprima se o aluno foi aprovado ou reprovado considerando a média 7.
            //Exemplo de Entrada 7 8 3
            //Exemplo de Saída O aluno tirou 6 e foi reprovado.

            Console.WriteLine("Digite a primeira nota: ");
            float nota1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota: ");
            float nota02 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite a terceira nota: ");
            float nota3 = float.Parse(Console.ReadLine());

            float media = (nota1 + nota02 + nota3) / 3;

            if (media >= 7)
            {
                Console.WriteLine($"O aluno foi aprovado com nota {media.ToString("N2")}.");
            }
            else Console.WriteLine($" O aluno foi reprovado com a nota {media.ToString("N2")}");





            //4.Leia 3 valores que são as três notas de um aluno. A seguir, calcule a média do aluno.
            //Se a nota for menor que 6.0, deve exibir a nota F.
            //Se a nota for de 6.0 até 7.0, deve exibir a nota D.
            //Se a nota for entre 7.0 e 8.0, deve exibir a nota C.
            //Se a nota for entre 8.0 e 9.0, deve exibir a nota B.
            //Se a nota fot entre 9.0 e 10.0, deve exibir um belo de um A.
            //Não esqueça de adicionar uma mensagem após a nota, pode ser um simples parabéns para aprovação ou algo mais complexo.
            //Exemplo de Entrada 10 8 9
            //Exemplo de Saída O aluno tirou A.Parabéns!

            Console.WriteLine("------ Média do Aluno ------");

            Console.WriteLine("Digte a 1º Nota");
            float notaA = float.Parse(Console.ReadLine());

            Console.WriteLine("Digte a 2º Nota");
            float notaB = float.Parse(Console.ReadLine());

            Console.WriteLine("Digte a 3º Nota");
            float notaC = float.Parse(Console.ReadLine());

            float media1 = (notaA + notaB + notaC) / 3;

            if (media1 >= 9.0)
            {
                Console.WriteLine("Aluno com média A");
            }
            else if (media1 >= 8.0 || media1 <= 8.9)
            {
                Console.WriteLine("Aluno com média B");
            }
            else if (media1 >= 7.0 || media1 <= 7.9)
            {
                Console.WriteLine("Aluno com média C");
            }
            else if (media1 >= 6.0 || media1 <= 6.9)
            {
                Console.WriteLine("Aluno com média D");
            }
            else

                Console.WriteLine("Aluno com média F");
            Console.WriteLine(media1);







            //5.A Blue resolveu dar um aumento de salários a seus funcionários de acordo com os dados abaixo:
            //Salário de 0 até 400.00 ganha 15 % Salário de 400.01 até 800.00 ganha 12 % Salário de 800.01 até 1200.00 ganha 10 % Salário de 1200.01 até
            //2000.00 ganha 7 % Acima de 2000.00 ganha 4 %
            //Leia o salário do funcionário e calcule e mostre o novo salário, bem como o valor de reajuste ganho e o índice reajustado, em percentual.
            //Exemplo de Entrada 400.00
            //Exemplo de Saída Novo salario: 460.00 Reajuste ganho: 60.00 Em percentual: 15 %



            Console.WriteLine("Digite o valor do seu salário: ");
            float salario = float.Parse(Console.ReadLine());
            float salarioNovo;
            if(salario >0 && salario <= 400)
            {
                salarioNovo = salario * 0.15f;
            }else if (salario > 400 && salario <= 800)
            {
                salarioNovo = salario * 0.12f;
            }else if(salario > 800 && salario <= 1200)
            {
                salarioNovo = salario * 0.10f;
            }else if(salario >1200 && salario <= 2000)
            {
                salarioNovo = salario * 0.07f;
            }
            else
            {
                salarioNovo = salario * 0.04f;
            }

            Console.WriteLine("Seu salário novo é de: R$" +(salarioNovo+salario)+ " e seu aumento foi de "+salarioNovo);



        }

        static void Condicional()
        {

        }
    }
}
