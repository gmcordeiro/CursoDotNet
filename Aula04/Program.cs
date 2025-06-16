namespace Aula4;

public class Program
{
    public static void Main(string[] args)
    {
        /*
         * Aula sobre INPUT e OUTPUT
         */

        Console.WriteLine("----------------FORM----------------");

        Console.WriteLine("Digite o seu nome: ");
        string? name = Console.ReadLine();

        Console.WriteLine("Digite a sua idade: ");
        int ageInput = Convert.ToInt32(Console.ReadLine() ?? "0");

        Console.WriteLine($"Olá, {name}!");
        Console.WriteLine($"Sua idade é: {ageInput}");


    }
}