namespace exercici6;

/* Declara una variable per al costat d'un quadrat. Calcula el seu perímetre (suma dels quatre costats) 
i imprimeix-lo. */

class Program
{
    static void Main(string[] args)
    {
        var costat = 10;
        var perimetre = costat * 4;

        Console.WriteLine("El perímetre del quadrat és: " + perimetre);
    }
}
