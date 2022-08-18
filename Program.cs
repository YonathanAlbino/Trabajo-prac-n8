using System;

namespace TPFinal_Albino
{
    class Program
    {
        static void Main(string[] args)
        {
// Hacer un programa que permita ingresar una lista de números que corta cuando se ingresa un cero. 
// A partir de dichos datos informar:
// a. El mayor de los números pares.
// b. La cantidad de números impares.
// c. El menor de los números primos.
// Nota: evaluar el uso de una función que analice si un número dado es primo o no y 
// que devuelva true o false según corresponda.



            int numero, parMayor = 0, contadorImpar = 0, menorPrimo = 0;
            bool banderaPar = false, banderaPrimo = false;

            Console.WriteLine("Ingrese un numero:");
            numero = int.Parse(Console.ReadLine());

            while(numero != 0){
                if(numero % 2 == 0 && banderaPar == false){
                    parMayor = numero;
                    banderaPar = true;
                }
                else if(numero % 2 != 0)
                    contadorImpar++;

                if(numero % 2 == 0 && numero > parMayor)
                    parMayor = numero;
                
                //Llamado a la funcion "EsPrimo"
                if(EsPrimo(numero) && banderaPrimo == false){
                    menorPrimo = numero;
                    banderaPrimo = true;
                }
                    else if(EsPrimo(numero) && numero < menorPrimo)
                    menorPrimo = numero;

            Console.WriteLine("Ingrese un numero:");
            numero = int.Parse(Console.ReadLine());

                }

            Console.WriteLine("El mayor de los numeros pares es: "+parMayor);
            Console.WriteLine("La cantidad de numeros impares son de: "+contadorImpar);
            Console.WriteLine("El menor de los numeros primos es el N°: "+menorPrimo);


            }
                        
        static bool EsPrimo(int a){
            int cont = 0;

            for (int i = 1; i <= a; i++)
            {
                if(a % i == 0)
                    cont++;
            }
                if(cont == 2)
                    return true;
                else
                    return false;
        }
    }
}
