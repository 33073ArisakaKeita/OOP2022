﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    class Program {
        static void Main(string[] args) {
            var names = new List<string> {
               "Tokyo", "New Delhi", "Bangkok", "London", "Paris", "Berlin", "Canberra", "Hong Kong",
            };

            Exercise2_1(names);
            Console.WriteLine("----------------");
            Exercise2_2(names);
            Console.WriteLine("----------------");
            Exercise2_3(names);
            Console.WriteLine("----------------");
            Exercise2_4(names);
        }

        private static void Exercise2_1(List<string> names) {
            Console.WriteLine("都市名を入力。空行で終了");
            do {
                var line = Console.ReadLine();
                if (string.IsNullOrEmpty(line))
                    break;
                var index = names.FindIndex(s => s == line);
                Console.WriteLine(index);
            } while (true);
        }

        private static void Exercise2_2(List<string> names) {
            var count = names.Count(s => s.Contains('o'));
            Console.WriteLine(count);
        }

        private static void Exercise2_3(List<string> names) {
            var array = names.Where(s => s.Contains('o')).ToArray();//配列に変換
            foreach (var name in array)
                Console.WriteLine(name);
        }

        private static void Exercise2_4(List<string> names) {
            var a = names.Where(s => s.StartsWith("B"))
                         //.Select(s => s+":"+s.Length);
                         .Select(s => new { s.Length, s });
            foreach (var b in a)
                Console.WriteLine(b.Length+":"+b.s);
        }
    }
}
