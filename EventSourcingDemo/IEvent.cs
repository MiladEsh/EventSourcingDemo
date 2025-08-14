namespace EventSourcingDemo;

public interface IEvent { }

public record OpenedAccount(Guid Id) : IEvent;
