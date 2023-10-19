using System;
using System.Collections.Generic;

public class Livro
{
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public int AnoPublicacao { get; set; }
}

public class Biblioteca
{
    private List<Livro> livros = new List<Livro>();

    public void AdicionarLivro(Livro livro)
    {
        livros.Add(livro);
    }

    public void RemoverLivro(Livro livro)
    {
        livros.Remove(livro);
    }
}