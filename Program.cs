using System;

namespace CalculoPitagoras
{
    class Program
    {
        static void Main(string[] args)
        {

            //Algoritmo para calcular a hipotenusa através do teorema de Pitágoras

            Console.Write("Insira a base do triângulo retângulo: ");
            string trianguloretanguloBaseObter = Console.ReadLine();
            float trianguloRetanguloBase = Convert.ToSingle(trianguloretanguloBaseObter);

            Console.Write("Insira a altura do triângulo retângulo: ");
            string trianguloRetanguloAlturaObter = Console.ReadLine();
            float trianguloRetanguloAltura = Convert.ToSingle(trianguloRetanguloAlturaObter);

            double trianguloRetanguloHipotenusa = 0;

            trianguloRetanguloHipotenusa = Math.Sqrt((Math.Pow(trianguloRetanguloBase, 2) + Math.Pow(trianguloRetanguloAltura, 2)));

            Console.WriteLine($"A hipotenusa do triângulo retângulo de {trianguloRetanguloBase} x {trianguloRetanguloAltura} é: {trianguloRetanguloHipotenusa}.");
        }
    }
}
