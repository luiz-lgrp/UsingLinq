// FONTE DE DADOS
var listProducts = new List<Producto>()
{
    new Producto {Id = 9, CategoryId = 2, Name = "Geladeira", Status = true, Value = 1522},
    new Producto {Id = 2, CategoryId = 3, Name = "Short", Status = true, Value = 130},
    new Producto {Id = 4, CategoryId = 1, Name = "Maquina de lavar", Status = false, Value = 2780},
    new Producto {Id = 3, CategoryId = 1, Name = "Video Game", Status = true, Value = 3510},
    new Producto {Id = 6, CategoryId = 2, Name = "Arroz", Status = true, Value = 45},
    new Producto {Id = 8, CategoryId = 1, Name = "TV", Status = true, Value = 4500},
    new Producto {Id = 1, CategoryId = 3, Name = "Camiseta", Status = true, Value = 100},
    new Producto {Id = 5, CategoryId = 1, Name = "Microondas", Status = true, Value = 780},
    new Producto {Id = 7, CategoryId = 2, Name = "Feijão", Status = true, Value = 27},
};

var listCategories = new List<Category>()
{
    new Category{Id = 1, Status = true, Name = "Eletronicos"},
    new Category{Id = 2, Status = true, Name = "Alimentos"},
    new Category{Id = 3, Status = true, Name = "Vestuario"},

};

////EXEMPLO
////1° PASSO: CRIAR CONSULTA LINQ

//var list1 = from product in listProducts
//                select product;

////2° PASSO: EXECUTAR A CONSULTA

//foreach (var result in list1)
//{
//    Console.WriteLine($"Id: {result.Id} | Name: {result.Name} | Value: {result.Value}");
//}



Console.WriteLine("01 - FILTRAR POR NOME");
Console.WriteLine("");
var list1 = from product in listProducts
                where product.Name.ToLower() == "Arroz".ToLower()
                select product;

foreach (var result in list1)
{
    Console.WriteLine($"Name: {result.Name} | Value: {result.Value}");
}

Console.WriteLine("");
Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
Console.WriteLine("");


Console.WriteLine("02 - FILTRAR PELO INICIO DA LETRA");
Console.WriteLine("");
var list2 = from product in listProducts
                where product.Name.ToLower().Substring(0, 1) == "M".ToLower()
                select product;

foreach (var result in list2)
{
    Console.WriteLine($"Name: {result.Name} | Value: {result.Value}");
}

Console.WriteLine("");
Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
Console.WriteLine("");


Console.WriteLine("03 - FILTRAR PELA PRIMEIRA LETRA E STATUS");
Console.WriteLine(""); 
var list3 = from product in listProducts
                where product.Name.ToLower().Substring(0, 1) == "M".ToLower() && product.Status != true
                select product;

foreach (var result in list3)
{
    Console.WriteLine($"Name: {result.Name} | Status: {result.Status}");
}

Console.WriteLine("");
Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
Console.WriteLine("");


Console.WriteLine("04 - ORDENAR POR ID DECRESCENTE");
Console.WriteLine(""); 
var list4 = from product in listProducts
                orderby product.Id descending
                select product;

foreach (var result in list4)
{
    Console.WriteLine($"Id: {result.Id} | Name: {result.Name} | Value: {result.Value}");
}

Console.WriteLine("");
Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
Console.WriteLine("");


Console.WriteLine("05 - SOMENTE PRODUTOS ENTRE DETERMINADOS VALORES");
Console.WriteLine(""); 
var list5 = from product in listProducts
                where product.Value > 500 && product.Value < 4000
                select product;

foreach (var result in list5)
{
    Console.WriteLine($" Name: {result.Name} | Value: {result.Value}");
}

Console.WriteLine("");
Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
Console.WriteLine("");


Console.WriteLine("06 - RETORNANDO NOME E VALOR USANDO OBJETO ANONIMO");
Console.WriteLine(""); 
var list6 = from product in listProducts
                select new { product.Name, product.Value };

foreach (var result in list6)
{
    Console.WriteLine($" Name: {result.Name} | Value: {result.Value}");
}

Console.WriteLine("");
Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
Console.WriteLine("");


Console.WriteLine("07 - RETORNANDO NOME E VALOR USANDO OUTRA CLASSE");
Console.WriteLine(""); 
//DESSE JEITO POSSO FAZER OPERAÇÕES MATEMATICAS
var list7 = from product in listProducts
                select new ProductoDto
                {
                    Name = product.Name,
                    Value = product.Value + 20
                };

foreach (var result in list7)
{
    Console.WriteLine($" Name: {result.Name} | Value: {result.Value}");
}

Console.WriteLine("");
Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
Console.WriteLine("");


Console.WriteLine("08 - AGRUPAMENTOS POR CATEGORIA");
Console.WriteLine("");
var list8 = from product in listProducts
                group product by product.CategoryId into prodAgrupados
                select prodAgrupados;

foreach (var result in list8)
{
    Console.WriteLine("");
    Console.WriteLine($"Group: {result.Key}");
    Console.WriteLine("");
    foreach (var product in result)
    {
        Console.WriteLine($" Producto: {product.Name} | Category: {product.CategoryId}");
    }

}

Console.WriteLine("");
Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
Console.WriteLine("");

Console.WriteLine("09 - RETORNANDO NOME DO PRODUTO E NOME DA CATEGORIA");
Console.WriteLine("");
var list9
    = from product in listProducts
                 join cat in listCategories
                 on product.CategoryId equals cat.Id
                 select new
                 {
                     Product = product,
                     Category = cat
                 };

    foreach (var product in list9)
    {
        Console.WriteLine($" Producto: {product.Product.Name} | Category: {product.Category.Name}");
    };




class Producto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public bool Status { get; set; }
    public decimal Value { get; set; }
    public int CategoryId { get; set; }

}

class Category
{
    public int Id { get; set; }
    public string Name { get; set; }
    public bool Status { get; set; }

}

class ProductoDto
{
  
    public string Name { get; set; }
    public decimal Value { get; set; }

}