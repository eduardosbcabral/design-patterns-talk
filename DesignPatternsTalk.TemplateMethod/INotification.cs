using System;

internal interface INotification
{
    public string To { get; }
    public string From { get; }
    public string Message { get; }
    public DateTime Time { get; }

    string FormatMessage(string message);
    void ValidateUser(string user);
}