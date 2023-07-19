using Observer.DAL;

namespace Observer.ObserverPattern;

public class CreateMagazineAnnouncement : IObserver
{
    private readonly IServiceProvider serviceProvider;

    public CreateMagazineAnnouncement(IServiceProvider serviceProvider)
    {
        this.serviceProvider = serviceProvider;
    }
    Context context = new();
    public void CreateNewUser(AppUser appUser)
    {
        context.UserProcesses.Add(new UserProcess
        {
            NameSurname = appUser.Name + " " + appUser.Surname,
            Magazine = "Bilim Dergisi",
            Content = "Bilim Dergimiz x tarihinde tarafınıza ulaştırılacaktır."
        });
        context.SaveChanges();
    }
}
