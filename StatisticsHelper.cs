public static class StatisticsHelper
{
    public static double Square(double number)
    {
        return number * number;
    }

    public static double Average(double a, double b)
    {
        return (a + b) / 2;
    }

    public static double CalculateAverage(int[] values)
    {
        if (values == null || values.Length == 0)
        {
            return 0;
        }

        int sum = 0;

        foreach (int value in values)
        {
            sum += value;
        }

        return (double)sum / values.Length;
    }

    public static int CalculateMax(int[] values)
    {
        if (values == null || values.Length == 0)
        {
            return 0;
        }

        int max = values[0];

        foreach (int value in values)
        {
            if (value > max)
            {
                max = value;
            }
        }

        return max;
    }

    public static int CalculateMin(int[] values)
    {
        if (values == null || values.Length == 0)
        {
            return 0;
        }

        int min = values[0];

        foreach (int value in values)
        {
            if (value < min)
            {
                min = value;
            }
        }

        return min;
    }
}