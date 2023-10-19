using System;
using System.Collections.Generic;
using System.Linq;

public class Livro
{
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public int AnoPublicacao { get; set; }
}

public class Biblioteca
{
    private List<Livro> livros = new List<Livro>();


    public List<Livro> ObterLivrosPorAutorOrdenadosPorAno(string autor)
    {
        var query = from livro in livros
                    where livro.Autor == autor
                    orderby livro.AnoPublicacao
                    select livro;

        return query.ToList();
    }
}