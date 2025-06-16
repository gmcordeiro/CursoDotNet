namespace Aula6;

public class Program {
	public static void Main() {

		// Aula sobre operadores lógicos em C#, IF - Else, Switch e Ternário
		Console.WriteLine("==========Operadores Lógicos em C#==========");

		int continueCheck;

		do {
			isEvenOrOdd();
			Console.WriteLine("Continuar?");
			Console.WriteLine("1 - Sim");
			Console.WriteLine("2 - Não");
			continueCheck = Convert.ToInt32(Console.ReadLine());
		} while (continueCheck != 2);

	}

	private static void isEvenOrOdd() {

		Console.WriteLine("Digite o primeiro numero: ");
		int number = Convert.ToInt32(Console.ReadLine());

		Console.WriteLine("==========IF/Else==========");
		if (number % 2 == 0) {
			Console.WriteLine("O número é par.");
		} else {
			Console.WriteLine("O número é ímpar.");
		}

		Console.WriteLine("==========Switch==========");
		switch (number % 2) {
			case 0:
				Console.WriteLine("O número é par.");
				break;
			default:
				Console.WriteLine("O número é ímpar.");
				break;
		}

		Console.WriteLine("==========Operador Ternário==========");
		string resultado = (number % 2 == 0) ? "O número é par." : "O número é ímpar.";
		Console.WriteLine(resultado);
	}
}