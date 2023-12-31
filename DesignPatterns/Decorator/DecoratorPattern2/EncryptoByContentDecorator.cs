﻿using Decorator.DAL;

namespace Decorator.DecoratorPattern2;

public class EncryptoByContentDecorator : Decorator
{
    Context context = new Context();
    private readonly ISendMessage _sendMessage;
    public EncryptoByContentDecorator(ISendMessage sendMessage) : base(sendMessage)
    { 
        _sendMessage = sendMessage;
    }
    public void SendMessageByEncryptoContent(Message message)
    {
        message.Sender = "Takım Lideri";
        message.Receiver = "Yazılım Ekibi";
        message.Content = "Saat 17.00'de publish yapılacak";
        message.Subject = "Publish";
        string data = "";
        data = message.Content;
        char[] chars = data.ToCharArray();
        foreach (var item in chars)
        {
            message.Content += Convert.ToChar(item + 3).ToString();
        }
        context.Messages.Add(message);
        context.SaveChanges();
    }
    public override void SendMessage(Message message)
    {
        base.SendMessage(message);
        SendMessageByEncryptoContent(message);
    }
}
