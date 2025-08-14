
namespace EventSourcingDemo.Tests;

public class BankAccountEventTests
{
    [Fact]
    public void BankAccount_Open()
    {
        var id = Guid.NewGuid();
        var state = BankAccount.Init(id);
        BankAccount result = BankAccountEvents
           .Handle(state, new OpenedAccount(id));
        Assert.True(result.IsOpen);
    }
}
