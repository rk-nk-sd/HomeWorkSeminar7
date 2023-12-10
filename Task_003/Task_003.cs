using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task_003
{
    public class Task_003
    {
        public static void Main(string[] args) {
            char[] charArray = "Hello, World!!!".ToCharArray();

            System.Console.WriteLine(GetReversArray(charArray.Length-1, charArray));
        }

        public static string GetReversArray(int index, char[] array) {
            if(index < 0) return "";
            return array[index] + GetReversArray(--index, array);
        }
    }
}