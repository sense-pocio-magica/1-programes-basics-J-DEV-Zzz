namespace exercici5;

/* Feu un programa que demani un nom i l’any de naixement i imprimeixi per pantalla 
“Hola [nom]!  Ja tens [edat] anys? 
nom i edat seran el nom introduït i l'edat la resta de l’any actual i l’any de naixement. */

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Introdueix el teu nom: ");
        var Nom = Console.ReadLine();

        Console.Write("Introdueix el teu any de naixement: ");
        var anyNaixement = int.Parse(Console.ReadLine());

        var anyActual = 2025;
        var edat = anyActual - anyNaixement;

        Console.WriteLine($"Hola {Nom}! Ja tens {edat} anys?");
    }
}
