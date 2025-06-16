namespace Aula13;

public class Program {
	public static void Main() {
		Console.WriteLine("Enter a number between 1 and 5 (or 'exit' to quit):");
		string? input;
		do {
			input = Console.ReadLine();
			if (input?.ToLower() == "exit") break;
			int number = input switch {
				"1" => 1,
				"2" => 2,
				"3" => 3,
				"4" => 4,
				"5" => 5,
				_ => LogInvalidValue()
			};
			Console.WriteLine($"You entered: {number}");
			Console.WriteLine("Enter another number between 1 and 5 (or 'exit' to quit):");
		} while (true);
	}
	private static int LogInvalidValue() {
		Console.WriteLine("Invalid number!");
		return 0;
	}
}