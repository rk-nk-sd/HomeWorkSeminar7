using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task_002 {
    public class Task_002 {
        public static void Main(string[] args) {
            System.Console.WriteLine(Akkerman(2, 5));
        }

        public static int Akkerman(int n, int m) {
            if (n < 0 || m < 0) throw new ArgumentOutOfRangeException();
            if (n == 0) return m + 1;
            if (m == 0) return Akkerman(n - 1, m);
            return Akkerman(n - 1, Akkerman(n, m - 1));
        }
    }
}