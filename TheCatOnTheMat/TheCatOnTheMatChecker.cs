using System;
using System.Collections.Generic;
using System.Linq;

namespace TheCatOnTheMat
{
    public class TheCatOnTheMatChecker
    {
        public  static string TheCatOnTheMat(string sentence)
        {

            List<string> words = new List<string>();
            words = sentence.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToList();

            int prevCounter = 0;
            string result = string.Empty;
            foreach (var word in words)
            {

                int currentCounter = 0;
                foreach (var compareWord in words)
                {
                    if (word.Equals(compareWord))
                    {
                        currentCounter++;
                    }
                }

                if (currentCounter > prevCounter)
                {
                    prevCounter = currentCounter;
                    result = word;
                }
            }

            return result;
        }
    }
}
