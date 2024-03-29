﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    class Program {

        static void Main(string[] args) {
            var list = new List<string> {
               "Tokyo", "New Delhi", "Bangkok", "London", "Paris", "Berlin", "Canberra", "Hong Kong",
            };
            //FindAllメソッド
            //var names = list.FindAll(s => s.Length <= 5);
            //names.ForEach(s => Console.WriteLine(s));

            //list.ForEach(s => Console.WriteLine(s));

            //RemoveAllメソッド
            //var removedCount = list.RemoveAll(s => s.Contains("on"));
            //Console.WriteLine(removedCount);
            //list.ForEach(s => Console.WriteLine(s));

            var lowerList = list.ConvertAll(s => s.ToLower());
            lowerList.ForEach(s => Console.WriteLine(s));


            //foreach(var s in names) {
            //    Console.WriteLine(s);
            //}

        }
    }
}
