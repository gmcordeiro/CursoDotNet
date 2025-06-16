namespace Aula5;

public class Program
{
    public static void Main(string[] args)
    {
        // Operadores aritméticos
        Console.WriteLine("==========Operadores Aritméticos em C#==========");
        Console.WriteLine("Digite o primeiro numero: ");
        int number1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite o segundo numero: ");
        int number2 = Convert.ToInt32(Console.ReadLine());

        int sum = number1 + number2; // Suma
        int sub = number1 - number2; // Subtração
        int mul = number1 * number2; // Multiplicação
        int div = number1 / number2; // Divisão
        int mod = number1 % number2; // Módulo (resto da divisão)

        Console.WriteLine($"Suma: {sum}");
        Console.WriteLine($"Subtração: {sub}");
        Console.WriteLine($"Multiplicação: {mul}");
        Console.WriteLine($"Divisão: {div}");
        Console.WriteLine($"Resto: {mod}");
    }
}