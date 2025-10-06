namespace exercici8;

/* Assigna un nombre total de minuts a una variable. 
Calcula quantes hores senceres i minuts restants són i imprimeix el resultat. */

class Program
{
    static void Main(string[] args)
    {
        int minutstotals = 240;

        int hores = minutstotals / 60;
        int minutsrestants = minutstotals % 60;

        Console.WriteLine("Hores: " + hores + ", Minuts: " + minutsrestants);
    }
}
