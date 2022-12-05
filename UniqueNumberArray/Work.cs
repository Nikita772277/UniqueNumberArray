using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqueNumberArray
{
    public class Work
    {
        public void DifferingNumber(int[] ints)
        {
            if (ints.Length % 2 == 0)
            {

            }
            else
            {
                int numberDiffering = 0;
                for (int i = 0; i < ints.Length; i++)
                {
                    int counter = 0;
                    foreach (int c in ints)
                    {
                        if (ints[i] == c)
                        {
                            counter++;
                        }
                    }
                    if (counter == 1)
                    {
                        numberDiffering = ints[i];
                    }
                }
                Console.WriteLine(numberDiffering);
            }
        }
    }
}
