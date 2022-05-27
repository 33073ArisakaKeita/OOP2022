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
            Console.WriteLine("空欄の数は{0}個", count);

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
            Console.WriteLine("テキストに含まれる単語数は{0}個", words.Length);  
        }

        private static void Exercise3_4(string text) {
            string[] words = text.Split(' ');
            Console.WriteLine("四文字以下の単語は");
            var a = words.Where(s => s.Length <= 4);
            foreach (var b in a)
                Console.WriteLine(b);
        }

        private static void Exercise3_5(string text) {
            string[] words = text.Split(' ');
            var sb = new StringBuilder();
            foreach(var word in words){
                sb.Append(word);
                sb.Append(" ");
            }
            if (sb.Length != 0)
                sb.Length -= 1; //末尾を一文字削除
            var sbtext = sb.ToString();
            Console.WriteLine(sbtext);
        }
    }
}
