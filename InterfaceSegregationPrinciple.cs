using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DesignPrinciple
{

    // Interface for scanning functionality
    public interface IScanner
    {
        // Method to scan documents
        void Scan();
    }

    // Interface for printing functionality
    public interface IPrinter
    {
        // Method to print documents
        void Print();
    }

    // Class representing a multi-function printer that implements both IPrinter and IScanner
    public class MultiFunctionPrinter : IPrinter, IScanner
    {
        // Implement the Print method from IPrinter
        public void Print() => Console.WriteLine("Printing");

        // Implement the Scan method from IScanner
        public void Scan() => Console.WriteLine("Scanning");
    }

    // Class representing a simple printer that only implements IPrinter
    public class SimplePrinter : IPrinter
    {
        // Implement the Print method from IPrinter
        public void Print() => Console.WriteLine("Printing");
    }

    // Class representing a simple scanner that only implements IScanner
    public class SimpleScanner : IScanner
    {
        // Implement the Scan method from IScanner
        public void Scan() => Console.WriteLine("Scanning");
    }

    // Main program class
    class InterfaceSegregationPrinciple
    {
        public static void Run()
        {
            // Create an instance of MultiFunctionPrinter
            MultiFunctionPrinter mfp = new MultiFunctionPrinter();
            mfp.Print(); // Output: Printing
            mfp.Scan();  // Output: Scanning

            // Create an instance of SimplePrinter
            SimplePrinter printer = new SimplePrinter();
            printer.Print(); // Output: Printing

            // Create an instance of SimpleScanner
            SimpleScanner scanner = new SimpleScanner();
            scanner.Scan(); // Output: Scanning
        }
    }
}