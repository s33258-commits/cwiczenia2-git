Console.Write("Podaj liczbę: ");
string? input = Console.ReadLine();

double number = Convert.ToDouble(input);
double result = StatisticsHelper.Square(number);

Console.WriteLine($"Kwadrat liczby {number} = {result}");