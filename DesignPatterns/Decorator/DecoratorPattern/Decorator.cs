using Decorator.DAL;

namespace Decorator.DecoratorPattern;

public class Decorator : INotifier  //Default bildirim oluşturma sınıfı->Decorator
{
    private readonly INotifier _notifier;

    public Decorator(INotifier notifier)
    {
        _notifier = notifier;
    }

    public virtual void CreateNotifier(Notifier notifier)
    {
        notifier.Creater = "Admin";
        notifier.Subject = "Toplantı";
        notifier.Type = "Public";
        notifier.Channel = "Whatsapp";

        _notifier.CreateNotifier(notifier);
    }
}
