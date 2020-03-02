using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nicoline_Rasemont.Helpers
{
    public class StreamProcessingHelper
    {
        public List<char> RemoveEscaped()
        {
            General g = new General();
            string[] input = g.ReadInput("Input/streamprocessing_input.txt");
            char[] chars = input[0].ToCharArray();
            List<char> toSort = chars.ToList();
            for(int i = 0; i < chars.Length; i++)
            {
                if(chars[i].ToString() == "!")
                {
                    toSort.RemoveAt(chars[i + 1]);
                }
            }

            return toSort;

        }
        public List<char> RemoveNonsense()
        {

            List<char> chars = RemoveEscaped();
            List<Char> toDelete = new List<Char>();
            List<Char> toProcess = new List<Char>();
            int score = 0;
            for (int i = 0; i < chars.Count; i++)
            {
                if(chars[i].ToString() == "<")
                {
                    for (int j = i; j < chars.Count; j++)
                    {
                        if (chars[j].ToString() != ">")
                        {
                            toDelete.Add(chars[j]);
                            score++;
                            break;
                        }
                        break;
                    }
                }
                else
                {
                    toProcess.Add(chars[i]);
                }
            }

            return toProcess;
        }

        public int CountGroups()
        {
            List<char> chars = RemoveNonsense();
            int score = 0;
            int a = 2;
            for(int i = 0; i < chars.Count; i++)
            {
                if(chars[i].ToString() == "{")
                {
                    score++;
                    while (chars[i].ToString() != "}")
                        {
                            if (chars[i].ToString() == "{")
                            {
                                score += a;
                                a++;
                            }
                        i++;
                        }
                }
                a = 2;
            }
            return score; 
        }

        public int CountNonsense()
        {
            General g = new General();
            string[] input = g.ReadInput("Input/streamprocessing_input.txt");
            int total = input[0].Length;
            int escaped = total - RemoveEscaped().Count;
            int nonsense = total - RemoveNonsense().Count;
            int totalNonsense = escaped + nonsense;

            return totalNonsense;
        }
    }
}
