using System;

namespace Actividad_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // 4. Una empresa comercializa 15 tipos de artículos y por cada venta realizada genera un registro con los siguientes datos:
            //     - Número de Artículo (1 a 15)
            //     - Cantidad Vendida 

            //     Puede haber varios registros para el mismo artículo y el último se indica con número de artículo igual a 0.
            //     Se pide determinar e informar:
            //     a) El número de artículo que más se vendió en total.
            //     b) Los números de artículos que no registraron ventas.
            //     c) Cuantas unidades se vendieron del número de artículo 10.

            int[] vAcu = new int[15];
            int nArt, CanV, art, max;
            for (int x = 0; x < 15; x++)
            {
                vAcu[x] = 0;
            }
            Console.WriteLine("Ingrese el numero de articulo");
            nArt = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad vendida:");
            CanV = int.Parse(Console.ReadLine());

            while (nArt != 0)
            {
                vAcu[nArt - 1] += CanV;
                Console.WriteLine("Ingrese el numero de articulo");
                nArt = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la cantidad vendida:");
                CanV = int.Parse(Console.ReadLine());
            }
            max = vAcu[0];
            art = 1;
            for (int x = 0; x < 15; x++)
            {
                if (vAcu[x] > max)
                {
                    max = vAcu[x];
                    art = x + 1;
                }
            }
            Console.WriteLine("El numero de articulo " + art + " con una cantidad de " + max + " es el mas vendido");
            Console.WriteLine("Los articulo que no se registraron ventas son:");
            for (int x = 0; x < 15; x++)
            {
                if (vAcu[x] == 0)
                {
                    Console.WriteLine(x + 1);
                }
            }
            Console.WriteLine("En el articulo Nro 10 se vendieron " + vAcu[9] + " cantidad de productos");
            
        }
    }
}
