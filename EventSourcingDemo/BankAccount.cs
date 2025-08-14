namespace EventSourcingDemo;

public record BankAccount
{
    private BankAccount(Guid id)
    {
        Id = id;
    }

    public static BankAccount Init(Guid id)
    {
        return new BankAccount(id);
    }
    public int Balance { get; }
    public Guid Id { get; }
}