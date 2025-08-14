namespace EventSourcingDemo;

public interface ICommand { }

public record OpenAccount(Guid Id) : ICommand;
public record Deposit(Guid Id, int Amount) : ICommand;
public record Withdraw(Guid Id, int Amount) : ICommand;