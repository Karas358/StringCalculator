using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculator
{
    /// <summary>
    /// String calculator
    /// Add all numbers is a string
    /// </summary>
    public class StringAddition
    {
    
        public int AddString(string numbers)
        {
            if(String.IsNullOrEmpty(numbers)) return 0;
            else
            {
                List<string> numStrings = splitString(numbers);
                List<int> numInts = convertStringsToInts(numStrings);
                checkForNegatives(numInts);
                return numInts.Sum();
            }
        }

        public void checkForNegatives(List<int> numInts)
        {
            List<int> negativeInts = numInts.Where(i => i < 0).ToList();
            if (negativeInts.Count > 0) 
                throw new Exception("Negative Numbers Are Not Allowed: " + string.Join(",", negativeInts));
        }

        public List<string> splitString(string numbers)
        {
            //Split string with new delimeter if exits
            if (numbers.StartsWith("//"))
            {
                char delimeter = numbers[2];
                numbers = numbers.Substring(4);
                return numbers.Split(delimeter).ToList<string>();
            }
            return numbers.Split(',','\n').ToList<string>();
        }
        

        public List<int> convertStringsToInts(List<string> numStrings)
        {
            List<int> exportNums = new List<int>();
            foreach(String currNumString in numStrings)
            {
                exportNums.Add(StringToInt(currNumString));
            }
            return exportNums;
        }

        public int StringToInt(String num){
            return Int32.Parse(num);
        }
    }
}
