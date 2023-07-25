using Decorator.DAL;

namespace Decorator.DecoratorPattern2;

public class Decorator : ISendMessage
{
    private readonly ISendMessage _sendMessage;

    public Decorator(ISendMessage sendMessage)
    {
        _sendMessage = sendMessage;
    }

    public virtual void SendMessage(Message message)
    {
        message.Receiver = "Everybody";
        message.Sender = "Admin";
        message.Content = "Toplantı mesajıdır";
        message.Subject = "Toplantı";
        _sendMessage.SendMessage(message);
    }
}
