namespace Aula7;

public class Program {
	public static void Main() {
		// Aula sobre operadores de atribuição em C#, Incremento e Decremento

		Console.WriteLine("==========Operadores de Atribuição em C#==========");

		// Inicializando uma variável
		int number = 10;
		Console.WriteLine($"Valor inicial da variável é: {number}");

		// Atribuição simples
		number = 20;
		Console.WriteLine("\nAtribuição simples (=)");
		Console.WriteLine($"Valor depois da atribuição simples: {number}");

		// Atribuição composta de adição (++)
		number++;
		Console.WriteLine("\nAtribuição composta de adição (++)");
		Console.WriteLine($"Valor depois da atribuição composta de adição: {number}");

		// Atribuição composta de subtração (--)
		number--;
		Console.WriteLine("\nAtribuição composta de subtração (--)");
		Console.WriteLine($"Valor depois da atribuição composta de subtração: {number}");

		// Atribuição composta (+=)
		number += 5;
		Console.WriteLine("\nAtribuição composta (+=)");
		Console.WriteLine($"Valor depois da atribuição composta de adição: {number}");

		// Atribuição composta (-=)
		number -= 3;
		Console.WriteLine("\nAtribuição composta (-=)");
		Console.WriteLine($"Valor depois da atribuição composta de subtração: {number}");

		// Atribuição composta (*=)
		number *= 2;
		Console.WriteLine("\nAtribuição composta (*=)");
		Console.WriteLine($"Valor depois da atribuição composta de multiplicação: {number}");

		// Atribuição composta (/=)
		number /= 4;
		Console.WriteLine("\nAtribuição composta (/=)");
		Console.WriteLine($"Valor depois da atribuição composta de divisão: {number}");
	}
}