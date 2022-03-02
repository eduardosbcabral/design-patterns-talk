using System;

internal class WhatsappNotifier : Notifier
{
    protected override INotification CreateNotification(string to, string from, string message, DateTime time)
        => new WhatsappNotication(to, from, message, time);

    protected override void SendToQueue(INotification notification)
        => Console.WriteLine("Enviando para a fila de notificações WhatsApp.");
}
