using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AULA_05
{
    public class AlunosAula05
    {

        public string Nome;
        public string Matricula;
        public double Prova1;
        public double Prova2;
        public double Trabalho;


  

        public void MediaFinal()
        {
            double MF = (this.Prova1 + this.Prova2 + this.Trabalho) / 3;
            Console.WriteLine($" Sua média final foi: {MF}");
        }

        public void NotaFinal()
        {
            double NSF = 21 - (this.Prova1 + this.Trabalho);
            if (NSF >= 11)
            {
                Console.WriteLine("Você vai precisar fazer a prova de recuperação.");
            }
            else
            {
                Console.WriteLine($"você precisa tirar na prova final  = {NSF}.");
            }

        }


    }
}
