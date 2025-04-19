public final class Utils
{
    public static maxCommonDivider(int n1, int n2)
    {
        n1 = Math.Abs(n1);
        n2 = Math.Abs(n2);
        while (n2 > 0)
        {
            int tmp = n1 % n2;
            n1 = n2;
            n2 = tmp;
        }
        return n1;
    }

    private Utils()
    {
    }
}