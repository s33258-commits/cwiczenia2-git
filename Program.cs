if (double.TryParse(input1, out double number1) && double.TryParse(input2, out double number2))
{
    int[] values = new int[] { (int)number1, (int)number2 };

    double square1 = StatisticsHelper.Square(number1);
    double average = StatisticsHelper.Average(number1, number2);
    double arrayAverage = StatisticsHelper.CalculateAverage(values);
    int maxValue = StatisticsHelper.CalculateMax(values);
    int minValue = StatisticsHelper.CalculateMin(values);

    Console.WriteLine($"Kwadrat liczby {number1} = {square1}");
    Console.WriteLine($"Średnia liczb {number1} i {number2} = {average}");
    Console.WriteLine($"Średnia z tablicy int[] = {arrayAverage}");
    Console.WriteLine($"Maksimum z tablicy int[] = {maxValue}");
    Console.WriteLine($"Minimum z tablicy int[] = {minValue}");
}
else
{
    Console.WriteLine("Błąd: podano nieprawidłową liczbę.");
}