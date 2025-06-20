﻿namespace Aula2;

public class Program
{
    public static void Main()
    {
        // Exemplo de comentário em linha única
        Console.WriteLine("Olá, Mundo!");

        /*
         * Exemplo de comentário em bloco, usado para documentação ou explicações mais longas.
         */
        Console.WriteLine("Bem-vindo ao C#!");

        // Aula sobre variaveis

        string myName = "Guilherme M. Cordeiro";
        IFormatProvider culture = new System.Globalization.CultureInfo("pt-BR", true);
        DateTime myBirthday = DateTime.Parse("15/02/1996", culture);
        Console.WriteLine($"Nome: {myName}, Aniversário: {myBirthday}");
    }
}