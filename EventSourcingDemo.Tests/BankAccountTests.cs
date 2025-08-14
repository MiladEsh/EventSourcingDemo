
namespace EventSourcingDemo.Tests;

public class BankAccountTests
{
    [Fact]
    public void BankAccount_Creation()
    {
        var id = Guid.NewGuid();
        var bankAccount = BankAccount.Init(id);
        Assert.Equal(0, bankAccount.Balance);
        Assert.Equal(id, bankAccount.Id);
    }

    [Fact]
    public void BankAccount_Creation_From_Command()
    {
        var id = Guid.NewGuid();
        var command = new OpenAccount(id);
        BankAccount bankAccount = BankAccountCommands.Handle(command);
        Assert.Equal(0, bankAccount.Balance);
        Assert.Equal(id, bankAccount.Id);
    }
}

