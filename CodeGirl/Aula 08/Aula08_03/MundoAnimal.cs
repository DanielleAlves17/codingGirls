using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula08_03
{
     class MundoAnimal
    {
        public List<Animal> mamiferos { get; set; } = new List<Animal>();
        public List<Animal> peixes { get; set; } = new List<Animal>();

       public void AdicionarAnimais(Animal animais)
        {
            Animal.Add(animais);
        }

        public string ExibirDados()
        {
            
                foreach (Animal anima in mamiferos)
                {
                    Console.WriteLine(anima.ToString());
                }
            return mamiferos.ToString();
            
        }


     
    }
       
}
//Crie uma classe mundo animal que possui uma lista de peixes e mamíferos;
//Crie métodos para exibir os animais criados;
//Instancie a classe mundo animal, preencha com animais e exiba os dados dos animais criados.