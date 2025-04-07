// La escala Celsius es centígrada, 100 divisiones separan el punto de congelación del punto de ebullición del agua.
//  En la escala Fahrenheit de los anglosajones, estos dos puntos están separados por 180 grados.
//  La escala de Kelvin es una escala absoluta utilizada en ciencias.

// Cree un programa en C# para convertir de grados centígrados a Kelvin y Fahrenheit.
//  Solicite al usuario la cantidad de grados centígrados para convertirlos usando las siguientes tablas de conversión:

// kelvin = celsius + 273
// fahrenheit = celsius x 18/10 + 32

using System;
public class CalculadoraKyF
{
    public static void Main(string[] args) {
        Console.Write("Cuantos grados quiere convertir: ");
        float grados = float.Parse(Console.ReadLine());

        Console.WriteLine("Kelvin: " + (grados + 273));
        Console.WriteLine("Fahrenheit: " + (grados * 18/10 + 32));
        
}
}
