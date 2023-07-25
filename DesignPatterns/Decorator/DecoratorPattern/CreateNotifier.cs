using Decorator.DAL;

namespace Decorator.DecoratorPattern;

public class CreateNotifier : INotifier
{
    Context context = new Context();

    /// <summary>
    /// //Sadece bildirim oluşturucu. Notifier classına yeni bir bildirim ekleme.
    /// </summary>
    /// <param name="notifier"></param>
    void INotifier.CreateNotifier(Notifier notifier)
    {
        context.Notifiers.Add(notifier);
        context.SaveChanges();
    }
}
