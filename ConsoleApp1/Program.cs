using System;
using System.Runtime.CompilerServices;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Donde empezara el barco? ingrese la coordenada horizontal(0) y vertical(1)");
            string boatPosition = Console.ReadLine();
            string[] coordinates = boatPosition.Split(',');


            Console.WriteLine("Cual sera la longitud del barco?");
            int varibable1 = (yfilas[0]);
            Console.WriteLine();
            int variable2 = (xcolumnas[1]);
            Console.WriteLine();
          


            int[,] tablero = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            var filas = tablero.GetLength(0);
            var columnas = tablero.GetLength(1);

            var yfilas = 10;
            var xcolumnas = 10;

            for (int i = 0; i < yfilas; i++)
            {
                for (int j = 0; j < xcolumnas; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
