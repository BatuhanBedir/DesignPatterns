namespace Singleton.Models;

public class CountryProvider
{
    private static CountryProvider instance = null;
    public static CountryProvider Instance => instance ?? (instance = new CountryProvider());


    //public static CountryProvider Instance
    //{
    //    get
    //    {
    //        if (instance is not null)
    //        {
    //            //yeniden yaratma
    //            return instance;
    //        }
    //        else
    //        {
    //            //yeni bir tane yaratma
    //            instance = new CountryProvider();
    //            return instance;
    //        }
    //    }
    //    set => instance = value;
    //}

    private new List<Country> Countries { get; set; }

    private CountryProvider()
    {
        Task.Delay(2000).GetAwaiter().GetResult();
        Countries = new List<Country>()
            {
                new Country(){Name = "Türkiye"},
                new Country(){Name = "Birleşik Krallık"}
            };
    }
    public int CountryCount => Countries.Count;

    public async Task<List<Country>> GetCountries() => Countries;

    //public async Task<List<Country>> GetCountries()
    //{
    //    if (Countries is null)
    //    {
    //        //Retrieving data from db
    //        await Task.Delay(2000);
    //        Countries = new List<Country>()
    //        {
    //            new Country(){Name = "Türkiye"},
    //            new Country(){Name = "Birleşik Krallık"}
    //        };
    //    }
    //    return Countries;

    //}
}
