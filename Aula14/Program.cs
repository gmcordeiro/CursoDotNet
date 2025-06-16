namespace Aula14;

// For loop example
public class Program {
	public static void Main() {
		Console.WriteLine("Enter a number between 1 and 5 (or 'exit' to quit):");
		int input = Convert.ToInt32(Console.ReadLine());
		for (int i = 0; i <= input; i++) {
			Console.WriteLine($"Count: {i}");
		}
	}
}