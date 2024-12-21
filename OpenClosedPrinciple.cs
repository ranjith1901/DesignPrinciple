using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPrinciple
{


    // Abstract base class representing a generic shape
    public abstract class Shape
    {
        // Abstract method to calculate the area of the shape
        public abstract double Area();
    }

    // Class representing a circle, derived from Shape
    public class Circle : Shape
    {
        // Property to store the radius of the circle
        public double Radius { get; set; }

        // Override the Area method to calculate the area of the circle
        public override double Area() => Math.PI * Radius * Radius;
    }

    // Class representing a rectangle, derived from Shape
    public class Rectangle : Shape
    {
        // Property to store the width of the rectangle
        public double Width { get; set; }

        // Property to store the height of the rectangle
        public double Height { get; set; }

        // Override the Area method to calculate the area of the rectangle
        public override double Area() => Width * Height;
    }

    // Main program class
    class OpenClosedPrinciple
    {
        public static void Run()
        {
            // Create a list to store different shapes
            List<Shape> shapes = new List<Shape>();

            // Add a circle with a radius of 5 to the list
            shapes.Add(new Circle { Radius = 5 });

            // Add a rectangle with a width of 4 and height of 6 to the list
            shapes.Add(new Rectangle { Width = 4, Height = 6 });

            // Iterate through each shape in the list
            foreach (var shape in shapes)
            {
                // Print the type of the shape and its area
                Console.WriteLine($"Shape: {shape.GetType().Name}, Area: {shape.Area()}");
            }
        }
    }
}