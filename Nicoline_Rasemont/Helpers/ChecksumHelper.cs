using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nicoline_Rasemont.Helpers
{
    public class ChecksumHelper
    {

        public int Checksum()
        {
            General g = new General();
            int total = 0;
            string[] input = g.ReadInput("Input/checksum_input.txt");
            char[] chars =input[0].ToCharArray();
            int[] numbers = chars.Select(i => Int32.Parse(i.ToString())).ToArray();
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if(numbers[i] == numbers[i + 1])
                {
                    total += numbers[i + 1];
                }
            }
            if(numbers[0] == numbers[numbers.Length-1])
            {
                total += numbers[0];
            }
            return total;

        }

        public int ChecksumBonus()
        {
            General g = new General();
            int total = 0;
            string[] input = g.ReadInput("Input/checksum_input.txt");
            char[] chars = input[0].ToCharArray();
            int[] numbers = chars.Select(i => Int32.Parse(i.ToString())).ToArray();
            int middle = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(numbers.Length / 2)));
            int j = middle;
            for (int i = 0; i < middle; i++)
            {
                    if(numbers[i] == numbers[j])
                    {
                        total += numbers[i];
                    }
                j++;
            }
            //Once you start the second half of the ring the pairs will stay the same. Thus i will multiply the result of the first half by 2
            return total*2;

        }
    }
}
