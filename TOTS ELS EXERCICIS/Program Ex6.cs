namespace exercici6;

/* Declara una variable per al costat d'un quadrat. Calcula el seu perímetre (suma dels quatre costats) 
i imprimeix-lo. */

class Program
{
    static void Main(string[] args)
    {
        var Costat = 10;
        var Perimetre = Costat * 4;

        Console.WriteLine("El perímetre del quadrat és: " + Perimetre);
    }
}
