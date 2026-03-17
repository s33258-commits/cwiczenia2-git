Console.Write("Podaj liczbę: ");
string? input = Console.ReadLine();

if (double.TryParse(input, out double number))
{
    double result = StatisticsHelper.Square(number);
    Console.WriteLine($"Kwadrat liczby {number} = {result}");
}
else
{
    Console.WriteLine("Błąd: podano nieprawidłową liczbę.");
}