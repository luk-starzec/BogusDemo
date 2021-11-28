namespace BogusDemo.ConsoleApp.Models;
internal record ItemModel
{
    public Guid Id { get; init; }
    public string Name { get; init; }
    public string Color { get; init; }
    public decimal Price { get; init; }
    public string Currency { get; init; }
    public int Quantity { get; init; }
    public decimal TotalPrice => Price * Quantity;
}
