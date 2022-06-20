using System.Globalization;

/*1. Crie um programa que solicite a entrada de 10 números pelo usuário, armazenando-os em um vetor, e então monte outro vetor com os valores do primeiro multiplicados por 5.
Exiba os valores dos dois vetores na tela, um em cada linha.*/

Console.WriteLine("Digite 10 numeros :");
int[] arrayNumber = new int[10];

arrayNumber[0] = int.Parse(Console.ReadLine());

arrayNumber[1] = int.Parse(Console.ReadLine());

arrayNumber[2] = int.Parse(Console.ReadLine());

arrayNumber[3] = int.Parse(Console.ReadLine());

arrayNumber[4] = int.Parse(Console.ReadLine());

arrayNumber[5] = int.Parse(Console.ReadLine());

arrayNumber[6] = int.Parse(Console.ReadLine());

arrayNumber[7] = int.Parse(Console.ReadLine());

arrayNumber[8] = int.Parse(Console.ReadLine());

arrayNumber[9] = int.Parse(Console.ReadLine());



foreach (int arrNumber3 in arrayNumber)
{
    Console.WriteLine(arrNumber3);
    Console.WriteLine(arrNumber3 * 5);
}

//2.Crie um programa que armazene 10 números digitados pelo usuário em dois vetores:
//um somente para números pares, e outro somente para números ímpares. Após, exiba
//os valores dos dois vetores na tela, um vetor em cada linha.
int[] Par = new int[10];
int[] Impar = new int[10];
int nPar = 0;
int nImpar = 0;


Console.WriteLine("Digite 10 numeros inteiros:");
for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"Digite o {i + 1}º número");
    int numeros = int.Parse(Console.ReadLine());
    if (numeros % 2 == 0)
    {
        Par[nPar] = numeros;
        nPar++;
    }
    else
    {
        Impar[nImpar] = numeros;
        nImpar++;
    }


}

for (int i = 0; i < nPar; i++)
    Console.WriteLine("Os numeros pares são: " + Par[i]);

for (int i = 0; i < nImpar; i++)
    Console.WriteLine("Os numeros impares são: " + Impar[i]);

//+++++++++++++++++++++++++++++++++++++++++++++++++++++++
//Outra forma de resolver


//int[] par, impar;
//impar = new int[10];
//par = new int[10];

//int entrada;
//int indexPar = 0;
//int indexImpar = 0;

//Console.WriteLine("Entre com 10 números");
//for (int i = 0; i < 10; i++)
//{
//    Console.WriteLine($"Entre o {i + 1}º número");
//    entrada = Convert.ToInt16(Console.ReadLine());
//    if (entrada % 2 == 0)
//    {
//        par[indexPar] = entrada;
//        indexPar++;
//    }
//    else
//    {
//        impar[indexImpar] = entrada;
//        indexImpar++;
//    }
//}
//int count = 0;
//while (count < indexPar)
//{


//    if (count == 0)
//    {
//        Console.Write($"Números pares: {par[count]}, ");
//    }
//    else if (count == indexPar - 1)
//    {
//        Console.WriteLine($"e {par[count]}. ");
//    }
//    else
//    {
//        Console.Write($"{par[count]}, ");
//    }

//    count++;
//}
//count = 0;
//while (count < indexImpar)
//{
//    if (count == 0)
//    {
//        Console.Write($"Números ímpares: {impar[count]}, ");
//    }
//    else if (count == indexImpar - 1)
//    {
//        Console.WriteLine($"e {impar[count]}. ");

//    }
//    else
//    {
//        Console.Write($"{impar[count]}, ");
//    }
//    count++;
//}
//______________________________________________________________________
//int[] valores = new int[10];
//decimal soma = 0;

//for (int i = 0; i < 10; i++)
//{
//    Console.WriteLine("Informe o elemento de índice {0}:", i);
//    valores[i] = Convert.ToInt32(Console.ReadLine());
//    soma += valores[i];
//}

//decimal media = soma / 10;

//for (int i = 0; i < 10; i++)
//{
//    if (valores[i] < 5)
//        Console.WriteLine("O elemento de índice {0}, cujo valor é {1}, é menor que 5.", i, valores[i]);
//}
//________________________________________________________________


//3. Crie um programa que lê 5 palavras e as ordena em um vetor de strings pelo seu
//tamanho. Se o tamanho das strings for igual, deve-se manter a ordem inserida pelo usuário.

