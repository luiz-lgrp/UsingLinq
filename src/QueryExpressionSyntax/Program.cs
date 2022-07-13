﻿// FONTE DE DADOS
var listaProdutos = new List<Produto>()
{
    new Produto {Id = 9, CategoriaId = 2, Nome = "Geladeira", Status = true, Valor = 1522},
    new Produto {Id = 2, CategoriaId = 3, Nome = "Short", Status = true, Valor = 130},
    new Produto {Id = 4, CategoriaId = 1, Nome = "Maquina de lavar", Status = false, Valor = 2780},
    new Produto {Id = 3, CategoriaId = 1, Nome = "Video Game", Status = true, Valor = 3510},
    new Produto {Id = 6, CategoriaId = 2, Nome = "Arroz", Status = true, Valor = 45},
    new Produto {Id = 8, CategoriaId = 1, Nome = "TV", Status = true, Valor = 4500},
    new Produto {Id = 1, CategoriaId = 3, Nome = "Camiseta", Status = true, Valor = 100},
    new Produto {Id = 5, CategoriaId = 1, Nome = "Microondas", Status = true, Valor = 780},
    new Produto {Id = 7, CategoriaId = 2, Nome = "Feijão", Status = true, Valor = 27},
};

var listaCategorias = new List<Categoria>()
{
    new Categoria{Id = 1, Status = true, Nome = "Eletronicos"},
    new Categoria{Id = 2, Status = true, Nome = "Alimentos"},
    new Categoria{Id = 3, Status = true, Nome = "Vestuario"},

};

////EXEMPLO
////1° PASSO: CRIAR CONSULTA LINQ

//var resultado = from produto in listaProdutos
//                select produto;

////2° PASSO: EXECUTAR A CONSULTA

//foreach (var result in resultado)
//{
//    Console.WriteLine($"Id: {result.Id} | Nome: {result.Nome} | Valor: {result.Valor}");
//}



Console.WriteLine("01 - FILTRAR POR NOME");
Console.WriteLine("");
var resultado = from produto in listaProdutos
                where produto.Nome.ToLower() == "Arroz".ToLower()
                select produto;

foreach (var result in resultado)
{
    Console.WriteLine($"Nome: {result.Nome} | Valor: {result.Valor}");
}

Console.WriteLine("");
Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
Console.WriteLine("");


Console.WriteLine("02 - FILTRAR PELO INICIO DA LETRA");
Console.WriteLine("");
var resultado2 = from produto in listaProdutos
                where produto.Nome.ToLower().Substring(0, 1) == "M".ToLower()
                select produto;

foreach (var result in resultado2)
{
    Console.WriteLine($"Nome: {result.Nome} | Valor: {result.Valor}");
}

Console.WriteLine("");
Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
Console.WriteLine("");


Console.WriteLine("03 - FILTRAR PELA PRIMEIRA LETRA E STATUS");
Console.WriteLine(""); 
var resultado3 = from produto in listaProdutos
                where produto.Nome.ToLower().Substring(0, 1) == "M".ToLower() && produto.Status != true
                select produto;

foreach (var result in resultado3)
{
    Console.WriteLine($"Nome: {result.Nome} | Status: {result.Status}");
}

Console.WriteLine("");
Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
Console.WriteLine("");


Console.WriteLine("04 - ORDENAR POR ID DECRESCENTE");
Console.WriteLine(""); 
var resultado4 = from produto in listaProdutos
                orderby produto.Id descending
                select produto;

foreach (var result in resultado4)
{
    Console.WriteLine($"Id: {result.Id} | Nome: {result.Nome} | Valor: {result.Valor}");
}

Console.WriteLine("");
Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
Console.WriteLine("");


Console.WriteLine("05 - SOMENTE PRODUTOS ENTRE DETERMINADOS VALORES");
Console.WriteLine(""); 
var resultado5 = from produto in listaProdutos
                where produto.Valor > 500 && produto.Valor < 4000
                select produto;

foreach (var result in resultado5)
{
    Console.WriteLine($" Nome: {result.Nome} | Valor: {result.Valor}");
}

Console.WriteLine("");
Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
Console.WriteLine("");


Console.WriteLine("06 - RETORNANDO NOME E VALOR USANDO OBJETO ANONIMO");
Console.WriteLine(""); 
var resultado6 = from produto in listaProdutos
                select new { produto.Nome, produto.Valor };

foreach (var result in resultado6)
{
    Console.WriteLine($" Nome: {result.Nome} | Valor: {result.Valor}");
}

Console.WriteLine("");
Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
Console.WriteLine("");


Console.WriteLine("07 - RETORNANDO NOME E VALOR USANDO OUTRA CLASSE");
Console.WriteLine(""); 
//DESSE JEITO POSSO FAZER OPERAÇÕES MATEMATICAS
var resultado7 = from produto in listaProdutos
                select new ProdutoDto
                {
                    Nome = produto.Nome,
                    Valor = produto.Valor + 20
                };

foreach (var result in resultado7)
{
    Console.WriteLine($" Nome: {result.Nome} | Valor: {result.Valor}");
}

Console.WriteLine("");
Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
Console.WriteLine("");


Console.WriteLine("08 - AGRUPAMENTOS POR CATEGORIA");
Console.WriteLine("");
var resultado8 = from produto in listaProdutos
                group produto by produto.CategoriaId into prodAgrupados
                select prodAgrupados;

foreach (var result in resultado8)
{
    Console.WriteLine("");
    Console.WriteLine($"Grupo: {result.Key}");
    Console.WriteLine("");
    foreach (var produto in result)
    {
        Console.WriteLine($" Produto: {produto.Nome} | Categoria: {produto.CategoriaId}");
    }

}

Console.WriteLine("");
Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
Console.WriteLine("");

Console.WriteLine("09 - RETORNANDO NOME DO PRODUTO E NOME DA CATEGORIA");
Console.WriteLine("");
var resultado9 = from produto in listaProdutos
                 join cat in listaCategorias
                 on produto.CategoriaId equals cat.Id
                 select new
                 {
                     Produto = produto,
                     Categoria = cat
                 };

    foreach (var produto in resultado9)
    {
        Console.WriteLine($" Produto: {produto.Produto.Nome} | Categoria: {produto.Categoria.Nome}");
    };




class Produto
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public bool Status { get; set; }
    public decimal Valor { get; set; }
    public int CategoriaId { get; set; }

}

class Categoria
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public bool Status { get; set; }

}

class ProdutoDto
{
  
    public string Nome { get; set; }
    public decimal Valor { get; set; }

}