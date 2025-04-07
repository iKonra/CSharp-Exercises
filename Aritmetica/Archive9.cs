// Cree un programa en C# que solicite dos números al usuario (x, y) y muestre el resultado de su división.
//Tendrá que controlar la división por 0 con el uso de la excepción DivideByZeroException 
// en un bloque try-catch. Si el usuario intenta dividir por 0 muestre No se puede dividir por 0.

using System;
public class DivisionPorCero
{
    public static void Main(string[] args)
    {
        Console.Write("Primer numero: "); int primero = int.Parse(Console.ReadLine());
        Console.Write("Segundo numero: "); int segundo = int.Parse(Console.ReadLine());
        

    try {
        Console.WriteLine("Si dividimos {0} por {1} da {2}",primero,segundo, primero/segundo);
    }
    catch(DivideByZeroException) {
        Console.WriteLine("No se puede dividir por 0");
    }
}
}
