﻿using Decorator.DAL;

namespace Decorator.DecoratorPattern;

public class MailDecorator : Decorator
{
    Context context = new Context();
    private readonly INotifier _notifier;
    public MailDecorator(INotifier notifier) : base(notifier)
    {
        _notifier = notifier;
    }
    public void SendMailNotify(Notifier notifier)
    {
        notifier.Subject = "Günlük Sabah Toplantısı";
        notifier.Creater = "Scrum Master";
        notifier.Channel = "GMail-Outlook";
        notifier.Type = "Private Team";
        context.Notifiers.Add(notifier);
        context.SaveChanges();
    }
    public override void CreateNotifier(Notifier notifier)
    {
        base.CreateNotifier(notifier);
        SendMailNotify(notifier);
    }
}
