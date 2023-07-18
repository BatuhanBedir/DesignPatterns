using ChainOfResponsibility.DAL;
using ChainOfResponsibility.Models;

namespace ChainOfResponsibility.ChainOfResponsibility
{
    public class AreaDirector : Employee
    {
        public override void ProcesRequest(CustomerProcessVM request)
        {
            Context context = new();

            if (request.Amount <= 400000)
            {
                CustomerProcess customerProcess = new CustomerProcess()
                {
                    Amount = request.Amount.ToString(),
                    Name = request.Name,
                    EmployeeName = "Bölge Direktörü - Batuhan Bedir",
                    Description = "Para çekme işlemi onaylandı. Talep edilen tutar ödendi"
                };

                context.CustomerProcesseses.Add(customerProcess);
                context.SaveChanges();
            }
            else
            {
                CustomerProcess customerProcess = new CustomerProcess()
                {
                    Amount = request.Amount.ToString(),
                    Name = request.Name,
                    EmployeeName = "Bölge Direktörü - Batuhan Bedir",
                    Description = "Para çekme tutarı bölge direktörünün günlük ödeyebileceği limiti aştığı için işlem gerçekleştirilemedi. müşterinin günlük max. çekebileceği tutar 400000₺."
                };

                context.CustomerProcesseses.Add(customerProcess);
                context.SaveChanges();

            }
        }
    }
}
