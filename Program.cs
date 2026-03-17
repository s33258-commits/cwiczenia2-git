Console.Write("Podaj pierwszą liczbę: ");
string? input1 = Console.ReadLine();

Console.Write("Podaj drugą liczbę: ");
string? input2 = Console.ReadLine();

if (double.TryParse(input1, out double number1) && double.TryParse(input2, out double number2))
{
    double square1 = StatisticsHelper.Square(number1);
    double average = StatisticsHelper.Average(number1, number2);

    Console.WriteLine($"Kwadrat liczby {number1} = {square1}");
    Console.WriteLine($"Średnia liczb {number1} i {number2} = {average}");
}
else
{
    Console.WriteLine("Błąd: podano nieprawidłową liczbę.");
}