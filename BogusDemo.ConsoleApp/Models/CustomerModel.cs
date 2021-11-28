namespace BogusDemo.ConsoleApp.Models;
internal record CustomerModel
{
    public int Id { get; init; }
    public string FirstName { get; init; }
    public string LastName { get; init; }
    public string Email { get; init; }
    public string Phone { get; init; }
    public string Addres { get; init; }
    public string City { get; init; }
    public string ZipCode { get; init; }
    public string Country { get; init; }
}
