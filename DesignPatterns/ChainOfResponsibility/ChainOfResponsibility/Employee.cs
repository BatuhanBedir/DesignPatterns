using ChainOfResponsibility.Models;

namespace ChainOfResponsibility.ChainOfResponsibility;

public abstract class Employee
{
    protected Employee NextApprover;
    public void SetNextApprover(Employee supervisor)
    {
        this.NextApprover = supervisor;
        //sıradaki onaylayıcı diğer çalışandan gelen değer.
    }
    public abstract void ProcesRequest(CustomerProcessVM request);//atamalarımı tutacak-vm üzerinden-
}
