namespace exercici11;

// A partir de dues variables (nom d'usuari i domini), crea i imprimeix una adreça de correu electrònic completa.
class Program
{
    static void Main(string[] args)
    {
        var nomUsu = "jcabrera";
        var domini = "@cendrassos.net";

        var correu = nomUsu + domini;
        Console.WriteLine($"Aquest és el teu correu: {correu}");
    }
}
