using EmployeeManagement.Entities;
using EmployeeManagement.Exceptions;
using EmployeeManagement.Services;
using System.Globalization;

namespace EmployeeManagement;

public class Program
{
    static void Main(string[] args)
    {
        // Initial configs
        List<Employee> employees = new List<Employee>();
        string currentDirectory = Directory.GetCurrentDirectory();
        string repositoryDirectory = "Repository";
        Directory.CreateDirectory($"{currentDirectory}/{repositoryDirectory}");
        string file = $"{repositoryDirectory}/EmployeeRepository.csv";

        CreateRepositoryIfNotExist(file);

        ReadRepository(file, employees);

        Boolean isRunning = true;

        while (isRunning)
        {
            try
            {
                ShowMenu();
                Console.Write("Choose an option: ");
                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.Clear();
                        CreateEmployee(file, employees);
                        Console.WriteLine("Employee created.\n");
                        break;

                    case 2:
                        Console.Clear();
                        ListAllEmployees(file);
                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("Employee Id: ");
                        int id = int.Parse(Console.ReadLine());
                        UpdateEmployee(file, id, employees);
                        break;

                    case 4:
                        Console.Clear();
                        Console.WriteLine("Employee Id: ");
                        id = int.Parse(Console.ReadLine());
                        DeleteEmployee(file, id, employees);
                        break;

                    case 5:
                        Console.Clear();
                        Console.Write("Department: ");
                        string department = Console.ReadLine().Trim();
                        FilterByDepartment(department, employees);
                        break;

                    case 6:
                        Console.Clear();
                        break;

                    case 7:
                        isRunning = false;
                        Console.WriteLine("Closing program...");
                        break;

                    default:
                        break;
                }
            }

            catch (DomainException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            
        }

        
    }

    static void ShowMenu()
    {
        Console.WriteLine("EMPLOYEE MANAGEMENT");
        Console.WriteLine("\n[1] Create Employee");
        Console.WriteLine("[2] List All Employees");
        Console.WriteLine("[3] Update Employee");
        Console.WriteLine("[4] Delete Employee");
        Console.WriteLine("[5] List by Department");
        Console.WriteLine("[6] Clear console");
        Console.WriteLine("[7] Exit\n");
    }

    static void CreateRepositoryIfNotExist(string file)
    {
        if (!File.Exists(file))
        {
            using (StreamWriter sw = new StreamWriter(file))
            {
                sw.WriteLine("Id;Name;Position;Salary;DateHire;Department");
            }
        }
    }

