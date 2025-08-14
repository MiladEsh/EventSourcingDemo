
namespace EventSourcingDemo.Tests;

public class BankAccountCommandTests
{
    [Fact]
    public void BankAccount_Initial_State()
    {
        var id = Guid.NewGuid();
        var bankAccount = BankAccount.Init(id);
        Assert.Equal(0, bankAccount.Balance);
        Assert.Equal(id, bankAccount.Id);
    }

    [Fact]
    public void BankAccount_Open()
    {
        var id = Guid.NewGuid();
        var state = BankAccount.Init(id);

        IEvent evt = BankAccountCommands
            .Handle(state, new OpenAccount(id));

        var openedAccount = Assert.IsType<OpenedAccount>(evt);
        Assert.Equal(id, openedAccount.Id);
    }

    [Fact]
    public void BankAccount_Deposit()
    {
        var id = Guid.NewGuid();
        var state = BankAccountEvents
           .Handle(BankAccount.Init(id), new OpenedAccount(id));

        IEvent evt = BankAccountCommands
            .Handle(state, new Deposit(id, 100));

        var deposited = Assert.IsType<Deposited>(evt);
        Assert.Equal(id, deposited.Id);
        Assert.Equal(100, deposited.Amount);
    }
}

