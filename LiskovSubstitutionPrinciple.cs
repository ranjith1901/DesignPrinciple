using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPrinciple
{

    // Interface representing flyable behavior
    public interface IFlyable
    {
        void Fly();
    }

    // Base class representing a generic bird
    public abstract class Bird
    {
        // Common properties or methods for all birds can be added here
    }

    // Class representing a sparrow, derived from Bird and implementing IFlyable
    public class Sparrow : Bird, IFlyable
    {
        // Implement the Fly method for sparrows
        public void Fly() => Console.WriteLine("Sparrow is flying");
    }

    // Class representing an ostrich, derived from Bird
    public class Ostrich : Bird
    {
        // Ostriches do not implement IFlyable because they cannot fly
    }

    // Main program class
    class LiskovSubstitutionPrinciple
    {
        public static void Run()
        {
            // Create a list to store different birds
            List<Bird> birds = new List<Bird>();

            // Add a sparrow to the list
            birds.Add(new Sparrow());

            // Add an ostrich to the list
            birds.Add(new Ostrich());

            // Iterate through each bird in the list
            foreach (var bird in birds)
            {
                // Check if the bird can fly
                if (bird is IFlyable flyableBird)
                {
                    // Make the bird fly
                    flyableBird.Fly();
                }
                else
                {
                    // Handle birds that cannot fly
                    Console.WriteLine($"{bird.GetType().Name} can't fly");
                }
            }
        }
    }
}