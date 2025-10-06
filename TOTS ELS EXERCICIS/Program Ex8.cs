namespace exercici8;

/* Assigna un nombre total de minuts a una variable. 
Calcula quantes hores senceres i minuts restants són i imprimeix el resultat. */

class Program
{
    static void Main(string[] args)
    {
        int Minutstotals = 240;

        int Hores = minutstotals / 60;
        int Minutsrestants = Minutstotals % 60;

        Console.WriteLine("Hores: " + Hores + ", Minuts: " + Minutsrestants);
    }
}
