// Escribe un programa en C# que calcule el resultado de sumar, restar, 
// multiplicar y dividir dos números introducidos por el usuario.

// Además también debería calcular el resto de la división en la última linea.

using System;

class Ejercicio {
    static void Main(string[] args) {

        Console.Write("Cual es el primer numero que quieres ingresar (debe ser entero): ");
        int numero1 = int.Parse(Console.ReadLine());
        Console.Write("Cual es el segundo numero que quieres ingresar (debe ser entero): ");
        int numero2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Suma: " + (numero1+numero2));
        Console.WriteLine("Restar: " + (numero1-numero2));
        Console.WriteLine("Multiplicacion: " + (numero1*numero2));
        Console.WriteLine("Division: " + (numero1/numero2));
        
        }
}
