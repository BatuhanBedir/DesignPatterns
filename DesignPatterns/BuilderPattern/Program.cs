using BuilderPattern.Method1;
using BuilderPattern.Method2;
using System.Text;

//1
var eb = new EndpointBuilder("https://localhost");

eb
    .Append("api")
    .Append("v1")
    .Append("user")
    .AppendParam("id", "5")
    .AppendParam("username", "batu");


var url = eb.Build();

Console.WriteLine("Final Url: " + url);

//2
var empBuilder = new EmployeeBuilderM1();
var employee = empBuilder
    .SetFullName("Batuhan Bedir")
    .SetUserName("batubedir")
    .SetEmailAddress("batuhan.bedir@gmail.com")
    .BuildEmployee();

//Console.WriteLine("M1 EmployeeFirstName: " + employee.FirstName);

//3
IEmployeeBuilderM2 employeeBuilder = new InternalEmployeeBuilder();
employeeBuilder.SetEmailAddress("batuhan.bedir@gmail.com");
employeeBuilder.SetFullName("Batuhan Bedir");

var emp = employeeBuilder.BuilderEmployee();

Console.WriteLine("Email Address:" + emp.EmailAddress);

//4
var emp1 = Generate("batuhan bedir","batuhan.bedir@gmail.com",0);

EmployeeM2 Generate(string fullName, string emailAddress, int empType)
{
    IEmployeeBuilderM2 employeeBuilder;
    if (empType == 0)
        employeeBuilder = new InternalEmployeeBuilder();
    else
        employeeBuilder = new ExternalEmployeeBuilder();

    employeeBuilder.SetFullName(fullName);
    employeeBuilder.SetEmailAddress(emailAddress);

    return employeeBuilder.BuilderEmployee();
}
Console.WriteLine(emp1.EmailAddress);