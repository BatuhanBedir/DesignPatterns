using Decorator.DAL;

namespace Decorator.DecoratorPattern2;

public class EncryptoBySubjectDecorator :Decorator
{
    Context context = new Context();
    private readonly ISendMessage _sendMessage;

    public EncryptoBySubjectDecorator(ISendMessage sendMessage) : base(sendMessage)
    {  
        _sendMessage = sendMessage;
    }
    public void SendMessageByEncrypto(Message message)
    {
        
        string data = "";
        data = message.Subject;
        char[] chars = data.ToCharArray();
        foreach (var item in chars)
        {
            message.Subject += Convert.ToChar(item+3).ToString();
        }
        context.Messages.Add(message);
        context.SaveChanges();
    }
    public override void SendMessage(Message message)
    {
        base.SendMessage(message);
        SendMessageByEncrypto(message);
    }
}
