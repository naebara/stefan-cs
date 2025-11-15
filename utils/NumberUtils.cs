public class NumberUtils
{
    
    public static int randomInt()
    {
        Random rnd = new Random();
        int nr = rnd.Next(1, 1000000);
        return nr;
    }

}