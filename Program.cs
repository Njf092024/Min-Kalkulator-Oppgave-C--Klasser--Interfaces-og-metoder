namespace Oppgaver_C__Klasser__Interfaces_og_metoder;

class Program
{
    static void Main(string[] args)
    {
        // Brukeren blir bedt om å velge et tall
        Console.Write("Velg et tall: ");
        string? input1 = Console.ReadLine(); // Gjør om hva enn brukeren valgte av tall om til tekst
        double number1;

        // Prøver å gjøre om teksten til et tall, spesifikt double med tanke på oppgaven
        if (!double.TryParse(input1, out number1))
        {
            // Om omgjøringen feiler så vil det dukke opp en feilmelding som lukker programmet
            Console.WriteLine("Feil resultat! Prøv igjen.");
            return; 
        }

        // brukeren blir igjen bedt om å velge et andre tall
        Console.WriteLine("Velg et andre tall");
        string? input2 = Console.ReadLine(); // Gjør om hva enn brukeren valgte av tall som tekst igjen
        double number2;

        // Prøver igjen å gjøre om teksten til et tall
        if (!double.TryParse(input2, out number2))
        {
            // Igjen så blir det gitt feilmelding om omgjøringen feiler som vil lukke programmet
            Console.WriteLine("Feil resultat! Prøv igjen.");
            return;
        }

        // Her har jeg opprettet en instans av klassen som implementerer ICalculator
        Calculator calculator = new Calculator();

        // Her utfører vi addisjon og subtraksjon med de to tallene som brukeren har skrevet inn
        double sum = calculator.Add(number1, number2); // legger sammen tallene ...
        double difference = calculator.Subtract(number1, number2); // Trekker tallene fra hverandre ...
        
        // Her vil det bli skrevet ut de endelige resultatene til brukeren
        Console.WriteLine($"summen av {number1} og {number2} er: {sum}");
        Console.WriteLine($"Forskjellen mellom {number1} og {number2} er: {difference}");
        }
        }