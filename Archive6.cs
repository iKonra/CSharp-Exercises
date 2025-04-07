// Crea un programa en C# para calcular la superficie y el volumen de una esfera, dado su radio.

// superficie = 4 * pi * radio al cuadrado
// volumen = 4/3 * pi * radio al cubo

using System;

class Ejercicio {
    static void Main(string[] args) {

        Console.Write("Cual es el radio de la esfera: ");
        float radio = float.Parse(Console.ReadLine());


        float superficie = (4.0f * 3.1416f * (radio * radio));
        float volumen = ( (4.0f/3.0f) * 3.1416f * (radio * radio * radio));

        Console.WriteLine("Superficie: " + superficie);
        Console.WriteLine("Volumen: " + volumen);
        
        }
}
