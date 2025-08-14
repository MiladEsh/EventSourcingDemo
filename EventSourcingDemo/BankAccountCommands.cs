namespace EventSourcingDemo;

public class BankAccountCommands
{
    public static IEvent Handle(BankAccount state, ICommand command)
    {
        if (state.IsOpen) throw new InvalidOperationException("Already open.");
        return new OpenedAccount(state.Id);
    }
}