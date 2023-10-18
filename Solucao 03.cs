public class Solution
{
    public static int SomaPares(int[] array)
    {
        int somaPares;

        foreach (int i in array)
        {
            if (i % 2 == 0)
                somaPares += i;
        }

        return somaPares;
    }

    public static int SomaImpares(int[] array)
    {
        int somaImpares;

        foreach (int i in array)
        {
            if (i % 2 == 1)
                somaImpares += i;
        }

        return somaImpares;
    }
}