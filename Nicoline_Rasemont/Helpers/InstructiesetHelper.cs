using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nicoline_Rasemont.Helpers
{
    public class InstructiesetHelper
    {
        public int GetMaxValue()
        {
            General g = new General();
            string[] input = g.ReadInput("Input/instructieset_input.txt");
            Dictionary<string, int> operator1 = new Dictionary<string, int>();

            for (int i = 0; i < input.Length; i++)
            {
                var regel = input[i];
                string[] split = regel.Split(" ");
                if (operator1.ContainsKey(split[4]) != true)
            {
                    operator1.Add(split[4], 0);
            }
            {

            }
                string comperator = split[5];
                int op2 = Convert.ToInt32(split[6]);
                bool result = CheckComparison(operator1[split[4]], op2, comperator);

                if(result == true)
                {
                    if (operator1.ContainsKey(split[0]) == true)
                    {
                        string operation = split[1];
                        switch (operation)
                        {
                            case "inc":
                                {
                                    operator1[split[0]] += Convert.ToInt32(split[2]);
                                    break;
                                };
                            case "dec":
                                {
                                    operator1[split[0]] -= Convert.ToInt32(split[2]);
                                    break;
                                }

                        }
                    }
                    else
                    {
                        operator1.Add(split[0], 0);
                        string operation = split[1];
                        switch(operation)
                        {
                            case "inc":
                                {
                                    operator1[split[0]] += Convert.ToInt32(split[2]);
                                    break;
                                };
                            case "dec":
                                {
                                    operator1[split[0]] -= Convert.ToInt32(split[2]);
                                    break;
                                }
                        }
                        
                    }
                    }
                }
            return operator1.Values.Max();
            }


        public int GetAllTimeMaxValue()
        {
            General g = new General();
            string[] input = g.ReadInput("Input/instructieset_input.txt");
            Dictionary<string, int> operator1 = new Dictionary<string, int>();
            int allTimeValue = 0;

            for (int i = 0; i < input.Length; i++)
            {
                var regel = input[i];
                string[] split = regel.Split(" ");
                if (operator1.ContainsKey(split[4]) != true)
                {
                    operator1.Add(split[4], 0);
                }
                {

                }
                string comperator = split[5];
                int op2 = Convert.ToInt32(split[6]);
                bool result = CheckComparison(operator1[split[4]], op2, comperator);

                if (result == true)
                {
                    if (operator1.ContainsKey(split[0]) == true)
                    {
                        string operation = split[1];
                        switch (operation)
                        {
                            case "inc":
                                {
                                    operator1[split[0]] += Convert.ToInt32(split[2]);
                                    break;
                                };
                            case "dec":
                                {
                                    operator1[split[0]] -= Convert.ToInt32(split[2]);
                                    break;
                                }

                        }
                    }
                    else
                    {
                        operator1.Add(split[0], 0);
                        string operation = split[1];
                        switch (operation)
                        {
                            case "inc":
                                {
                                    operator1[split[0]] += Convert.ToInt32(split[2]);
                                    break;
                                };
                            case "dec":
                                {
                                    operator1[split[0]] -= Convert.ToInt32(split[2]);
                                    break;
                                }
                        }

                    }
                }
                int maxValue = operator1.Values.Max();
                if(allTimeValue < maxValue)
                {
                    allTimeValue = maxValue;
                }
            }
            return allTimeValue;
        }


        public bool CheckComparison(int op1, int op2, string comperator)
        {
            switch (comperator)
            {
                case "==":
                    {
                        if (op1 == op2)
                        {
                            return true;
                        }
                        else
                        {
                            return false; 
                        };
                    } 
                case "!=":
                    {
                        if (op1 != op2)
                        {
                            return true;
                        }
                        else
                        {
                            return false; 
                        };
                    }  
                case "<":
                    {
                        if (op1 < op2)
                        {
                            return true;
                        }
                        else
                        {
                            return false; 
                        };
                    }     
                case "<=":
                    {
                        if (op1 <= op2)
                        {
                            return true;
                        }
                        else
                        {
                            return false; 
                        };
                    }  
                case ">":
                    {
                        if (op1 > op2)
                        {
                            return true;
                        }
                        else
                        {
                            return false; 
                        };
                    } 
                case ">=":
                    {
                        if (op1 >= op2)
                        {
                            return true;
                        }
                        else
                        {
                            return false; 
                        };
                    }
            }
            return false; 
        }
    }
}
