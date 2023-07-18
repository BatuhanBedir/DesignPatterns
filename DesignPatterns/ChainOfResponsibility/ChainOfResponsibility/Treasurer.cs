using ChainOfResponsibility.DAL;
using ChainOfResponsibility.Models;

namespace ChainOfResponsibility.ChainOfResponsibility;

public class Treasurer : Employee
{
    public override void ProcesRequest(CustomerProcessVM request)
    {
        Context context = new Context();

        if (request.Amount <= 100000)
        {
            CustomerProcess customerProcess = new CustomerProcess()
            {
                Amount = request.Amount.ToString(),
                Name = request.Name,
                EmployeeName = "Veznedar - Ayşe Çınar",
                Description = "Para çekme işlemi onaylandı. Talep edilen tutar ödendi"
            };

            context.CustomerProcesseses.Add(customerProcess);
            context.SaveChanges();
        }
        else if(NextApprover is not null)
        {
            CustomerProcess customerProcess = new CustomerProcess()
            {
                Amount = request.Amount.ToString(),
                Name = request.Name,
                EmployeeName = "Veznedar - Ayşe Çınar",
                Description = "Para çekme tutarı veznedarın günlük ödeyebileceği limiti aştığı için işlem şube müdür yrd. yönlendirildi."
            };

            context.CustomerProcesseses.Add(customerProcess);
            context.SaveChanges();

            NextApprover.ProcesRequest(request);
        }

    }
}
