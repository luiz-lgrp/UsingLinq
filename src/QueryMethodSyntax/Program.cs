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
    new Producto {Id = 7, CategoryId = 2, Name = "Feijao", Status = true, Value = 27},
};

var listCategories = new List<Category>()
{
    new Category{Id = 1, Status = true, Name = "Eletronicos"},
    new Category{Id = 2, Status = true, Name = "Alimentos"},
    new Category{Id = 3, Status = true, Name = "Vestuario"},

};


Console.WriteLine("01 - PRIMEIRO OU PADRAO");
Console.WriteLine("");
var list1 = listProducts.FirstOrDefault();

Console.WriteLine($"NAME: {list1.Name} - ID: {list1.Id}");


Console.WriteLine("");
Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
Console.WriteLine("");




Console.WriteLine("02 - ULTIMO OU PADRAO");
Console.WriteLine("");
var list2 = listProducts.LastOrDefault();

Console.WriteLine($"NAME: {list2.Name} - ID: {list2.Id}");


Console.WriteLine("");
Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
Console.WriteLine("");





Console.WriteLine("03 - PESQUISAR POR UM ARGUMENTO");
Console.WriteLine("");
var list3 = listProducts.SingleOrDefault(x => x.Name == "Camiseta");

Console.WriteLine($"NAME: {list3.Name} - ID: {list3.Id}");


Console.WriteLine("");
Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
Console.WriteLine("");





Console.WriteLine("04 - FILTRANDO COM WHERE");
Console.WriteLine("");
var list4 = listProducts.Where(x => x.Id >= 2 && x.Id <= 5);

foreach (var result in list4)
{
    Console.WriteLine($"ID: {result.Id} - NAME: {result.Name}");
}


Console.WriteLine("");
Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
Console.WriteLine("");




Console.WriteLine("05 - ORDENAR POR ORDEM CRESCENTE");
Console.WriteLine("");
var list5 = listProducts.OrderBy(x => x.Id);

foreach (var result in list5)
{
    Console.WriteLine($"ID: {result.Id} - NAME: {result.Name}");
}



Console.WriteLine("");
Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
Console.WriteLine("");



Console.WriteLine("06 - ORDENAR POR ORDEM DECRESCENTE");
Console.WriteLine("");
var list6 = listProducts.OrderByDescending(x => x.Id);

foreach (var result in list6)
{
    Console.WriteLine($"ID: {result.Id} - NAME: {result.Name}");
}


Console.WriteLine("");
Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
Console.WriteLine("");



Console.WriteLine("07 - REVERTENDO A LISTA ORDENADA");
Console.WriteLine("");
var list7 = listProducts.OrderBy(x => x.Id).Reverse();

foreach (var result in list7)
{
    Console.WriteLine($"ID: {result.Id} - NAME: {result.Name}");
}




Console.WriteLine("");
Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
Console.WriteLine("");



Console.WriteLine("08 - REVERTENDO A LISTA TODA");
Console.WriteLine("");
listProducts.Reverse();

foreach (var result in listProducts)
{
    Console.WriteLine($"ID: {result.Id} - NAME: {result.Name}");
}




Console.WriteLine("");
Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
Console.WriteLine("");



















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