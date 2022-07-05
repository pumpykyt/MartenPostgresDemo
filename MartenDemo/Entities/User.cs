namespace MartenDemo.Entities;

public record User(string Email)
{
    public Guid Id { get; set; }
}