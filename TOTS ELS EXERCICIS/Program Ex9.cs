namespace exercici9;

/* Demana un valor en metres. Converteix el valor a peus (1 metre = 3,28084 metres) 
i imprimeix el resultat. */

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Entra un valor en metres: ");
        double Metres = double.Parse(Console.ReadLine());

        double Peus = Metres * 3.28084;

        Console.WriteLine($"{Metres} metres són {Peus} peus.");
    }
}
