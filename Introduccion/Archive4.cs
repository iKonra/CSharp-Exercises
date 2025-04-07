// Crea un programa en C# que pregunte al usuario en la primera linea ¿Cómo te llamas?
//  y guarde el nombre en la variable x.

// El programa debe responder en la segunda linea con Encantado de conocerte, x.
using System;

class Ejercicio {
    static void Main(string[] args) {
        
        string x;

        Console.Write("Como te llamas?: ");
        x = Console.ReadLine();
        Console.WriteLine("Encantado de conocerte, " + x);


        }
}
