using let_no_LINQ.models;


var orders = new List<Order>
{
    new("20 itens", GeraItens(20)),
    new("15 itens ", GeraItens(15)),
    new("60 itens", GeraItens(60)),
    new("50 itens", GeraItens(50))
};

List<OrderLine> GeraItens(int quantity)
{
    var result = new List<OrderLine>();
    for (var i = 0; i < quantity; i++)
        result.Add(new OrderLine($"Produto gerado: {i}", i, i));

    return result;
}


var data =
    from order in orders
    let totalItens = order.OrderLines.Count
    let total = order.OrderLines.Sum(x => x.preco)
    where
        totalItens > 10 &&
        total > 100
    select new
    {
        order.numero,
        total,
        totalItens
    };


foreach (var item in data)
    Console.WriteLine($"Numero: {item.numero}, Total: {item.total}");