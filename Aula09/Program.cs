namespace Aula9;

public class Program {
	public static void Main() {

		// Aula 9 - Operadores lógicos
		Console.WriteLine("============Operadores lógicos============");

		bool isLogged = true;
		bool hasAdminAccess = false;

		Console.WriteLine($"Informações do uauário: ");
		Console.WriteLine($"Usuário logado: {isLogged}");
		Console.WriteLine($"Acesso ao painel de administrador: {hasAdminAccess}");

		// Operador lógico AND (&&)
		if (isLogged && hasAdminAccess) {
			Console.WriteLine("Usuário logado e com acesso ao painel de administrador.");
		} else if (isLogged && !hasAdminAccess) {
			Console.WriteLine("Usuário logado, mas sem acesso ao painel de administrador.");
		} else {
			Console.WriteLine("Usuário não está logado.");
		}

	}
}