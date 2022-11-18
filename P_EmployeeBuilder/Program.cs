using P_EmployeeBuilder;


EmployeeBuilder builder = Employee.CreateBuilder();
builder.SetName("Ivan");
builder.SetSurname("Ivanov");
builder.SetEmail("ivanivanov@gmail.com");
builder.SetDateOfBirth(DateTime.Parse("20.03.1991"));
builder.SetPositions(new List<string> { "Middle Backend Developer", "Tester" });
Employee Ivan = builder;
Console.WriteLine(Ivan.ToString());

builder = Employee.CreateBuilder();
builder.SetName("Petr");
builder.SetSurname("Petrov");
builder.SetEmail("petrpetrov@gmail.com");
builder.SetDateOfBirth(DateTime.Parse("21.12.1975"));
builder.SetPositions(new List<string> { "Middle Backend Developer", "Tester", "Senior Backend Developer", "Project Manager" });
builder.SetPhoneNumber("+380984329850");
builder.SetEducation("Kyiv Polytechnic University. Faculty of Information Technology.");
Employee Petr = builder;
Console.WriteLine(Petr.ToString());

builder = Employee.CreateBuilder();
builder.SetName("Sidor");
builder.SetSurname("Sidorov");
builder.SetEmail("sidorsidorov@gmail.com");
builder.SetDateOfBirth(DateTime.Parse("14.10.2001"));
builder.SetCompetencies(new List<string> { "Backend Developer" });
Employee Sidor = builder;
Console.WriteLine(Sidor.ToString());
