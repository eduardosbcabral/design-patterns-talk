using System;

internal class TelegramNotifier : Notifier
{
    protected override INotification CreateNotification(string to, string from, string message, DateTime time)
        => new TelegramNotification(to, from, message, time);

    protected override void SendToQueue(INotification notification)
        => Console.WriteLine("Enviando para a fila de notificações Telegram.");
}