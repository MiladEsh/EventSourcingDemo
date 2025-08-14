namespace EventSourcingDemo;

public record BankAccount
{
    private BankAccount(Guid id) { Id = id; }
    public static BankAccount Init(Guid id) => new BankAccount(id);
    public int Balance { get; init; }
    public Guid Id { get; }
    public bool IsOpen { get; init; }
}
