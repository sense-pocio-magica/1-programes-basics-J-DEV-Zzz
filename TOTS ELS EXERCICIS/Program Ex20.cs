namespace exercici20;

/* Ens cal un programa que quan li entrem un número de tres xifres i ens retorni 
el número amb els dígits invertits. 

Ex. 245 -> 542
Entra el número a invertir: 347
El número invertit és: 743
*/

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Entra el número a invertir: ");
        var numero = Console.ReadLine(); 
        
        var digits = numero.ToCharArray(); 
        Array.Reverse(digits);
        var numeroInvertit = new string(digits); 

        Console.WriteLine($"El número invertit és: {numeroInvertit}");
    }
}
