using Entities;
using Entities.Enums;
using System;
using System.Collections.Generic;

namespace Heranca4_CSharp {
    class Program {
        static void Main(string[] args) {
            List<Shape> shapes = new List<Shape>();

            Console.Write("Enter the number of shapes: ");
            int numberOfShapes = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numberOfShapes; i++) {
                Console.WriteLine("\nShape number " + i + " data:");
                Console.Write("Rectangle or Circle (r/c)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Color (Black/Blue/Red): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());
                if (ch == 'r') {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine());
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine());
                    shapes.Add(new Rectangle(width, height, color));
                }
                else {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine());
                    shapes.Add(new Circle(radius, color));
                }

            }
            Console.WriteLine("\nSHAPE AREAS:");
            foreach (Shape item in shapes) {
                Console.WriteLine(item.Area().ToString("F2"));
            }
        }
    }
}
