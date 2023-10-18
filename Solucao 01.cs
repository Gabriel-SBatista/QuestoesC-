public class Solution
{
    public static int RealizaFatorial(int a)
    {
        int resultado;

        if (a == 1)
            return 1;
        
        resultado = a * RealizaFatorial(a-1);       

        return resultado;
    }
}