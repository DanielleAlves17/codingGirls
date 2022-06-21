using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_06
{
    public class Empregado
    {

        public string nome;
        public string cargo;
        public double salarioMensal;
        

        public Empregado(string nome, string cargo, double salarioMensal)
        {
            this.nome = nome;
            this.cargo = cargo;
            this.salarioMensal = salarioMensal;
        }


        public void SalarioMensal() 
        {
            double SM = this.salarioMensal; 
            double aumentoSalarial;
            if(SM <= 0)
            {
                SM = 0.0;
                
            }else if (SM > 0 && SM < 400)
            {
                aumentoSalarial = SM + (0.15 * SM);
                Console.WriteLine($"Seu novo salário é de {aumentoSalarial}");
            }
            else if(SM > 400 && SM < 800)
            {
                aumentoSalarial = SM + (0.12 * SM);
                Console.WriteLine($"Seu novo salário é de {aumentoSalarial}");
            }
            else if(SM >800 && SM < 1200)
            {
                aumentoSalarial = SM + (0.10 * SM);
                Console.WriteLine($"Seu novo salário é de {aumentoSalarial}");
            }
            else if(SM >1200 && SM < 2000)
            {
                aumentoSalarial = SM + (0.07 * SM);
                Console.WriteLine($"Seu novo salário é de {aumentoSalarial}");
            }
            else
            {
                aumentoSalarial = SM + (0.04 * SM);
                Console.WriteLine($"Seu novo salário é de {aumentoSalarial}");
            }
        
        }

        
        //Sua classe deve ter um construtor que inicializa os três atributos e também fornecer métodos
        //que executem as seguintes ações:
        //Se o salário mensal não for positivo, configure - o como 0.0.
        //Conceder aumento de salários a seus funcionários de acordo com os dados abaixo: Salário de 0
        //té 400.00 ganha 15 % Salário de 400.01 até 800.00 ganha 12 % Salário de 800.01 até 1200.00
        //ganha 10 % Salário de 1200.01 até 2000.00 ganha 7 % Acima de 2000.00 ganha 4 %
        //Imprimir o salário de um funcionário.
    }
}
