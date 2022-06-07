using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            //Elabore um programa que escreve seu nome completo, seu endereço, o CEP e telefone em linhas separadas.
            string nome = "Danielle Alves";
            string endereco = "Núcleo habitacional 2 hi rua 32 cs 36 Novo Gama - GO";
            double cep = 72860000;
            int tel = 992176614;
          Console.WriteLine("Meu nome é: " + nome + ". \nMoro no " + endereco + ". \nCEP: " + cep + ". \nTel: "+ tel);

            
            //Escolha uma mulher famosa na história da tecnologia e implemente um programa que escreve seu nome, sua formação e uma contribuição feita por ela dentro da tecnologia em linhas separadas.
            string woman = "Ada Lovelace";
            string formacao = "Matemática e escritora";
            string contribuicao = "Escreveu o primeiro algoritmo para ser processado por uma máquina, a máquina analítica de Charles Babbage.";
            Console.WriteLine("Seu nome era " + woman+ ".\nEra formada em: " +formacao+ ".\n" +contribuicao);

            //Elabore um programa que mostre na tela uma letra de música que você gosta, o compositor e o gênero musical em linhas separadas.

            string musica = "Eu só sei amar assim";
            string cantora = "Zizi Possi";
            string compositor = "Hebert Viana";
            string letra = "Muito pra mim é nada\n" +
                "Tudo pra mim não basta\n" +
                "Eu quero cada gesto\n" +
                "Cada palavra\n" +
                "Cada segundo da sua atenção\n" +
                "Faça isso por mim\n" +
                "Leve a dor pra longe daqui\n" +
                "Estou cansada de ouvir que eu só sei amar errado\n" +
                "Estou cansada de me dividir\n" +
                "No que é certo no amor\n" +
                "Quem é que vai dizer o que falar? Calar? Querer?\n" +
                "Eu quero absurdos\n" +
                "Quero amor sem fim\n" +
                "Quero te dizer que\n" +
                "Eu só sei amar assim...\n";

            Console.WriteLine("\nMúsica " + musica + "\nInterpretada por: " + cantora + "\nCompositor: " + compositor+ "\n"+  letra);




            //Elabore um programa que exibe uma mensagem que incentive outras mulheres a entrar na tecnologia.

            string gogirls;

            gogirls = "O lugar da mulher é onde ela quiser.\n Inclusive pode e deve ser dentro da informática.\n Nada que fazemos é fácil ou simples mas continuemos sempre.\n Vale a pena!";
                
            Console.WriteLine(gogirls);



        }





    }
}





