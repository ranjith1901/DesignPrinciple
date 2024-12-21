using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPrinciple
{

    // Interface representing a message sender
    public interface IMessageSender
    {
        // Method to send a message
        void SendMessage(string message);
    }

    // Class representing an email sender, implementing IMessageSender
    public class EmailSender : IMessageSender
    {
        // Implement the SendMessage method to send an email
        public void SendMessage(string message) => Console.WriteLine("Email sent: " + message);
    }

    // Class representing an SMS sender, implementing IMessageSender
    public class SmsSender : IMessageSender
    {
        // Implement the SendMessage method to send an SMS
        public void SendMessage(string message) => Console.WriteLine("SMS sent: " + message);
    }

    // High-level module representing a notification
    public class Notification
    {
        // Dependency on the abstraction IMessageSender
        private readonly IMessageSender _messageSender;

        // Constructor to inject the dependency
        public Notification(IMessageSender messageSender)
        {
            _messageSender = messageSender;
        }

        // Method to send a notification
        public void Send(string message) => _messageSender.SendMessage(message);
    }

    // Main program class
    class DependencyInversionPrinciple
    {
        public static void Run()
        {
            // Create an instance of EmailSender
            IMessageSender emailSender = new EmailSender();

            // Create an instance of Notification with EmailSender
            Notification emailNotification = new Notification(emailSender);
            emailNotification.Send("Hello via Email!"); // Output: Email sent: Hello via Email!

            // Create an instance of SmsSender
            IMessageSender smsSender = new SmsSender();

            // Create an instance of Notification with SmsSender
            Notification smsNotification = new Notification(smsSender);
            smsNotification.Send("Hello via SMS!"); // Output: SMS sent: Hello via SMS!
        }
    }
}