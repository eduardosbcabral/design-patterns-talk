using System;

internal class ConcreteColleague2 : Colleague
{
    public ConcreteColleague2(Mediator mediator)
      : base(mediator)
    {
    }

    public void Send(string message)
    {
        Mediator.Send(message, this);
    }

    public void Notify(string message)
    {
        Console.WriteLine($"Colleague2 gets message: {message}");
    }
}