using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Nicoline_Rasemont.Helpers
{
    public class ValidatorHelper
    {

        public int ValidateInput()
        {
            General g = new General();
            string[] input = g.ReadInput("Input/Validator_input.txt");
            int notvalid = 0;
            bool valid = true;
            int score = 0;
            for (int i = 0; i < input.Length; i++)
            {
                valid = true;
                string[] words = input[i].Split(" ");
                for(int j = 0; j < words.Length; j++)
                {
                    if (valid == false)
                    {
                        break;
                    }
                    for (int k = j+1; k < words.Length; k++)
                    {
                        if(words[k].Length == words[j].Length)
                    {
                        char[] charactersj = words[j].ToCharArray();
                        char[] charactersk = words[k].ToCharArray();
                        
                        foreach(char cj in charactersj)
                        {
                            if(charactersk.Contains(cj))
                            {
                                score++;
                            }
                            
                        }
                        if (score == words[k].Length)
                        {
                            notvalid++;
                            score = 0;
                            valid = false;
                            break;
                        }
                        else
                            {
                                score = 0;
                            }
                    }
                    
                    }

                }
            }
            
            return input.Length - notvalid;
        }                    
    }
}
