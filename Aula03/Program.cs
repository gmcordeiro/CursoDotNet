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


        /*
         * Conteúdo da aula 3
         */

        // Const
        const int NUMBER = 30;

        // NUMBER = 20; Da erro de compilação, pois NUMBER é uma constante e não pode ser alterada

        Console.WriteLine("valor do número é: " + NUMBER);


        // Var
        var valiable = "Guilherrme M. Cordeiro";

        // var é usado para declarar uma variável cujo tipo é inferido pelo compilador. O Valor precisa ser atribuído no momento da declaração, e o tipo não pode ser alterado posteriormente.
        // valiable = 50; // Isso não é válido, pois var é tipado, porém pelo compilador

        Console.WriteLine("Valor da variável é: " + valiable);

        // Dynamic
        dynamic dynamicVariable = "Guilherme M. Cordeiro";

        // dynamic é usado para declarar uma variável cujo tipo pode ser alterado em tempo de execução
        dynamicVariable = 50; // Isso é válido, pois dynamic permite qualquer tipo de dado

        Console.WriteLine("Valor da variável dinâmica é: " + dynamicVariable);
    }

}