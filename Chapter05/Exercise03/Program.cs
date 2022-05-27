using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03 {
    class Program {
        static void Main(string[] args) {
            var text = "Jackdaws love my big sphinx of quartz";

            Exercise3_1(text);
            Console.WriteLine("---------------");

            Exercise3_2(text);
            Console.WriteLine("---------------");

            Exercise3_3(text);
            Console.WriteLine("---------------");

            Exercise3_4(text);
            Console.WriteLine("---------------");

            Exercise3_5(text);
            Console.WriteLine("---------------");
        }

        private static void Exercise3_1(String text) {
            var count = text.Count(c => c == ' ');
            Console.WriteLine("空欄の数は{0}個", count);

            //foreach(var c in text) {
            //    if(c == ' ') {
            //        count++;
            //    }
            //}
        }

        private static void Exercise3_2(String text) {
            var replaced = text.Replace("big", "small");
            Console.WriteLine(replaced);
        }

        private static void Exercise3_3(String text) {
            String[] words = text.Split(' ');
            Console.WriteLine("テキストに含まれる単語数は{0}個", words.Length);
        }

        private static void Exercise3_4(String text) {
            
        }

        private static void Exercise3_5(String text) {
            throw new NotImplementedException();
        }
    }
}
