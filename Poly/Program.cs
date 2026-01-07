using System; // 🚪 Gateway to core .NET functionality like Console input/output

// 🎭 Step 1: Define an interface that sets a contract for quitting behavior
public interface IQuittable
{
    void Quit(); // 📜 Any class that signs this contract MUST implement Quit()
}

// 👔 Step 2: Create an Employee class that inherits from IQuittable
public class Employee : IQuittable
{
    // 🧾 Properties to describe an employee (could be expanded later)
    public string FirstName { get; set; }
    public string LastName { get; set; }

    // 🛠 Constructor to quickly build an Employee with a name
    public Employee(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    // 🚪 Implementation of the Quit() method from IQuittable
    public void Quit()
    {
        // 🎤 Dramatic exit message when an employee quits
        Console.WriteLine($"{FirstName} {LastName} has decided to quit. Best of luck on your next adventure!");
    }
}

// 🚀 Step 3: Main program entry point
class Program
{
    static void Main(string[] args)
    {
        // 🧑‍💻 Create an Employee object with sample data
        Employee emp = new Employee("Alice", "Johnson");

        // 🎭 Polymorphism in action: treat Employee as IQuittable
        IQuittable quittableEmp = emp;

        // 🔔 Call the Quit() method via the interface reference
        quittableEmp.Quit();

        // ⏳ Keep console open until user presses a key
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
