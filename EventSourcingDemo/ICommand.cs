namespace EventSourcingDemo;

public interface ICommand { }

public record OpenAccount(Guid id) : ICommand;
public record Deposit(Guid id, int amount) : ICommand;
public record Withdraw(Guid id, int amount) : ICommand;