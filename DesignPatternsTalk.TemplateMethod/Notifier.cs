using System;

internal abstract class Notifier
{
    protected abstract INotification CreateNotification(string to, string from, string message, DateTime time);
    protected abstract void SendToQueue(INotification notification);

    public void Notify(string to, string from, string message, DateTime time)
    {
        var notification = CreateNotification(to, from, message, time);

        SendToQueue(notification);
    }
}