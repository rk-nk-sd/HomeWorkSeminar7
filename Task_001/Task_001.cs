using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task_001 {
    public class Task_001 {
        public const int M = 7;
        public const int N = 15;
        public static void Main(string[] args) {
            System.Console.WriteLine(GetNuturalInRange(M,N));
        }

        public static string GetNuturalInRange(int start,int end) {
            string result = "";
            if(end < start) return result;
            if(start == 0) {
                result = GetNuturalInRange(start + 1, end);
            } else {
                result = start + GetNuturalInRange(start + 1, end);
            }
            return result;
        }
    }
}