using System;

namespace Aula_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*criar um programa para ler 3 numeros e mostrar para o usuario qual é o maior numero

            Console.WriteLine("Digite três números: ");

            int n1,n2, n3;
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            n3 = int.Parse(Console.ReadLine());

            int resultado = Maior(n1,n2,n3);

            Console.WriteLine("Maior = " +resultado);


        }

        //criar uma função
        // static vamos iniciar com static seguindo o Main
        // para manter a comunicação
        // int nesse caso representa a saída da função
        //Maior = nome da função
        //() qnd estão vazios representam que a função não receberá parametros para executar
        static int Maior(int n1,int n2, int n3)
        {
            int maiorNumero;
            
            if (n1 > n2 && n1 > n3)
            {
                maiorNumero = n1;
            }
            else if (n2 > n3)
            {
                maiorNumero=n2;
            }
            else
            {
                maiorNumero = n3;
            }
         
            return maiorNumero;*/




            // representação do mundo real
            //classe /objeot= fisico / abstrato
            // POO = Programação Orientada ao Objeto

            //Uma classe possui:

            //propriedade(atributos) / caracteristicas;
            //métodos(funções)
            // eventos ( o que é feito durante uma ação)


            /* 4 pilares de OO
             * Encapsulamento - agrupar o que faz sentido estar junto
             * Abstração - esconder os detalhes ( eu aprendi que era tornar mais simples o complexo)
             * Polimorfismo - um metodo pode ser executado de formas diferentes
             * Herança - capacidade de um objeto herdar, propriedade de outro objeto
             *   */


            //********************************* EXERCICIOS *******************************************************

            //1.Jogo da Velha
            //Lembra do nosso jogo da velha da aula de matrizes? Vamos refazê - lo orientado a objetos?
            //Crie uma classe para o Jogo da Velha:
            //A classe deve conter como dados privados uma matriz 3x3 para representar a grade do jogo
            //O construtor deve inicializar a matriz vazia
            //Forneça um método para exibir a matriz com status do jogo
            //Permita dois jogadores humanos
            //Forneça um método para jogar o jogo; todo movimento deve ocorrer em uma casa vazia; depois de
            //cada movimento valide se uma vitória ou um empate.


            //2.Gerenciando Salários
            //A fim de representar empregados em uma empresa, crie uma classe chamada Empregado que inclui
            //os seguintes atributos; nome, cargo e salário mensal.
            //Sua classe deve ter um construtor que inicializa os três atributos e também fornecer métodos
            //que executem as seguintes ações:
            //Se o salário mensal não for positivo, configure - o como 0.0.
            //Conceder aumento de salários a seus funcionários de acordo com os dados abaixo: Salário de 0
            //té 400.00 ganha 15 % Salário de 400.01 até 800.00 ganha 12 % Salário de 800.01 até 1200.00
            //ganha 10 % Salário de 1200.01 até 2000.00 ganha 7 % Acima de 2000.00 ganha 4 %
            //Imprimir o salário de um funcionário.

            Empregado Joao = new Empregado("Joao", "Jornalista", 250.00d);
            Joao.SalarioMensal();



            //3.Fatura de Serviço
            //Crie uma classe que representa uma fatura para uma loja de suprimentos de informática.
            //A classe deve conter os seguintes atributos: número, descrição dos produtos, quantidade comprada de
            //um produto e o preço.A classe deve ter um construtor e um método get e set para cada variável de
            //instância.Além disso, forneça um método para calcular o valor total da fatura.
            Fatura faturaFevereiro = new Fatura(0222, "shampoo",5, 6.50d);
            faturaFevereiro.TotalFatura();
            
            //4.Sorteio
            //Fazer uma classe que represente um Sorteio que irá sortear um número de 0 a 1000 e após pedir para o
            //usuário adivinhar este número.Se ele errar, informar se o palpite é maior ou menor do que o número
            //sorteado.O usuário pode jogar até que acerte e, depois disso, mostrar quantas tentativas ele fez até
            //acertar.
            //Dica utilize a classe Random do C#, para gerar números aleatórios.
            
            
            
            
            //5.Manipulando Strings
            //Montar uma classe que manipula strings:
            //Faça um método que receba um nome completo e mostre a abreviatura deste nome. Não se devem abreviar as
            //palavras com 2 ou menos letras.A abreviatura deve vir separada por pontos.
            //Entrada:
            //Giulia Bordignon
            //Paulo Jose de Almeida Prado
            //Saída:
            //G.B.
            //P.J.de A. P.
            //Fazer um método que receba uma string do usuário e mostre o conteúdo desta string de forma invertida.
            //Fazer um método que receba uma string e conte suas vogais e consoantes


        }

        




    }
}
