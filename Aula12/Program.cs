namespace Aula12;

public class Program {
	public static void Main(string[] args) {

		// While loop example
		Console.WriteLine("Enter a number between 1 and 5 (or 'exit' to quit):");
		string? input = Console.ReadLine();

		while (input?.ToLower() != "exit") {
			int number = input switch {
				"1" => 1,
				"2" => 2,
				"3" => 3,
				"4" => 4,
				"5" => 5,
				_ => logInvalidValue()
			};
			Console.WriteLine($"You entered: {number}");
			Console.WriteLine("Enter another number between 1 and 5 (or 'exit' to quit):");
			input = Console.ReadLine();
		}
	}
	private static int logInvalidValue() {
		Console.WriteLine("Invalid number!");
		return 0;
	}
}