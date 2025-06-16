namespace Aula14;

// For loop example
public class Program {
	public static void Main() {

		// Aula 14, exemplo de for loop e interpolação de strings

		for (int i = 1; i <= 10; i++) {
			for (int j = 1; j <= 10; j++) {
				Console.Write($"{i * j,6}");
			}
			Console.WriteLine();
		}
	}
}