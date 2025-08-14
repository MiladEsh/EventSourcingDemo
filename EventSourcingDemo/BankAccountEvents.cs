
namespace EventSourcingDemo.Tests;

public class BankAccountEvents
{
    public static BankAccount Handle(BankAccount state, OpenedAccount openedAccount)
    {
        state.IsOpen = true;
        return state;
    }
}