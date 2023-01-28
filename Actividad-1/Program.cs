using System;

namespace Actividad_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Hacer un programa que solicite 10 números enteros y los guarde en un vector. 
            // Luego recorrer los elementos y determinar e informar cuál es el valor máximo y su posición dentro del vector.

            int maxN, pos = 1;
            int[] vnum = new int[10];
            
            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine("Ingrese un nro:");
                vnum[x] = int.Parse(Console.ReadLine());
            }
            maxN = vnum[0]; 
            for (int x = 0; x < 10; x++)
            {
                if (vnum[x] > maxN)
                {
                    maxN = vnum[x];
                    pos = x + 1;
                }
            }
            Console.WriteLine("En la posicion " + pos + " esta el numero maximo que es: " + maxN);

        }
    }
}
