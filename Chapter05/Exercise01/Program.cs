using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    class Program {
        static void Main(string[] args) {
            Exercise01();
            Console.WriteLine("--------------------");

            Exercise02();
            Console.WriteLine("--------------------");
        }

        private static void Exercise01() {
            Console.Write("文字列1:");
            var str1 = Console.ReadLine();
            Console.Write("文字列2:");
            var str2 = Console.ReadLine();

            if (String.Compare(str1, str2, ignoreCase: true) == 0)
                Console.WriteLine("二つの文字列は等しい");
            else
                Console.WriteLine("二つの文字列は等しくない");
        }

        private static void Exercise02() {
            var line = Console.ReadLine();
            if (int.TryParse(line, out int result)) {//resultには変換された値が入っている。
                //Console.WriteLine(string.Format("{0,10:#,0}",result));
                Console.WriteLine("{0:#,#}", result);
            }
            else {
                Console.WriteLine("変換に失敗");
            }
            
        }

        private static void Exercise03() {
            throw new NotImplementedException();
        }

        private static void Exercise04() {
            throw new NotImplementedException();
        }
    }
}
