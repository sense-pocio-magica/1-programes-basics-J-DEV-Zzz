namespace exercici7;

/* Defineix tres variables amb tres notes numèriques. 
Calcula la mitjana i mostra el resultat per pantalla. */ 

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Entra el primer numero:");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Entra el segon numero:");
        int num2 = int.Parse(Console.ReadLine());

        Console.Write("Entra el tercer numero:");
        int num3 = int.Parse(Console.ReadLine());

        int mitjana = (num1 + num2 + num3) / 3;

        Console.WriteLine("La mitjana és: " + mitjana);
    }
}
