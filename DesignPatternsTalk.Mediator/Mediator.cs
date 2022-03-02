internal interface Mediator
{
    public void Send(string message, Colleague colleague);
}