//Console.WriteLine("Digite 5 palavras: ");
//string[] words = new string[5];
//string words2;
//string palavras;
//for(int i = 0; i < words.Length; i++)
//{
//    words2 = (Console.ReadLine());
//    if (words2.Length == words2.Length)
//    {
//        words[i] = words2;

//    }



//}
//    Console.WriteLine(words[0]);
//Console.WriteLine(words[1]);

//string characters = "abc\u0000def";
//Console.WriteLine(characters.Length);



//4. Jogo Jokenpô
//Utilizando os conceitos aprendidos até estruturas de repetição, crie um programa que jogue
//pedra, papel e tesoura (Jokenpô) com você.
//Permitir que eu decida quantas rodadas iremos fazer;
//Ler a minha escolha (Pedra, papel ou tesoura);
//Decidir de forma aleatória a decisão do computador;
//Mostrar quantas rodadas cada jogador ganhou;
//Determinar quem foi o grande campeão de acordo com a quantidade de vitórias de cada um
//(computador e jogador);
//Perguntar se o Jogador quer jogar novamente, se sim inicie volte a escolha de quantidade
//de rodadas, se não finalize o programa.


Console.WriteLine("Quantas partidas deseja jogar: ");
int numeroPartidas = int.Parse(Console.ReadLine());

if (numeroPartidas < 0)
{
Console.WriteLine("Coloque um numero acima de 0.");
}
else
{
    Console.WriteLine($"Seu numero de partidas escolhidas foi : {numeroPartidas}");
}

for (int i = 0; i < numeroPartidas; i++)
{

    Console.WriteLine("Digite sua jogada: 1.pedra 2.tesoura 3.papel;");
    int jogada = int.Parse(Console.ReadLine());
    Random PcPlay = new Random();
    string[] escolhaDoPc = { "1", "2", "3" };
    int escolhaIndex = PcPlay.Next(escolhaDoPc.Length);
    int countJogador = 0;
    int countPc = 0;

    if (jogada == 1 && escolhaDoPc[escolhaIndex] == "1" || jogada == 2 && escolhaDoPc[escolhaIndex] == "2" || jogada == 3 && escolhaDoPc[escolhaIndex] == "3")
    {
        Console.WriteLine("Empate!");
    }
    else if ( jogada == 2 && escolhaDoPc[escolhaIndex] == "1" || jogada == 1 && escolhaDoPc[escolhaIndex] == "2")
    {
        Console.WriteLine("Pedra quebra tesoura");
        if (jogada == 1)
        {
            countJogador++;
        }
        else
            countPc++;

        Console.WriteLine($"JOGADOR {countJogador} x PC {countPc}");
    }
    else if (jogada == 2 && escolhaDoPc[escolhaIndex] == "3" || jogada == 3 && escolhaDoPc[escolhaIndex] == "2")
    {
        Console.WriteLine("Tesoura corta papel");
        if (jogada == 2)
        {
            countJogador++;
        }
        else
            countPc++;

        Console.WriteLine($"JOGADOR {countJogador} x PC {countPc}");
    }
    else /*(jogada == 3 && escolhaDoPc[escolhaIndex] == "1" || jogada == 1 && escolhaDoPc[escolhaIndex] == "3")*/
    {
        Console.WriteLine("Papel cobre pedra");
        if (jogada == 3)
        {
            countJogador++;
        }
        else
            countPc++;

        Console.WriteLine($"JOGADOR {countJogador} x PC {countPc}");
    }



}





//5. Jogo da Velha
//Crie um algorítimo que possibilite que dua pessoas joguem o jogo da velha e exiba quem foi o vencedor.
//O tabuleiro é uma matriz de três linhas e três colunas.
//Dois jogadores escolhem uma marcação cada um, geralmente um círculo (O) e um xis (X).
//Os jogadores jogam alternadamente, uma marcação por vez, numa célula que esteja vazia.
//O objetivo é conseguir três círculos ou três xis em linha, quer horizontal, vertical ou diagonal , e
//ao mesmo tempo, quando possível, impedir o adversário de ganhar na próxima jogada.
//Quando um jogador conquista o objetivo ele é o vencedor. Se os dois jogadores jogarem sempre da
//melhor forma, o jogo terminará sempre em empate ou seja "Deu a Velha!".

//Jogo jogo = new Jogo;