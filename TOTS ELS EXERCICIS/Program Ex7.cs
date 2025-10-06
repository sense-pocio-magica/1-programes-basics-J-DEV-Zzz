namespace exercici7;

/* Defineix tres variables amb tres notes numèriques. 
Calcula la mitjana i mostra el resultat per pantalla. */ 

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Entra el primer numero:");
        int Num1 = int.Parse(Console.ReadLine());

        Console.Write("Entra el segon numero:");
        int Num2 = int.Parse(Console.ReadLine());

        Console.Write("Entra el tercer numero:");
        int Num3 = int.Parse(Console.ReadLine());

        int Mitjana = (Num1 + Num2 + Num3) / 3;

        Console.WriteLine("La mitjana és: " + Mitjana);
    }
}
