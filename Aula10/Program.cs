namespace Aula10;

public class Program {
	public static void Main() {

		// Aula 10 - Calculadora Simples
		Console.WriteLine("============Calculadora Simples============");

		bool run;
		do {
			calculate();
			Console.WriteLine("\nDeseja realizar outra operação? (S/n)");
			string response = Console.ReadLine() ?? string.Empty;
			run = !response.Equals("n", StringComparison.OrdinalIgnoreCase);
		} while (run);

	}

	private static void calculate() {
		Console.WriteLine("Digite o primeiro número: ");
		double num1 = Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("Digite o segundo número: ");
		double num2 = Convert.ToDouble(Console.ReadLine());

		// Selecione o operador
		Console.WriteLine("\nOpreradores:");
		Console.WriteLine("1. Adição (+);");
		Console.WriteLine("2. Subtração (-);");
		Console.WriteLine("3. Multiplicação (*);");
		Console.WriteLine("4. Divisão (/);");
		Console.WriteLine("Selecione o operador: ");
		int operador = Convert.ToInt32(Console.ReadLine());

		switch (operador) {
			case 1:
				Console.WriteLine($"\nResultado: {num1} + {num2} = {num1 + num2}");
				break;
			case 2:
				Console.WriteLine($"\nResultado: {num1} - {num2} = {num1 - num2}");
				break;
			case 3:
				Console.WriteLine($"\nResultado: {num1} * {num2} = {num1 * num2}");
				break;
			case 4:
				if (num2 != 0) {
					Console.WriteLine($"\nResultado: {num1} / {num2} = {num1 / num2}");
				} else {
					Console.WriteLine("\nErro: Divisão por zero não é permitida.");
				}
				break;
			default:
				Console.WriteLine("\nOperador inválido. Por favor, selecione um operador válido.");
				break;
		}
	}
}