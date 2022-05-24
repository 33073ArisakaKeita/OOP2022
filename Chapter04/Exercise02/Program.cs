using Exercise01;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    class Program {
        static void Main(string[] args) {
            //4.2.1
            var ymCollection = new YearMonth[] {
                new YearMonth(1900,3),
                new YearMonth(1999,4),
                new YearMonth(2010,5),
                new YearMonth(2000,7),
                new YearMonth(1000,8),
            };

            //4.2.2
            Exercise2_2(ymCollection);
            Console.WriteLine("-----");

            //4.2.4
            Exercise2_4(ymCollection);
            Console.WriteLine("-----");

            //4.2.5
            Exercise2_5(ymCollection);
            Console.WriteLine("-----");

            //4.2.5を降順にしたい場合
            Exercise2_6(ymCollection);
        }

        private static void Exercise2_6(YearMonth[] ymCollection) {
            foreach (var ym in ymCollection.OrderByDescending(ym => ym.Year)) {
                Console.WriteLine(ym);
            }
            
        }

        //4.2.3
        static YearMonth FindFirst21C(YearMonth[] yms) {
            foreach (var ym in yms) {
                if (ym.Is21Century) {
                    return ym;
                }
            }
            return null;
        }

        private static void Exercise2_2(YearMonth[] ymCollection) {
            foreach (var ym in ymCollection) {
                Console.WriteLine(ym);
            }
        }

        private static void Exercise2_4(YearMonth[] ymCollection) {
            var _21c = FindFirst21C(ymCollection);
            if (_21c != null)
                Console.WriteLine(_21c);
            else
                Console.WriteLine("21世紀のデータはありません");
        }

        private static void Exercise2_5(YearMonth[] ymCollection) {
            var array = ymCollection.Select(ym => ym.AddOneMonth());
            foreach(var ym in array) {
                Console.WriteLine(ym);
            }
        }
    }
}