using System;

namespace AreaTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Desenvolver um programa que calcule a área de um triangulo.
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Calcule a área de um triângulo.");
            Console.ResetColor();
            Console.WriteLine();
            double area, baseB,alturaH = 0;
            
            Console.WriteLine("Informe a base do triângulo: ");
            Console.WriteLine();

            baseB = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a altura do triângulo: ");
            Console.WriteLine();
            alturaH = double.Parse(Console.ReadLine());

            area = (baseB * alturaH) /2 ;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Area do Triângulo é : =  {area}");
            Console.ResetColor();

        }
    }
}
