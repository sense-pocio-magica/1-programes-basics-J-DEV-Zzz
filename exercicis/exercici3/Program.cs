namespace exercici3;

/* Defineix quatre variables per al nom d’un producte, el seu preu 
i si està en estoc o no. Imprimeix la informació de forma clara. */
class Program
{
    static void Main(string[] args)
    {
        var nom ="Pomes"
        double preu = 2.5;
        int quantitat = 30;
        bool enEstoc = true;

        Console.WriteLine("Informació del producte:");
        Console.WriteLine($"Nom: {nom}");
        Console.WriteLine($"Preu: {preu} €");
        Console.WriteLine($"Quantitat disponible: {quantitat}");
        Console.WriteLine($"En estoc: {enEstoc}");
    }
}

