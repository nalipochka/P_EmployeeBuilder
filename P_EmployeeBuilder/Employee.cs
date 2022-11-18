using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_EmployeeBuilder
{
    public class Employee
    {
        public string Name { get; set; } = null!;
        public string Surname { get; set; } = null!;
        public DateTime? DateOfBirth { get; set; }
        public string PhoneNumber { get; set; } = null!;
        public string EMail { get; set; } = null!;
        public string Education { get; set; } = null!;
        public List<string> Competencies { get; set; } = null!;
        public List<string> Positions { get; set; } = null!;
        public static EmployeeBuilder CreateBuilder()
        {
            return new EmployeeBuilder();
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            if (Name != null)
                sb.AppendLine($"Name: {Name}");
            if (Surname != null)
                sb.AppendLine($"Surname: {Surname}");
            if (DateOfBirth != null)
                sb.AppendLine($"Date of Birth: {DateOfBirth.Value.ToString("dd.MM.yyyy")}");
            if (PhoneNumber != null)
                sb.AppendLine($"Phone: {PhoneNumber}");
            if (EMail != null)
                sb.AppendLine($"e-Mail: {EMail}");
            if (Education != null)
                sb.AppendLine($"Education: {Education}");
            if (Competencies != null)
            {
                sb.AppendLine("Cometencies:");
                foreach (var item in Competencies)
                {
                    sb.AppendLine($"\r\t {item}");
                }
            }
            if (Positions != null)
            {
                sb.AppendLine("Positions:");
                foreach (var item in Positions)
                {
                    sb.AppendLine($"\r\t {item}");
                }
            }
            return sb.ToString();
        }
    }
    public abstract class Builder
    {
        public Employee employee { get; private set; }
        public void CreateEmployee()
        {
            employee = new Employee();
        }
        abstract public EmployeeBuilder SetName(string name);
        abstract public EmployeeBuilder SetSurname(string surname);
        abstract public EmployeeBuilder SetDateOfBirth(DateTime date);
        abstract public EmployeeBuilder SetPhoneNumber(string phoneNumber);
        abstract public EmployeeBuilder SetEmail(string email);
        abstract public EmployeeBuilder SetEducation(string education);
        abstract public EmployeeBuilder SetCompetencies(List<string> competencies);
        abstract public EmployeeBuilder SetPositions(List<string> positions);

    }
    public class EmployeeBuilder : Builder
    {
        public EmployeeBuilder()
        {
            CreateEmployee();
        }
        public override EmployeeBuilder SetName(string name)
        {
            employee.Name = name;
            return this;
        }

        public override EmployeeBuilder SetSurname(string surname)
        {
            employee.Surname = surname;
            return this;
        }

        public override EmployeeBuilder SetDateOfBirth(DateTime date)
        {
            employee.DateOfBirth = date;
            return this;

        }

        public override EmployeeBuilder SetPhoneNumber(string phoneNumber)
        {
            employee.PhoneNumber = phoneNumber;
            return this;
        }

        public override EmployeeBuilder SetEmail(string email)
        {
            employee.EMail = email;
            return this;
        }

        public override EmployeeBuilder SetCompetencies(List<string> competencies)
        {
            employee.Competencies = competencies;
            return this;
        }

        public override EmployeeBuilder SetPositions(List<string> positions)
        {
            employee.Positions = positions;
            return this;
        }

        public override EmployeeBuilder SetEducation(string education)
        {
            employee.Education = education;
            return this;
        }

        public static implicit operator Employee(EmployeeBuilder builder)
        {
            return builder.employee;
        }
    }
}
