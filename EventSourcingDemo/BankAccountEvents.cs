
namespace EventSourcingDemo.Tests;

public class BankAccountEvents
{
    public static BankAccount Handle(BankAccount state, params IEvent[] events)
    {
        var result = state;
        foreach (var evt in events)
        {
            result = HandleEvent(result, evt);
        }
        return result;
    }

    public static BankAccount HandleEvent(BankAccount state, IEvent evt)
    {
        switch (evt)
        {
            case OpenedAccount:
                return state with { IsOpen = true };

            case Deposited c:
                return state with { Balance = c.Amount };

            default:
                throw new ArgumentOutOfRangeException(nameof(evt));
        }
    }
}