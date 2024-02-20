using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Hacer un programa para ingresar 10 números. 
            //El mismo deb,e analizar y mostrar por pantalla cuántos de esos números son primos.
            int n, confinal = 0;
            
            for (int x = 0; x < 10; x++)
            {
                int con = 0;
                Console.WriteLine("Escriba un nro: ");
                n = int.Parse(Console.ReadLine());
                for (int y = 1; y <= n; y++)
                {
                    if (n % y == 0)
                        con++;
                }
                    if (con == 2)
                        confinal++;
            }
                    Console.WriteLine("La cantidad de nros primos es: " + confinal);
                
        }
    }
}
