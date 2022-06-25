using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula08_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3 - Mundo Animal
            //Vamos modelar o mundo animal e seus reinos?
            //Classe Animal
            //Crie uma classe animal que possua os atributos nome, número de patas, cor, ambiente e velocidade média;
            //Crie um método construtor que receba por parâmetro os valores iniciais de cada um dos atributos e
            //atribua-os aos seus respectivos atributos;
            //Crie os métodos get e set para cada um dos atributos;
            //Crie um método dados, sem parâmetro e do tipo void, que, quando chamado, imprime na tela um relatório
            //informando os dados do animal.
            //Classe Peixe
            //Crie uma classe Peixe que herde da classe Animal e tenha o atributo característica;
            //Crie um método construtor que receba por parâmetro os valores iniciais de cada um dos atributos
            //(incluindo os atributos da classe Animal) e atribua-os aos seus respectivos atributos;
            //Crie ainda os métodos get e set para o atributo característica;
            //Crie um método que quando chamado, imprime na tela um relatório informando os dados do peixe;
            //Classe Mamífero
            //Crie uma classe Mamifero que herde da classe Animal e possua um atributo alimento;
            //Crie um método construtor que atribua-os valores aos seus respectivos atributos;
            //Crie ainda os métodos get e set para o atributo alimento;
            //Crie um método que imprime na tela um relatório informando os dados do mamífero;
            //Classe Mundo Animal
            //Crie uma classe mundo animal que possui uma lista de peixes e mamíferos;
            //Crie métodos para exibir os animais criados;
            //Instancie a classe mundo animal, preencha com animais e exiba os dados dos animais criados.


           



            Mamifero mamifero1 = new Mamifero("Lob", 4, "amarelo", "terrestre", 10d, "ração");
            mamifero1.Dados();
            

            MundoAnimal animal1 = new MundoAnimal();
            animal1.AdicionarAnimais(mamifero1);
            animal1.ExibirDados();
            //Animal cachorro1 = new Animal("Jojo", 4, "preto", "terrestre", 10d);
            //cachorro1.Dados();

            //Peixe peixe1 = new Peixe("Dolly", 0, "azul e amarelo", "aquatico", 0.5d, "maritimo");
            //peixe1.Dados();

           
                Console.WriteLine("Digite qual lista deseja acessar: 1.Peixes 2.Mamiferos");
                int numeroEscolhido = int.Parse(Console.ReadLine());
                if (numeroEscolhido == 1)
                {

                    var peixes = new List<string> { "tilapia", "piranha", "salmão" };
                    foreach (var p in peixes)
                    {
                        Console.WriteLine($"Hello {p.ToUpper()}!");
                    }
                }
                else
                {
                    var mamiferos = new List<string> { "cachorro", "papagaio", "gato" };
                    foreach (var m in mamiferos)
                    {
                        Console.WriteLine($"Hello {m.ToUpper()}!");
                    }
                }

            




        }
    }
}