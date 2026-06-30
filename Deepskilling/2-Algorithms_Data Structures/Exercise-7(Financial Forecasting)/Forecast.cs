public class Forecast
{
    public static double CalculateFutureValue(
        double currentValue,
        double growthRate,
        int year)
    {
        if (year == 0)
        {
            return currentValue;
        }

        return CalculateFutureValue(
            currentValue * (1 + growthRate),
            growthRate,
            year - 1
        );
    }
}