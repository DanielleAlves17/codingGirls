using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula04_exercicios
{
    public class jogo {


        private string[,] Tabuleiro = new string[3,3];
        private string JogadorX;
        private string JogadorO;


        public jogo()
        {
            IniciarJogo();
        }

    
        private void IniciarJogo()
        {
            Console.WriteLine("JOGO DA VELHA");

            Console.WriteLine("Digite o nome do jogador 1 - X: ");
            Console.Write("> ");
            JogadorO = Console.ReadLine();

            Desenhar();
        }

        private void Desenhar()
        {
            Preencher();

           Console.WriteLine($" {Tabuleiro[2, 0]} | {Tabuleiro[2,1]} | {Tabuleiro[2,2]}");
           Console.WriteLine("------------");
           Console.WriteLine($" {Tabuleiro[1, 0]} | {Tabuleiro[1,1]} | {Tabuleiro[1,2]}");
           Console.WriteLine("------------");
           Console.WriteLine($" {Tabuleiro[0, 0]} | {Tabuleiro[0,1]} | {Tabuleiro[0,2]}");

            //selecionar a linha eapertar o alt com seta sobe oudesce alinha inteira
        }

        private void Preencher()
        {
            //Essa função é só pra que o tabuleiro não fique vazio inicialmente
            ////linha 1
            //Tabuleiro[0, 0] = "7";
            //Tabuleiro[0, 0] = "8";
            //Tabuleiro[0, 0] = "9";

            ////linha 2
            //Tabuleiro[0, 0] = "4";
            //Tabuleiro[0, 0] = "5";
            //Tabuleiro[0, 0] = "6";

            ////linha 3
            //Tabuleiro[0, 0] = "1";
            //Tabuleiro[0, 0] = "2";
            //Tabuleiro[0, 0] = "3";


            int Contador = 0;
            for (int Linha = 0; Linha < 3; Linha++)
            {
                for (int Coluna = 0; Coluna < 3; Coluna++)
                {

                    Contador++;
                    Tabuleiro[Linha, Coluna] = Convert.ToString(Contador);

                }

            }

        }



        private void Rodada()
        {

        }

    }



}

       

