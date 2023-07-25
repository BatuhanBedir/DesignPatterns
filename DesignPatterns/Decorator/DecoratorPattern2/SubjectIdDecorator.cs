﻿using Decorator.DAL;

namespace Decorator.DecoratorPattern2;

public class SubjectIdDecorator : Decorator
{
    private readonly ISendMessage _sendMessage;
    Context context = new Context();
    public SubjectIdDecorator(ISendMessage sendMessage) : base(sendMessage)
    {
        _sendMessage = sendMessage;
    }
    public void SendMessageIdSubject(Message message)
    {
        if(message.Subject == "1")
        {
            message.Subject = "Toplantı";
        }
        if(message.Subject == "2")
        {
            message.Subject = "Scrum Toplantısı";
        }
        if(message.Subject == "3")
        {
            message.Subject = "Haftalık Değerlendirme";
        }
       
        context.Messages.Add(message);
        context.SaveChanges();
    }
    public override void SendMessage(Message message)
    {
        base.SendMessage(message);
        SendMessageIdSubject(message);
    }
}
