using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadorinhaDosGuriBemBOm
{
    class Program
    {
        static void Main(string[] args)
        {
            //IMC//
            Console.Write("Por favor, insira seu peso em KG: ");
            double peso = double.Parse(Console.ReadLine());

            if (peso <= 0)
            {
                Console.WriteLine("Ops! Insira um número maior que 0! ");
                Console.ReadLine();
                return;
            }

            Console.Write("Por favor, insira sua altura em METROS: ");
            double altura = double.Parse(Console.ReadLine());
            if (altura <= 0)
            {
                Console.WriteLine("Ops! Insira um número maior que 0! ");
                Console.ReadLine();
                return;
            }

            double valorDoIMC = peso / (altura * altura);

            if (valorDoIMC < 20)
            {
                Console.WriteLine("\nIMC = " + valorDoIMC + " =  Baixo peso corporal");
            }
            else if ((valorDoIMC >= 20) && (valorDoIMC <= 24))
            {
                Console.WriteLine("\nIMC = " + valorDoIMC + " =  Peso corporal normal (adequado)");
            }
            else if ((valorDoIMC >= 25) && (valorDoIMC <= 29))
            {
                Console.WriteLine("\nIMC = " + valorDoIMC + " =  Peso corporal acima da média ");
            }
            else if ((valorDoIMC >= 30) && (valorDoIMC <= 34))
            {
                Console.WriteLine("\nIMC = " + valorDoIMC + " =  Obesidade Classe I ");
            }
            else if ((valorDoIMC >= 35) && (valorDoIMC <= 39))
            {
                Console.WriteLine("\nIMC = " + valorDoIMC + " =  Obesidade Classe II ");
            }
            if (valorDoIMC >= 40)
            {
                Console.WriteLine("\nIMC = " + valorDoIMC + " =  Obesidade Classe III ");
            }
            //ÁGUA//
            Console.WriteLine("Certo, agora vamos ver quanto de água você precisa ingerir ao dia!");

            if (peso <= 0)
            {
                Console.WriteLine("Ops! Insira um número maior que 0! ");
                Console.ReadLine();
                return;
            }

            double calculaAgua = peso * 35;

            if (peso > 1)
            {
                Console.WriteLine(calculaAgua + "ml de água por dia!");
            }
            Console.ReadKey();
        }
    }
}