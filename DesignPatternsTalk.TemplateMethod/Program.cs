using System;

Console.WriteLine("\nExecutando o notificador para o WhatsApp.");
RunNotifier(new WhatsappNotifier());

Console.WriteLine("\nExecutando o notificador para o Telegram.");
RunNotifier(new TelegramNotifier());

void RunNotifier(Notifier notifier)
{
    Console.WriteLine("Eu não sei quem é a classe Notifier, mas eu funciono.");
    notifier.Notify("user12345", "user123456", "Message", DateTime.Now);
}