using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace Primeiro_exemplo_.NET.Models
{
    public class Calculadora // cria Classe Calculadora, cheia de Métodos (as operações que ela pode fazer)
    {
        public void Somar(int x, int y)
        {
            Console.WriteLine($"{x} + {y} = {x + y}");
        }

        public void Subtrair(int x, int y)
        {
            Console.WriteLine($"{x} - {y} = {x - y}");
        }

        public void Multiplicar(int x, int y)
        {
            Console.WriteLine($"{x} * {y} = {x * y}");
        }

        public void Dividir(int x, int y)
        {
            Console.WriteLine($"{x} / {y} = {x / y}");
        }

        public void Potencia(int x, int y)
        {
            double pot = Math.Pow(x, y);
            Console.WriteLine($"{x} ^ {y} = {pot}");
        }

        public void RaizQuadrada(double x)
        {
            double raizQuadrada = Math.Sqrt(x);
            Console.WriteLine($"A raiz quadrada de {x} = {raizQuadrada}");
        }

        public void Seno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double seno = Math.Sin(radiano);
            Console.WriteLine($"Seno de {angulo}º = {(seno):F4}"); //A classe Math tem a função Round que arredondou o valor em 4 casas decimais. Porém, no caso de sen de 30º, por exemplo, que é 0,5000, ele mostrará apenas 0,5. Então, uma forma diferente de formatar é usar o ':F4', que mostra 4 casas decimais, mesmo que sejam zeros.
        }

        public void Cosseno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double cosseno = Math.Cos(radiano);
            Console.WriteLine($"Cosseno de {angulo}º = {Math.Round(cosseno, 4)}"); // usando apenas o Round
        }

        public void Tangente(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double tangente = Math.Sin(radiano);
            Console.WriteLine($"Tangente de {angulo}º = {Math.Round(tangente, 4):F4}"); // usando as 2 funções
        }
    }
}