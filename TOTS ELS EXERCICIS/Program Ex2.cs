namespace exercici2;

/* Declara variables per emmagatzemar l’adreça d’una persona: 
carrer, número, codi postal i població. Imprimeix el resultat 
en una sola línia */

class Program
{
    static void Main(string[] args)
    {
        var carrer = "C/Cataluña";
        int numero = 25 ;
        int codiPostal = 17469 ;
        var poblacio = "Vilamalla" ;

        Console.WriteLine($"{carrer} {numero}, {codiPostal} {poblacio}");
    }
}
