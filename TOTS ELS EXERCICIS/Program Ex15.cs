namespace exercici15;

// Assigna un nom i un cognom en variables. Imprimeix el nom complet, 
// assegurant-te que la primera lletra de cada paraula estigui en majúscula
class Program
{
    static void Main(string[] args)
    {
        var nom = "Joel";
        var cognom = "Cabrera";
        
        var nomComplet = nom + " " + cognom;
        
        Console.WriteLine($"Nom complet: " {nomComplet});
    }
}
}

