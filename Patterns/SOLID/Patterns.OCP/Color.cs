using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.OCP
{
    public enum Color
    {
        Red, Green, Blue
    }

    public class Product
    {
        public string Name { get; }
        public Color Color { get; }
        public Size Size { get; }

        public Product(string name, Color color, Size size)
        {
            Name = name;
            Color = color;
            Size = size;
        }
    }

    public enum Size
    {
        Small, Medium, Large, Yuge
    }
}
