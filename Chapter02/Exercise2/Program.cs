using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2 {
    class Program {
        static void Main(string[] args) {
            if (args.Length >= 1 && args[0] == "-tom") {
                // インチからメートルへの対応表を出力
                PrintInchToMeterList(1, 10);
            }
            else if(args.Length >= 1 && args[0] == "-toi") {
                // メートルからインチへの対応表を出力
                PrintMeterToInchList(1, 10);
            }
        }
        //インチからメートルへの対応表を出力
        private static void PrintInchToMeterList(int start, int stop) {
            for (int inch = start; inch <= stop; inch++) {
                double meter = InchConverter.ToMeter(inch);
                Console.WriteLine("{0} in = {1:0.0000} m", inch, meter);
            }
        }
        //メートルからインチへの対応表を出力
        private static void PrintMeterToInchList(int start, int stop) {
            for (int meter = 1; meter <= 10; meter++) {
                double Inch = InchConverter.FromMeter(meter);
                Console.WriteLine("{0} m = {1:0.0000} in", meter, Inch);
            }
        }
    }
}
