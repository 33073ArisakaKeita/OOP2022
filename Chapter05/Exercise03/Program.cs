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

        private static void Exercise3_1(string text) {
            var count = text.Count(c => c == ' ');
            Console.WriteLine("空欄数:{0}", count);

            //foreach(var c in text) {
            //    if(c == ' ') {
            //        count++;
            //    }
            //}
        }

        private static void Exercise3_2(string text) {
            var replaced = text.Replace("big", "small");
            Console.WriteLine(replaced);
        }

        private static void Exercise3_3(string text) {
            string[] words = text.Split(' ');
            Console.WriteLine("単語数:{0}", words.Length);  
        }

        private static void Exercise3_4(string text) {
            Console.WriteLine("四文字以下の単語");
            text.Split(' ').Where(word => word.Length <= 4)
                                       .ToList().ForEach(word =>Console.WriteLine(word));
        }

        private static void Exercise3_5(string text) {
            string[] words = text.Split(' ');
            var sb = new StringBuilder();
            foreach(var word in words){
                sb.Append(" ");
                sb.Append(word);
            }
            var sbtext = sb.ToString().TrimStart();
            Console.WriteLine(sbtext);
        }
    }
}
