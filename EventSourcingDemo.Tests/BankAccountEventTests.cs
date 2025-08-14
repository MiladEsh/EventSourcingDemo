
namespace EventSourcingDemo.Tests;

public class BankAccountEventTests
{
    [Fact]
    public void BankAccount_Open()
    {
        var id = Guid.NewGuid();
        var state = BankAccount.Init(id);
        var result = BankAccountEvents
           .Handle(state, new OpenedAccount(id));
        Assert.True(result.IsOpen);
    }

    [Fact]
    public void BankAccount_Deposit()
    {
        var id = Guid.NewGuid();
        var state = BankAccount.Init(id);
        var result = BankAccountEvents
           .Handle(state, new OpenedAccount(id), new Deposited(id, 100));

        Assert.Equal(100, result.Balance);
    }
}
