namespace Aula_09
{
    internal class Program
    {
        //Exercicio 01
        //Faça um programa que calcule a área de uma figura geométrica planas. Aceite quatro tipos de figura
        //geométrica: quadrado, retângulo, triângulo e círculo. Utilize as fórmulas abaixo para chegar na área
        //das figuras planas.
        //Não esqueça de usar os conceitos de herança e polimorfismo aprendidos hoje!
        public enum OpcoesMenu
        {
            Sair = 0,
            Quadrado = 1,
            Retangulo = 2,
            Triangulo = 3,
            Circulo = 4,
            Losango = 5,
            Trapezio = 6

        }
        
        static void Main(string[] args) 
        {
            OpcoesMenu escolha = OpcoesMenu.Quadrado;
            while ((escolha = GetEscolha()) != OpcoesMenu.Sair)
            {
                Area area = null;
                switch (escolha)
                {
                    case OpcoesMenu.Quadrado:
                        area = CriaQuadrado();
                        break;
                    case OpcoesMenu.Retangulo:
                        area = CriaRetangulo();
                        break;
                    case OpcoesMenu.Triangulo:
                        area = CriaTriangulo();
                        break;
                    case OpcoesMenu.Circulo:
                        area = CriaCirculo();
                        break;
                    case OpcoesMenu.Losango:
                        area = CriaLosango();
                        break;
                    case OpcoesMenu.Trapezio:
                        area = CriaTrapezio();
                        break;
                    default:
                        break;
                }
                Console.WriteLine($"A área do {escolha} é {area.AreaX}.");
                Console.WriteLine();
            }
            //encerra app
            Environment.Exit(0);  
           
         }
        public static OpcoesMenu GetEscolha()
        {
            Console.WriteLine("Escolha qual figura deseja calcular a área:");
            Console.WriteLine("\t(1) - Quadrado", (int)OpcoesMenu.Quadrado);
            Console.WriteLine("\t(2) - Retângulo", (int)OpcoesMenu.Retangulo);
            Console.WriteLine("\t(3) - Triângulo", (int)OpcoesMenu.Triangulo);
            Console.WriteLine("\t(4) - Círculo", (int)OpcoesMenu.Circulo);
            Console.WriteLine("\t(5) - Losango", (int)OpcoesMenu.Losango);
            Console.WriteLine("\t(6) - Trapézio", (int)OpcoesMenu.Trapezio);
            Console.WriteLine("\t(0) - SAIR DO PROGRAMA", (int)OpcoesMenu.Sair);
            Console.Write("Escolha: ");
            string valor = Console.ReadLine();
            OpcoesMenu escolha;
            if (!Enum.TryParse(valor, out escolha) || !Enum.IsDefined(typeof(OpcoesMenu), escolha))
                    {
                Console.WriteLine("OPÇÃO INVÁLIDA, ESCOLHA UMA OPÇÃO VÁLIDA: ");
                return GetEscolha();
                        }
            return escolha;
        }

        private static double GetDouble(string prompt)
        {
            bool isValido = false;
            double valor = 0;
            while (!isValido)
            {
                Console.Write(prompt);
                isValido = double.TryParse(Console.ReadLine(), out valor);
            }
            return valor;
        }

        private static Quadrado CriaQuadrado()
        {
            double lado = GetDouble("Insira o valor do lado do quadrado: ");
            return new Quadrado() { Lado = lado };
        }

        private static Retangulo CriaRetangulo()
        {
            double bs = GetDouble("Insira o valor da base do retângulo: ");
            double altura = GetDouble("Insira o valor da altura do retângulo: ");
            return new Retangulo() { Bs = bs, Altura = altura };
            
        }

        private static Triangulo CriaTriangulo()
        {
            double bs = GetDouble("Insira o valor da base do triângulo: ");
            double altura = GetDouble("Insira o valor da altura do triângulo: ");
            return new Triangulo() { Bs = bs, Altura = altura };
        }

        private static Circulo CriaCirculo()
        {
            double raio= GetDouble("Insira o valor do raio do círculo: ");
            return new Circulo() { Raio = raio };
        }

        private static Losango CriaLosango()
        {
            double diagonalMaior = GetDouble("Insira o valor da diagonal maior do losango: ");
            double diagonalMenor = GetDouble("Insira o valor da diagonal menor do losango: ");
            return new Losango() { DiagonalMaior = diagonalMaior, DiagonalMenor = diagonalMenor };

        }

        private static Trapezio CriaTrapezio()
        {
            double bsMaior = GetDouble("Insira o valor da base maior do trapézio: ");
            double bsMenor = GetDouble("Insira o valor da base menor do trapézio: ");
            double altura = GetDouble("Insira o valor da altura do trapézio: ");
            return new Trapezio() { BsMaior = bsMaior, BsMenor = bsMenor , Altura = altura };

        }

    }


    
}