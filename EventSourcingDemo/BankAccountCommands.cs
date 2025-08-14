namespace EventSourcingDemo;

public class BankAccountCommands
{
    public static IEvent Handle(BankAccount state, ICommand command)
    {
        switch (command)
        {
            case OpenAccount c:
                return state.IsOpen
                   ? throw new InvalidOperationException("Already open.")
                   : new OpenedAccount(state.Id);

            case Deposit c:
                return !state.IsOpen
                   ? throw new InvalidOperationException("Not open.")
                   : new Deposited(state.Id, c.Amount);

            default:
                throw new ArgumentOutOfRangeException(nameof(command));
        }
    }
}