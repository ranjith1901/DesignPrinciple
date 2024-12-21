using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPrinciple
{

    // Class responsible for generating messages
    public class MessageGenerator
    {
        // Method to generate a simple message
        public string GenerateMessage()
        {
            // Return a simple message string
            return "Hello, this is a simple message!";
        }
    }

    // Class responsible for printing messages
    public class MessagePrinter
    {
        // Method to print a message to the console
        public void PrintMessage(string message)
        {
            // Print the message to the console
            Console.WriteLine(message);
        }
    }

    // Main program class
    public class SingleResponsibilityPrinciple
    {
        public static void Run()
        {
            // Create an instance of MessageGenerator
            MessageGenerator messageGenerator = new MessageGenerator();

            // Generate a message using the MessageGenerator instance
            string message = messageGenerator.GenerateMessage();

            // Create an instance of MessagePrinter
            MessagePrinter messagePrinter = new MessagePrinter();

            // Print the generated message using the MessagePrinter instance
            messagePrinter.PrintMessage(message);
        }
    }

}