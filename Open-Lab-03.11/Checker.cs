using System;

namespace Open_Lab_03._11
{
    public class Checker
    {
        public bool IsPalindrome(string str)
        {
            string firsthalf = str.Substring(0, str.Length / 2);
            char[] array = str.ToCharArray();

            Array.Reverse(array);

            string reversedstr = new string(array);
            string secondhalf = reversedstr.Substring(0, reversedstr.Length / 2);

            return firsthalf == secondhalf;
        } 
    }
}
