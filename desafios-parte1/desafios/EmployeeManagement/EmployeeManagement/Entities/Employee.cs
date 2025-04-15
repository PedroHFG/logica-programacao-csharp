using System.Globalization;

namespace EmployeeManagement.Entities;

public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Position { get; set; }
    public double Salary { get; set; }
    public DateOnly DateHire { get; set; }

    public Department Department { get; set; }

    public Employee()
    {

    }

    public Employee(int id, string name, string position, double salary, DateOnly dateHire, Department department)
    {
        Id = id;
        Name = name;
        Position = position;
        Salary = salary;
        DateHire = dateHire;
        Department = department;
    }

    public override string ToString()
    {
        return $"{Id};{Name};{Position};{Salary.ToString("F2", CultureInfo.InvariantCulture)};{DateHire.ToString("yyyy-MM-dd")};{Department}";
    }
}
