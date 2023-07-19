using Observer.DAL;

namespace Observer.ObserverPattern;

public class CreateWelcomeMessage : IObserver
{
    private readonly IServiceProvider serviceProvider;

    public CreateWelcomeMessage(IServiceProvider serviceProvider)
    {
        this.serviceProvider = serviceProvider;
    }

    Context context = new Context();
    public void CreateNewUser(AppUser appUser)
    {
        context.WelcomeMessages.Add(new WelcomeMessage
        {
            NameSurname = appUser.Name + " " + appUser.Surname,
            Content = "Dergi bültenimize kayıt olduğunuz için teşekkürler."
        });
        context.SaveChanges();
    }
}
