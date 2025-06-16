namespace Aula15;

public class Program {
	public static void Main() {

		// Aula 15, exemplo de foreach loop e interpolação de strings
		List<int> ints = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

		foreach (int number in ints) {
			Console.WriteLine($"Number: {number}");
		}


	}

}