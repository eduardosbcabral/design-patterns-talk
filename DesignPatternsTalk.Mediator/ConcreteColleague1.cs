using System;

internal class ConcreteColleague1 : Colleague
{
    public ConcreteColleague1(Mediator mediator)
      : base(mediator)
    {
    }

    public void Send(string message)
    {
        Mediator.Send(message, this);
    }

    public void Notify(string message)
    {
        Console.WriteLine($"Colleague1 gets message: {message}");
    }
}