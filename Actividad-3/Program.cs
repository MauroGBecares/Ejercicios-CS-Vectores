using System;

namespace Actividad_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 3. Hacer un programa que solicite una cadena de caracteres y dos caracteres sueltos (tres ingresos). 
            // El programa deberá generar una cadena donde todas las ocurrencias del primer carácter dado hayan sido reemplazadas por el segundo. Mostrar el resultado en pantalla. 
            // Ejemplo:
            //     CADENA FUENTE: “La mar estaba serena"
            //     CARÁCTER 1: ‘a’ CARÁCTER 2: ‘i’
            //     CADENA RESULTADO: “Li mir estibi sereni"

            char[] frase = new char[21];
            char letra, c1, c2;
            int indice = 0;

            Console.WriteLine("Ingrese una frase o palabra:");
            letra = char.Parse(Console.ReadLine());
            while (letra != '.' && indice < 21)
            {
                frase[indice] = letra;
                letra = char.Parse(Console.ReadLine());
                indice++;            
            }
            frase[indice] = '\0';

            Console.WriteLine("La frase original es: ");
            indice = 0;
            while (frase[indice] != '\0' && indice < 21)
            {
                Console.Write(frase[indice]);
                indice++;
            }
            Console.WriteLine("Ingrese el caracter original:");
            c1 = char.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el caracter que se reemplaza:");
            c2 = char.Parse(Console.ReadLine());
            
            for (int x = 0; x < 21; x++)
            {
                if (frase[x] == c1) 
                    frase[x] = c2;  
            }
            indice = 0;
            while (frase[indice] != '\0' && indice < 21)        
            {
                Console.Write(frase[indice]);
                indice++;
            }

            
        }
    }
}
