public class Solution
{
    public static Dictionary<char, int> ContaLetra(string frase)
    {
        Dictionary<char, int> contadorLetra = new Dictionary<char, int>();

        foreach (var letra in frase)
        {
            if (letra == " ")
            {
                if (!contadorLetra.ContainsKey(letra))
                {
                    contadorLetra.Add(letra, 1);
                }
                else
                {
                    contadorLetra[letra]++;
                }
            }
                
        }

        return contadorLetra;
    }
}