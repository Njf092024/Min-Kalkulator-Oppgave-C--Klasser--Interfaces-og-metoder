namespace Oppgaver_C__Klasser__Interfaces_og_metoder;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Velg et tall: ");
        string? input1 = Console.ReadLine();
        double number1;
        if (!double.TryParse(input1, out number1))
        {
            Console.WriteLine("Feil resultat! Prøv igjen.");
            return;
        }

        Console.WriteLine("Velg et andre tall");
        string? input2 = Console.ReadLine();
        double number2;
        if (!double.TryParse(input2, out number2))
        {
            Console.WriteLine("Feil resultat! Prøv igjen.");
            return;
        }

        Calculator calculator = new Calculator();
        double sum = calculator.Add(number1, number2);
        double difference = calculator.Subtract(number1, number2);
        
        Console.WriteLine($"summen av {number1} og {number2} er: {sum}");
        Console.WriteLine($"Forskjellen mellom {number1} og {number2} er: {difference}");
        }
        }