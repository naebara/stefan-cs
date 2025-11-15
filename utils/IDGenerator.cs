public class IDGenerator
{
    private static int carId = 1;

    public static int nextCarId()
    {
        return carId++;
    }
}