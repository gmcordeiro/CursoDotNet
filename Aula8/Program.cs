namespace Aula8;

public class Program {
	public static void Main() {

		// Aula sobre operadores de comparação em C#, Igualdade e Desigualdade
		Console.WriteLine("==========Operadores de Comparação em C#==========");

		// Inicializando duas variáveis
		int a = 10;
		int b = 20;
		Console.WriteLine($"Valor de a: {a}");
		Console.WriteLine($"Valor de b: {b}");

		// Igualdade (==)
		bool isEqual = (a == b);
		Console.WriteLine("\nAtribuição de igualdade (==)");
		Console.WriteLine($"{a} é igual a {b}? {isEqual}");

		// Desigualdade (!=)
		bool isNotEqual = (a != b);
		Console.WriteLine("\nAtribuição de desigualdade (!=)");
		Console.WriteLine($"{a} é diferente de {b}? {isNotEqual}");

		// Maior que (>)
		bool isGreater = (a > b);
		Console.WriteLine("\nAtribuição de maior que (>)");
		Console.WriteLine($"{a} é maior que {b}? {isGreater}");

		// Menor que (<)
		bool isLess = (a < b);
		Console.WriteLine("\nAtribuição de menor que (<)");
		Console.WriteLine($"{a} é menor que {b}? {isLess}");

		// Maior ou igual a (>=)
		bool isGreaterOrEqual = (a >= b);
		Console.WriteLine("\nAtribuição de maior ou igual a (>=)");
		Console.WriteLine($"{a} é maior ou igual a {b}? {isGreaterOrEqual}");

		// Menor ou igual a (<=)
		bool isLessOrEqual = (a <= b);
		Console.WriteLine("\nAtribuição de menor ou igual a (<=)");
		Console.WriteLine($"{a} é menor ou igual a {b}? {isLessOrEqual}");


	}
}