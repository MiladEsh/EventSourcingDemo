namespace EventSourcingDemo;

public interface IEvent { }

public record OpenedAccount(Guid Id) : IEvent;

public record Deposited(Guid Id, int Amount) : IEvent;
