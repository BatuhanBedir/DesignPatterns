using ChainOfResponsibility.DAL;
using ChainOfResponsibility.Models;

namespace ChainOfResponsibility.ChainOfResponsibility;

public class Manager : Employee
{
    public override void ProcesRequest(CustomerProcessVM request)
    {
        Context context = new();

        if (request.Amount <= 250000)
        {
            CustomerProcess customerProcess = new CustomerProcess()
            {
                Amount = request.Amount.ToString(),
                Name = request.Name,
                EmployeeName = "Şube Müdürü - Berke Yıldız",
                Description = "Para çekme işlemi onaylandı. Talep edilen tutar ödendi"
            };

            context.CustomerProcesseses.Add(customerProcess);
            context.SaveChanges();
        }
        else if (NextApprover is not null)
        {
            CustomerProcess customerProcess = new CustomerProcess()
            {
                Amount = request.Amount.ToString(),
                Name = request.Name,
                EmployeeName = "Şube Müdürü - Berke Yıldız",
                Description = "Para çekme tutarı şube müdürünün günlük ödeyebileceği limiti aştığı için işlem bölge müdürüne yönlendirildi."
            };

            context.CustomerProcesseses.Add(customerProcess);
            context.SaveChanges();

            NextApprover.ProcesRequest(request);
        }
    }
}
