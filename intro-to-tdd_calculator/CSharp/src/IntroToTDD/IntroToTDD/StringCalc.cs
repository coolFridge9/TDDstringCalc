using System;
using System.Collections.Generic;

namespace IntroToTDD
{
    public class StringCalc
    {   
        
        public int Add(string numbers)
        {
            if (numbers=="")
            {
                return 0;
            }
            string[] set_of_numbers = numbers.Split(',');
            int sum = 0;

            foreach(string num in set_of_numbers)
            {
                sum += Int32.Parse(num);
            }
            
            return sum;
        }
    }
}