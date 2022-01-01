
var customerId = 0;
var customerFaker = new Faker<CustomerModel>()
    .RuleFor(o => o.Id, f => customerId++)
    .RuleFor(o => o.FirstName, f => f.Person.FirstName)
    .RuleFor(o => o.LastName, f => f.Person.LastName)
    .RuleFor(o => o.Email, f => f.Person.Email)
    .RuleFor(o => o.Phone, f => f.Person.Phone)
    .RuleFor(o => o.Addres, f => f.Address.StreetAddress())
    .RuleFor(o => o.City, f => f.Address.City())
    .RuleFor(o => o.ZipCode, f => f.Address.ZipCode())
    .RuleFor(o => o.Country, f => f.Address.Country());

var itemFaker = new Faker<ItemModel>()
    .RuleFor(o => o.Id, Guid.NewGuid)
    .RuleFor(o => o.Name, f => f.Commerce.ProductName())
    .RuleFor(o => o.Color, f => f.Commerce.Color())
    .RuleFor(o => o.Price, f => decimal.Round(f.Random.Decimal(1, 100), 2))
    .RuleFor(o => o.Currency, f => f.Finance.Currency().Code)
    .RuleFor(o => o.Quantity, f => f.Random.Int(1, 10));

var orderId = 0;
var orderFaker = new Faker<OrderModel>()
    .RuleFor(o => o.Id, f => orderId++)
    .RuleFor(o => o.Date, f => f.Date.Recent(7))
    .RuleFor(o => o.Status, f => f.PickRandom<EnumOrderStatus>())
    .RuleFor(o => o.Customer, f => customerFaker.Generate())
    .RuleFor(o => o.Items, f => itemFaker.Generate(f.Random.Int(2, 5)));


Console.WriteLine("How many orders?");
int.TryParse(Console.ReadLine(), out int count);

var orders = orderFaker.Generate(count);
foreach (var order in orders)
{
    var text = JsonSerializer.Serialize(order);
    Console.WriteLine(text);
}

Console.ReadLine();