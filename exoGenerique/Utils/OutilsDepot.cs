namespace exoGenerique.Utils;

public static class OutilsDepot
{
    public static void SwapValue<T>(ref T a, ref T b)
    {
        (a, b) = (b, a);
    }

    public static int FindValue<T>(List<T> liste, T value)
    {
        for (int i = 0; i <= liste.Count; i++)
        {
            if (liste[i].Equals(value))
            {
                return i;
            }
        }

        return -1;
    }
}