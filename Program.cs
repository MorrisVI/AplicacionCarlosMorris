using System;

namespace Batalla_Naval_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
                    int[,] tablero = new int[10, 10];

                    Console.WriteLine("Jugador 1, ya puedes colocar tus barcos:");
                    ColocarBarcos(tablero);

                    Console.Clear();

                    int contadorTiros = 0;

                    while (ContarBarcos(tablero) > 0)
                    {
                        Console.WriteLine("Jugador 2, es tu turno para disparar:");
                        MostrarTablero(tablero);

                        Console.Write("Ingresa la fila (1-10): ");
                        int fila = int.Parse(Console.ReadLine()) - 1;
                        Console.Write("Ingresa la columna (1-10): ");
                        int columna = int.Parse(Console.ReadLine()) - 1;

                        if (tablero[fila, columna] == 1)
                        {
                            Console.WriteLine("Barco hundido");
                            tablero[fila, columna] = 2;
                        }
                        else
                        {
                            Console.WriteLine("Agua...");
                        }

                        contadorTiros++;
                    }

                    Console.WriteLine("¡Ganaste gg en " + contadorTiros + " tiros!");
        }

                static void ColocarBarcos(int[,] tablero)
                {
                    ColocarBarco(tablero, 4);

                    ColocarBarco(tablero, 3);
                    ColocarBarco(tablero, 3);

                    ColocarBarco(tablero, 2);
                    ColocarBarco(tablero, 2);
                }

                static void ColocarBarco(int[,] tablero, int tamano)
                {
                    
                    Console.Write("Ingresa la fila inicial del barco de tamaño " + tamano + " (1-10): ");
                    int fila = int.Parse(Console.ReadLine()) - 1;
                    Console.Write("Ingresa la columna inicial del barco de tamaño " + tamano + " (1-10): ");
                    int columna = int.Parse(Console.ReadLine()) - 1;

                    
                    Console.Write("Ingresa la orientación del barco Horizontal(1) y vertical(0): ");
                    string orientacion = Console.ReadLine();

                    while (orientacion != "h" && orientacion != "v")
                    {
                        Console.WriteLine("Orientación inválida, ingresa Horizontal(1) y vertical(0).");
                        Console.Write("Ingresa la orientación del barco Horizontal(1) y vertical(0): ");
                        orientacion = Console.ReadLine();
                    }
                    if (orientacion == "h")
                    {
                        for (int i = columna; i < columna + tamano; i++)
                        {
                            tablero[fila, i] = 1;
                        }
                    }
                    else
                    {
                        for (int i = fila; i < fila + tamano; i++)
                        {
                            tablero[i, columna] = 1;
                        }
                    }
                }

                static int ContarBarcos(int[,] tablero)
                {
                    int contador = 0;

                    for (int i = 0; i < tablero.GetLength(0); i++)
                    {
                        for (int j = 0; j < tablero.GetLength(1); j++)
                        {
                            if (tablero[i, j] == 1)
                            {
                                contador++;
                            }
                        }
                    }
                    return contador;
                }

                static void MostrarTablero(int[,] tablero)
                {
                    Console.WriteLine("   1 2 3 4 5 6 7 8 9 10");
                    Console.WriteLine("  ---------------------");
                    for (int i = 0; i < tablero.GetLength(0); i++)
                    {
                        Console.Write((i + 1) + "| ");
                        for (int j = 0; j < tablero.GetLength(1); j++)
                        {
                            if (tablero[i, j] == 0 || tablero[i, j] == 1)
                            {
                                Console.Write("  ");
                            }
                            else if (tablero[i, j] == 2)
                            {
                                Console.Write("X ");
                            }
                            else if (tablero[i, j] == 3)
                            {
                                Console.Write("O ");
                            }
                        }
                        Console.WriteLine("|");
                    }
                    Console.WriteLine("  -------------------------------------");
                }
    }
}

