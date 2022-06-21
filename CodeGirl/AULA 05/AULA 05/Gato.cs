using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AULA_05
{
    public class Gato
    {
            public string Nome;
            public string Raca;
            public string Temperamento;
            public string CorPelo;
            public int Idade;
             public void Miar()
        {
            Console.WriteLine("Miauuuu!");
        }

        public void Brincar(string brinquedo = "Móveis da Casa")
        {
            Console.WriteLine("Eu adoro brincar com " + brinquedo);
            //Quando um parâmetro é passado para o método, ele é chamado de argumento.
            //Então, do exemplo acima: brinquedo é um parâmetro e Bolinha é um argumento.
            //Você também pode definir um valor de parâmetro padrão, usando o sinal de igual =.
            //Quando eu não brinco com o Balu, ele gasta sua energia aprontando peripécias
            //com os móveis da casa. Podemos implementar o método Brincar sem passar um brinquedo
            //e por padrão ele usará o valor padrão Móveis da Casa

        }

        public string Bagunca(string brinquedo)
        {
            if (brinquedo != "Bola")
            {
                return "Não gosto de Brincar com: " + brinquedo;
            }
            else
            {
                return "Eu adoro brincar com " + brinquedo;
            }
        }


    }


} 

