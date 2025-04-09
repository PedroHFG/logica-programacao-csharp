using System.Globalization;

namespace Ex03;

public class Program
{
    static void Main(string[] args)
    {
        List<Employee> employees = new List<Employee>();

        Console.Write("How many employees will be registered? ");
        int numberOfEmployees = int.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfEmployees; i++)
        {
            Console.WriteLine($"Employee #{i + 1}");
            Console.Write("Id: ");
            int id = int.Parse(Console.ReadLine());
            bool idExist = false;

            do
            {
                if (employees.FindIndex(x => x.Id == id) != -1)
                {
                    idExist = true;
                    Console.Write("This id already exist. Please try another id: ");
                    id = int.Parse(Console.ReadLine());
                }
                else
                {
                    idExist = false;
                }

            }
            while (idExist);

            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Salary: ");
            double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            employees.Add(new Employee(id, name, salary));
            Console.WriteLine();
            
        }

        Console.Write("Enter the employee id that will have salary increase: ");
        int idChoiced = int.Parse(Console.ReadLine());
        List<Employee> employeeFiltered = employees.FindAll(x => x.Id.Equals(idChoiced));

        if (employeeFiltered.Count > 0)
        {
            Console.Write("Enter the percentage: ");
            double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            foreach (Employee emp in employeeFiltered)
            {
                emp.IncreaseSalary(percentage);
            }
        }
        else
        {
            Console.WriteLine("This id does not exist!");
        }

        Console.WriteLine("\nUpdated list of employees:");

        foreach (Employee emp in employees)
        {
            Console.WriteLine(emp);
        } 
    }
}