using ChainOfResponsibility.DAL;
using ChainOfResponsibility.Models;

namespace ChainOfResponsibility.ChainOfResponsibility;

public class ManagerAssistant : Employee
{
    public override void ProcesRequest(CustomerProcessVM request)
    {
        Context context = new();

        if (request.Amount <= 150000)
        {
            CustomerProcess customerProcess = new CustomerProcess()
            {
                Amount = request.Amount.ToString(),
                Name = request.Name,
                EmployeeName = "Şube Müdür Yardımcısı - Celal Ak",
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
                EmployeeName = "Şube Müdür Yardımcısı - Celal Ak",
                Description = "Para çekme tutarı şube müdür yardımcısının günlük ödeyebileceği limiti aştığı için işlem şube müdürüne yönlendirildi."
            };

            context.CustomerProcesseses.Add(customerProcess);
            context.SaveChanges();

            NextApprover.ProcesRequest(request);
        }
    }
}
