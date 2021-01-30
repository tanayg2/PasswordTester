using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace StringAnalysisService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public static List<char> vowels = new List<char>() { 'a', 'e', 'i', 'o', 'u' };

        /// <summary>
        /// Returns input string reversed
        /// </summary>
        /// <param name="word"></param>
        /// <returns>Reversed string</returns>
        public string Reverse(string word)
        {
            char[] charArray = word.ToCharArray();
            Array.Reverse(charArray);
            return new string (charArray);
        }

        /// <summary>
        /// Returns how many upper case letters there are in input string
        /// </summary>
        /// <param name="word"></param>
        /// <returns>Number of uppercase chars</returns>
        public int UpperCaseCount(string word)
        {
            string lowerWord = word.ToLower();
            int count = 0;

            //Iterates through string and increments count var when lowercase'd char is not equal to equivalent char from original word (meaning it was uppercase)
            for (int i=0; i<word.Length; i++)
            {
                if (!lowerWord[i].Equals(word[i]))
                {
                    count++;
                }
            }

            return count;
        }

        /// <summary>
        /// Returns how many vowels are in input string (excluding 'y')
        /// </summary>
        /// <param name="word"></param>
        /// <returns>Number of vowels</returns>
        public int VowelCount(string word)
        {
            string lowerWord = word.ToLower();
            int vowelCount = 0;
            //Iterates over each character in string and increments vowelCount when the char is in 'vowels' List (class variable)
            foreach (char letter in lowerWord)
            {
                if (vowels.Contains(letter))
                {
                    vowelCount++;
                }
            }
            return vowelCount;
        }
    }
}
