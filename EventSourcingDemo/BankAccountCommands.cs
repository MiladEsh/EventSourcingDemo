namespace EventSourcingDemo;

public class BankAccountCommands
{
    public static IEvent Handle(BankAccount state, ICommand command)
    {
        switch (command)
        {
            case OpenAccount _:
                return state.IsOpen
                   ? throw new InvalidOperationException("Already open.")
                   : new OpenedAccount(state.Id);

            case Deposit c:
                {
                    if (!state.IsOpen)
                    {
                        throw new InvalidOperationException("Not open.");
                    }
                    else
                    {
                        return new Deposited(state.Id, c.Amount);
                    }
                }

            default:
                throw new ArgumentOutOfRangeException(nameof(command));
        }
    }
}