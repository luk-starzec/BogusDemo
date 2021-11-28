namespace BogusDemo.ConsoleApp.Models;
internal record OrderModel
{
    public int Id { get; init; }
    public DateTime Date { get; init; }
    public EnumOrderStatus Status { get; init; }
    public CustomerModel Customer { get; init; }
    public List<ItemModel> Items { get; init; }
}
