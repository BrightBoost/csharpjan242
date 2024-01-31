using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniExercises.variables
{
    public class ShoppingList
    {
        public static void Shop()
        {
            int milkQuantity = 2; // 2 bottles of milk
            int breadQuantity = 1; // 1 loaf of bread
            int eggsQuantity = 12; // 12 eggs

            Console.WriteLine("Shopping List:");
            Console.WriteLine($"Milk: {milkQuantity} bottles");
            Console.WriteLine($"Bread: {breadQuantity} loaf");
            Console.WriteLine($"Eggs: {eggsQuantity} eggs");
        }
    }
}
