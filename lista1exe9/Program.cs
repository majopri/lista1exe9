using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista1exe9
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite o diâmetro do circulo:");
            double diametro = Convert.ToDouble(Console.ReadLine());

            double raio = diametro / 2;
            double area = Math.PI * Math.Pow(raio, 2);

            Console.WriteLine($"A area do círculo é: {area}");
        }
    }
}
