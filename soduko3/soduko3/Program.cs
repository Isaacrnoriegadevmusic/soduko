using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soduko3
{
    class Programa
    {
        static void Main(string[] args)
        {
            int[,] tableroSudoku = new int[9, 9]; 

           

            ImprimirTableroSudoku(tableroSudoku);

            while (!EsSudokuResuelto(tableroSudoku))
            {
                Console.WriteLine("Ingresa la fila (0-8) y columna (0-8) donde deseas colocar un número (ejemplo: 3 4):");
                int fila = int.Parse(Console.ReadLine());
                int columna = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingresa el número que deseas colocar en esa posición:");
                int num = int.Parse(Console.ReadLine());

                if (EsMovimientoValido(tableroSudoku, fila, columna, num))
                {
                    tableroSudoku[fila, columna] = num;
                    Console.WriteLine("Número colocado correctamente.");
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Movimiento inválido. El número ya existe en la fila, columna o región.");
                }

                ImprimirTableroSudoku(tableroSudoku);
            }

            Console.WriteLine("¡Felicidades! Has resuelto el Sudoku.");
            Console.ReadKey();
        }

        static void ImprimirTableroSudoku(int[,] tablero)
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Console.Write(tablero[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        static bool EsMovimientoValido(int[,] tablero, int fila, int columna, int num)
        {
           
            return true; 
        }

        static bool EsSudokuResuelto(int[,] tablero)
        {
           

            return false; 

        }
    }


}
