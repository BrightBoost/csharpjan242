using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsEnzo
{
    internal class OpdrachtArray
    {
        /*Create an array of ints of your favorite numbers

Change the value of the second one in the array

Sort them 

Print them (you can use regular for or foreach)

Can you add 1 to every element in the array? 

Can you add a number?
Bonus: can you sort them in reversed order?
*/
        public void Opdracht()
        {
            int[] ints = { 42, 27, 12, 91 };
            ints[1] = 26;
            Array.Sort(ints);

            foreach(int i in ints)
            {
                Console.WriteLine(i);
            }

            for(int i =  0; i < ints.Length; i++)
            {
                ints[i] = ints[i] + 1;
                Console.WriteLine(i);
            }

            // add a number 
            Array.Resize(ref ints, ints.Length + 1);
            ints[ints.Length - 1] = 27;
            Array.Reverse(ints); // saaie oplossing
            Array.Sort(ints, (x, y) => y - x);

            foreach (int i in ints)
            {
                Console.WriteLine(i);
            }
        }
    }
}
