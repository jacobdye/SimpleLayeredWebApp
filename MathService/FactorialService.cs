namespace MathService;
public class FactorialService
{
    public static int GetFactorialValueOf(int n)
    {
        if (n < 0)
            throw new Exception("No negative!");
        else if (n == 0)
            return 1;
        else
            return n * GetFactorialValueOf(n - 1);
    }

}
