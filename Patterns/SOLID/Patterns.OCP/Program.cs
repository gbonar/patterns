using System;
using Patterns.OCP.Filters;
using Patterns.OCP.Specifications;

namespace Patterns.OCP
{
    class Program
    {
        static void Main(string[] args)
        {
            #region OCP
            var apple = new Product("Jabłko", Color.Green, Size.Small);
            var tree = new Product("Drzewo", Color.Green, Size.Large);

            var house = new Product("Dom", Color.Blue, Size.Large);
            Product[] products = { apple, tree, house };

            var bf = new BetterFilter();

            var largeGreenSpec = new ColorSpecification(Color.Green)
                                 & new SizeSpecification(Size.Large);

            foreach (var p in bf.Filter(products, largeGreenSpec))
            {
                Console.WriteLine($" - {p.Name} jest zielony");
            }
            #endregion

        }
    }
}
