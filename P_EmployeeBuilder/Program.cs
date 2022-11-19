using P_EmployeeBuilder;


EmployeeBuilder builder = Employee.CreateBuilder();
builder.SetName("Ivan")
    .SetSurname("Ivanov")
    .SetEmail("ivanivanov@gmail.com")
    .SetDateOfBirth(DateTime.Parse("20.03.1991"))
    .SetPositions(new List<string> { "Middle Backend Developer", "Tester" });
Employee Ivan = builder;
Console.WriteLine(Ivan.ToString());

builder = Employee.CreateBuilder();
builder.SetName("Petr")
    .SetSurname("Petrov")
    .SetEmail("petrpetrov@gmail.com")
    .SetDateOfBirth(DateTime.Parse("21.12.1975"))
    .SetPositions(new List<string> { "Middle Backend Developer", "Tester", "Senior Backend Developer", "Project Manager" })
    .SetPhoneNumber("+380984329850")
    .SetEducation("Kyiv Polytechnic University. Faculty of Information Technology.");
Employee Petr = builder;
Console.WriteLine(Petr.ToString());

builder = Employee.CreateBuilder();
builder.SetName("Sidor")
    .SetSurname("Sidorov")
    .SetEmail("sidorsidorov@gmail.com")
    .SetDateOfBirth(DateTime.Parse("14.10.2001"))
    .SetCompetencies(new List<string> { "Backend Developer" });
Employee Sidor = builder;
Console.WriteLine(Sidor.ToString());
