using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    class Program {
        static void Main(string[] args) {
            var ym = new YearMonth(2017, 8);
            var test =  ym.AddOneMonth();
            var check = ym.Is21Century;
            Console.WriteLine(ym);
        }
    }
}