namespace Aula3;

public class Program
{
    public static void Main()
    {
        // Aula de constantes, valores imutáveis e tipos de dados primitivos
        const string MY_NAME = "Guilherme M. Cordeiro";
        IFormatProvider culture = new System.Globalization.CultureInfo("pt-BR", true);

        const string BIRTH = "1996/02/15";

        // DateTime.Parse é usado para converter uma string em um objeto DateTime, mas não pode ser constante
        DateTime myBirthday = DateTime.Parse(BIRTH, culture);

        Console.WriteLine($"Nome: {MY_NAME}, Aniversário: {myBirthday}");


        // Conteúdo da aula
        const int NUMBER = 30;

        // NUMBER = 20; Da erro de compilação, pois NUMBER é uma constante e não pode ser alterada

        Console.WriteLine("Número é: " + NUMBER);
    }

}