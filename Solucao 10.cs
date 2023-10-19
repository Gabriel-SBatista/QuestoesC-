using System;
using System.Collections.Generic;
using System.Linq;

public class Produto
{
    public string Nome { get; set; }
    public double Preco { get; set; }
}

public class GerenciadorProdutos
{
    public List<Produto> FiltrarProdutosPorPreco(List<Produto> produtos, double precoMinimo)
    {
        return produtos.Where(p => p.Preco > precoMinimo).ToList();
    }
}