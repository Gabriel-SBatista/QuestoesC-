public class Solution
{
    static int[] SequenciaFibonacci(int x)
    {
        int[] sequencia = new int[x];

        for (int i = 0; i < sequencia.Length; i++)
        {
            if (i == 0)
                sequencia[i] = 1;
            else if (i == 1)
                sequencia[i] = 1;
            else
                sequencia[i] = sequencia[i - 2] + sequencia[i - 1];
        }

        return sequencia;
    }
}