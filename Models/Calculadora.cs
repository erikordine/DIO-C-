using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet.Models.Calculadora
{
    public class Calculadora
    {
        public void Somar(int x, int y)
        {
            Console.WriteLine($"A soma de {x} e {y} é {x + y}");
        }
        public void Subtrair(int x, int y)
        {
            Console.WriteLine($"A subtração de {x} e {y} é {x - y}");
        }
        public void Multiplicar(int x, int y)
        {
            Console.WriteLine($"A multiplicação de {x} e {y} é {x * y}");
        }
        public void Dividir(int x, int y)
        {
            if (y == 0)
            {
                Console.WriteLine("Divisão por zero não é permitida.");
            }
            else
            {
                Console.WriteLine($"A divisão de {x} por {y} é {x / y}");
            }
        }
        public void Potencia(int x, int y)
        {
            double resultado = Math.Pow(x, y); // O método Math.Pow calcula a potência
            Console.WriteLine($"A potência de {x} elevado a {y} é {resultado}");
        }

        // Seno, Conseno, Tangente
        public void Seno(double angulo)
        {
            double radiano = angulo * (Math.PI / 180); // Converte graus para radianos
            double seno = Math.Sin(radiano);
            Console.WriteLine($"O seno de {angulo} graus é {seno}");
        }

        public void Coseno(double angulo)
        {
            double radiano = angulo * (Math.PI / 180); // Converte graus para radianos
            double coseno = Math.Cos(radiano);
            Console.WriteLine($"O cosseno de {angulo} graus é {coseno}");
        }

        public void Tangente(double angulo)
        {
            double radiano = angulo * (Math.PI / 180); // Converte graus para radianos
            double tangente = Math.Tan(radiano);
            Console.WriteLine($"A tangente de {angulo} graus é {tangente}");
        }

        public void RaizQuadrada(double x)
        {
            if (x < 0)
            {
                Console.WriteLine("Raiz quadrada de número negativo não é permitida.");
            }
            else
            {
                double resultado = Math.Sqrt(x);
                Console.WriteLine($"A raiz quadrada de {x} é {resultado}");
            }
        }
    }
}