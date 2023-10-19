public class ItemBiblioteca
{
    public string Titulo { get; set; }
    public int AnoPublicacao { get; set; }
}

public class Livro : ItemBiblioteca
{
    public string Autor { get; set; }
    public int NumeroPaginas { get; set; }
}

public class Revista : ItemBiblioteca
{
    public int NumeroEdicao { get; set; }
}