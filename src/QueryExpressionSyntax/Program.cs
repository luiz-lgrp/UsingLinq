// FONTE DE DADOS
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



// 01 - FILTRAR POR NOME
//var resultado = from produto in listaProdutos
//                where produto.Nome.ToLower() == "Arroz".ToLower()
//                select produto;

//foreach (var result in resultado)
//{
//    Console.WriteLine($"Nome: {result.Nome} | Valor: {result.Valor}");
//}


// 02 - FILTRAR PELO INICIO DA LETRA
//var resultado = from produto in listaProdutos
//                where produto.Nome.ToLower().Substring(0,1) == "M".ToLower()
//                select produto;

//foreach (var result in resultado)
//{
//    Console.WriteLine($"Nome: {result.Nome} | Valor: {result.Valor}");
//}


// 03 - FILTRAR POR PRIMEIRA LETRA E STATUS
//var resultado = from produto in listaProdutos
//                where produto.Nome.ToLower().Substring(0,1) == "M".ToLower() && produto.Status != true
//                select produto;

//foreach (var result in resultado)
//{
//    Console.WriteLine($"Nome: {result.Nome} | Status: {result.Status}");
//}


// 04 - ORDENAR POR ID DECRESCENTE
//var resultado = from produto in listaProdutos
//                orderby produto.Id descending 
//                select produto;

//foreach (var result in resultado)
//{
//    Console.WriteLine($"Id: {result.Id} | Nome: {result.Nome} | Valor: {result.Valor}");
//}



// 05 - SOMENTE PRODUTOS ENTRE DETERMINADOS VALORES
//var resultado = from produto in listaProdutos
//                where produto.Valor > 500 && produto.Valor < 4000
//                select produto;

//foreach (var result in resultado)
//{
//    Console.WriteLine($" Nome: {result.Nome} | Valor: {result.Valor}");
//}



// 06 - AULA 4



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