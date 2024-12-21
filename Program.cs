
namespace DesignPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select a design principle to run:");
            Console.WriteLine("1. Single Responsibility Principle (SRP)");
            Console.WriteLine("2. Open/Closed Principle (OCP)");
            Console.WriteLine("3. Liskov Substitution Principle (LSP)");
            Console.WriteLine("4. Interface Segregation Principle (ISP)");
            Console.WriteLine("5. Dependency Inversion Principle (DIP)");

            // Add more opt
            var choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    SingleResponsibilityPrinciple.Run();
                    break;
                case "2":
                    OpenClosedPrinciple.Run();
                    break;
                case "3":
                    LiskovSubstitutionPrinciple.Run();
                    break;
                case "4":
                    InterfaceSegregationPrinciple.Run();
                    break;
                case "5":
                    DependencyInversionPrinciple.Run();
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}