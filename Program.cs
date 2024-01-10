using System;

namespace TPFinal_MartinezAsensio
{
    class Program
    {
        static void Main(string[] args)
        {
            // CONSIGNA
            // Hacer un programa que permita ingresar una lista de números que corta cuando se ingresa un cero. A partir de dichos datos informar:
            // a. El mayor de los números pares.
            // b. La cantidad de números impares.
            // c. El menor de los números primos.

            // Nota: evaluar el uso de una función que analice si un número dado es primo o no y que devuelva true o false según corresponda.

            // DECLARACION, INGRESO DE DATOS Y ASIGNACIÓN INICIAL
            int num, maxPar = 0, contImpar = 0, menorPrimo = 0;
            bool banderaPar = false, banderaPrimo = false;

            Console.WriteLine("Ingresa números para verificar el mayor de los pares, la cantidad de números impares y el menor de los primos. Ingresa el primer número a evaluar: ");
            num = int.Parse(Console.ReadLine());

            // PROCESAMIENTO
            while(num != 0){
                if(esPar(num)){
                    if(!banderaPar){
                        maxPar = num;
                        banderaPar = true;
                    } else {
                        if(num > maxPar)
                            maxPar = num;
                    }
                }

                if(!esPar(num)){
                    contImpar++;
                }

                if(esPrimo(num)){
                    if(!banderaPrimo){
                        menorPrimo = num;
                        banderaPrimo = true;
                    } else {
                        if(num < menorPrimo)
                            menorPrimo = num;
                    }
                }

                Console.WriteLine("Ingresa otro número a evaluar ó 0 para terminar el programa.");
                num = int.Parse(Console.ReadLine());
            }

            // MOSTRAR INFORMACIÓN RESULTANTE
            if(banderaPar)
                Console.WriteLine("El máximo de los pares es: " + maxPar);
            else 
                Console.WriteLine("No se ingresaron números pares.");
            
            Console.WriteLine("La cantidad de impares es: " + contImpar);

            if(banderaPrimo)
                Console.WriteLine("El menor de los primos es: " + menorPrimo);
            else
                Console.WriteLine("No se ingresan números primos.");
        }

        // FUNCIONES
        static bool esPar(int a){
            if(a % 2 == 0){
                return true;
            } else {
                return false;
            }
        }

        static bool esPrimo(int a){
            int cont = 0;

            for (int x = 1; x <= a; x++)
            {
                if(a % x == 0)
                    cont++;
            }

            if(cont == 2)
                return true;
            else
                return false;
        }
    }
}
