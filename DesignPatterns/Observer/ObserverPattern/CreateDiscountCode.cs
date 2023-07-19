using Observer.DAL;

namespace Observer.ObserverPattern;

public class CreateDiscountCode : IObserver
{
    private readonly IServiceProvider serviceProvider;

    public CreateDiscountCode(IServiceProvider serviceProvider)
    {
        this.serviceProvider = serviceProvider;
    }
    Context context = new();

    public void CreateNewUser(AppUser appUser)
    {
        context.Discounts.Add(new Discount
        {
            Code = "DERGIX",
            Amount = 35,
            CodeStatus = true
        });
        context.SaveChanges();
    }
}
