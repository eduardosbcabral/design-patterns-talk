using System;

internal class TelegramNotification : INotification
{
    public string To { get; private set; }
    public string From { get; private set; }
    public string Message { get; private set; }
    public DateTime Time { get; private set; }

    public TelegramNotification(string to, string from, string message, DateTime time)
    {
        ValidateUser(to);
        ValidateUser(from);
        To = to;
        From = from;
        Message = FormatMessage(message);
        Time = time;
    }

    public string FormatMessage(string message)
       => "Changing message to telegram format";

    // Check if telegram user is valid
    public void ValidateUser(string user)
    {
        // Example
        if (user.Length > 15)
            throw new Exception();
    }
}