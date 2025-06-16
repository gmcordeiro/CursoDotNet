namespace Aula11;

public class Program {
	public static void Main(string[] args) {

		// inline Switch expression example
		Console.WriteLine("Enter a number between 1 and 5:");
		int umber = Console.ReadLine() switch {
			"1" => 1,
			"2" => 2,
			"3" => 3,
			"4" => 4,
			"5" => 5,
			_ => throw new ArgumentException("Invalid number!")
		};

		Console.WriteLine($"You entered: {umber}");

	}
}