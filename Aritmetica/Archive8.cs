// Escribe un programa en C# que calcule el resultado de sumar, restar, 
// multiplicar y dividir dos números introducidos por el usuario.

// Además también debería calcular el resto de la división en la última linea.

using System;
public class CaracteresAlReves
{
    public static void Main(string[] args)
    {
        Console.Write("Escribe el primer caracter: "); char primero = Convert.ToChar(Console.ReadLine());
        Console.Write("Escribe el segundo caracter: "); char segundo = Convert.ToChar(Console.ReadLine());
        Console.Write("Escribe el tercer caracter: "); char tercero = Convert.ToChar(Console.ReadLine());

        Console.WriteLine("La nueva palabra es: {0} {1} {2}", tercero, segundo, primero);
        // las {} llamadas placeholders estan vinculadas a las variables luego de la coma del texto y se muestran
        // en esa posicion
}
}