    static void ReadRepository(string file, List<Employee> employees)
    {
        employees.Clear();
        using (StreamReader sr = new StreamReader(file))
        {
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();

                if (!line.Contains("Id"))
                {
                    string[] vect = line.Split(";");
                    int id = int.Parse(vect[0]);
                    string name = vect[1];
                    string position = vect[2];
                    double salary = double.Parse(vect[3]);
                    DateOnly dateHire = DateOnly.ParseExact(vect[4], "yyyy-MM-dd");
                    string department = vect[5];
                    Employee employee = new Employee(id, name, position, salary, dateHire, new Department(department));
                    employees.Add(employee);
                }
            }
        }
    }

    static int GetNextId(List<Employee> employees)
    {
        if (employees.Count == 0)
        {
            return employees.Count + 1;
        }
        else
        {
            int lastIndex = employees.Count - 1;
            int nextId = employees[lastIndex].Id + 1;
            return nextId;
        } 
    }

    static void SaveEmployee(string file, Employee employee)
    {
        if (File.Exists(file))
        {
            using (StreamWriter sw = new StreamWriter(file, true))
            {
                sw.WriteLine(employee);
            }
        }

    }

    static void CreateEmployee(string file, List<Employee> employees)
    {
        Console.Write("Name: ");
        string name = Console.ReadLine().Trim();
        Console.Write("Position: ");
        string position = Console.ReadLine().Trim();
        Console.Write("Salary: ");
        double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Date Hire (dd/MM/yyyy): ");
        DateOnly dateHire = DateOnly.ParseExact(Console.ReadLine(), "dd/MM/yyyy");
        Console.Write("Department: ");
        string department = Console.ReadLine().Trim();
        int id = GetNextId(employees);

        Employee employee = new Employee(id, name, position, salary, dateHire, new Department(department));
        employees.Add(employee);
        SaveEmployee(file, employee);
    }

    static void ListAllEmployees(string file)
    {
        List<string> lines = File.ReadAllLines(file).ToList();

        if (lines.Count > 1)
        {
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }
        else
        {
            Console.WriteLine("Employee list is empty.");
        }
        
        Console.WriteLine();
    }

    static void FilterByDepartment(string department, List<Employee> employees)
    {
        List<Employee> filteredList = employees.FindAll(emp => emp.Department.Name == department);

        foreach (Employee employee in filteredList)
        {
            Console.WriteLine(employee);
        }

        Console.WriteLine();
    }

    static void DeleteEmployee(string file, int id, List<Employee> employees)
    {
        Employee employee = employees.Find(emp => emp.Id == id);

        if (employee == null)
        {
            throw new DomainException("Employee not founded!\n");
        }
        else
        {
            employees.Remove(employee);
            List<string> lines = File.ReadAllLines(file).ToList();

            for (int i = 0; i < lines.Count; i++)
            {
                string[] fields = lines[i].Split(";");
                if (!fields[0].Contains("Id"))
                {
                    int idField = int.Parse(fields[0]);

                    if (idField == id)
                    {
                        lines.RemoveAt(i);
                        break;
                    }
                }

            }

            File.WriteAllLines(file, lines);
        }

    }

    static void UpdateEmployee(string file, int id, List<Employee> employees)
    {
        ReadRepository(file, employees);
        Employee employee = employees.Find(emp => emp.Id == id);

        if (employee == null)
        {
            throw new DomainException("Employee not founded!\n");
        }
        else
        {
            List<string> fields = new List<string> { "Name", "Position", "Salary", "Date Hire", "Department"};
            Console.WriteLine($"Name: {employee.Name}");
            Console.WriteLine($"Position: {employee.Position}");
            Console.WriteLine($"Salary: {employee.Salary.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Date Hire: {employee.DateHire}");
            Console.WriteLine($"Department: {employee.Department}");

            foreach (var field in fields)
            {
                UpdateEmployeeField(employee, field);
            }

            SaveEmployeeById(file, employee, id);
        }
    }

    static void UpdateEmployeeField(Employee employee, string field)
    {
        Console.Write($"\nUpdate {field} (y/n)? ");
        string choice = Console.ReadLine().Trim().ToLower();

        while (choice != "y" && choice != "n")
        {
            Console.Write($"Wrong choice. Please type 'y' or 'n'. Update {field} (y/n)? ");
            choice = Console.ReadLine().Trim().ToLower();
        }

        if(choice == "y")
        {
            Console.Write($"New {field}: ");
            string input = Console.ReadLine();

            switch (field)
            {
                case "Name":
                    employee.Name = input;
                    break;

                case "Position":
                    employee.Position = input;
                    break;

                case "Salary":
                    employee.Salary = double.Parse(input, CultureInfo.InvariantCulture);
                    break;

                case "Date Hire":
                    employee.DateHire = DateOnly.ParseExact(input, "dd/MM/yyyy");
                    break;

                case "Department":
                    employee.Department.Name = input;
                    break;
            }
        }
    }

    static void SaveEmployeeById(string file, Employee employee, int id)
    {
        List<string> lines = File.ReadAllLines(file).ToList();

        for (int i = 0; i < lines.Count; i++)
        {
            string[] fields = lines[i].Split(";");
            if (!fields[0].Contains("Id"))
            {
                int idField = int.Parse(fields[0]);

                if (idField == employee.Id)
                {
                    lines[i] = employee.ToString();
                    break;
                }
            }

        }

        File.WriteAllLines(file, lines);
    }
}