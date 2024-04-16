using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese su edad:");

        int edad;

        while (!int.TryParse(Console.ReadLine(), out edad) || edad < 0)
        {
            Console.WriteLine("Edad inválida. Por favor, ingrese un número entero mayor o igual a 0:");
        }

        string tipoDePersona;

        switch (edad)
        {
            case int n when (n >= 0 && n <= 3):
                tipoDePersona = "Recién nacido";
                break;
            case int n when (n >= 4 && n <= 9):
                tipoDePersona = "Infante";
                break;
            case int n when (n >= 10 && n <= 12):
                tipoDePersona = "Puberto";
                break;
            case int n when (n >= 13 && n <= 19):
                tipoDePersona = "Adolescente";
                break;
            case int n when (n >= 20 && n <= 29):
                tipoDePersona = "Joven";
                break;
            case int n when (n >= 30 && n <= 49):
                tipoDePersona = "Adulto";
                break;
            case int n when (n >= 50 && n <= 59):
                tipoDePersona = "Adulto mayor";
                break;
            default:
                tipoDePersona = "Anciano";
                break;
        }

        Console.WriteLine($"Usted es {tipoDePersona}.");
    }
}

