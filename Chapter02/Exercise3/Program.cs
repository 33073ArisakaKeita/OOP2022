using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("売上高の表示選択");
            Console.WriteLine("1.店舗別");
            Console.WriteLine("2.商品カテゴリー別");

            int i = int.Parse(Console.ReadLine());

            if (i == 1) {
                PrintStoreSales();
            }
            else if (i == 2) {
                PrintProductSales();
            }            
        }

        //店舗別　表示メソッド
        private static void PrintStoreSales() {
            var sales = new SalesCounter("sales.csv");
            var amountPerStore = sales.GetPerStoreSales();
            foreach (var obj in amountPerStore) {
                Console.WriteLine("{0}{1}", obj.Key, obj.Value);
            }
        }

        //商品別　表示メソッド
        private static void PrintProductSales() {
            var sales = new SalesCounter("sales.csv");
            var amountPerProduct = sales.GetPerProductSales();
            foreach (var obj in amountPerProduct) {
                Console.WriteLine("{0}{1}", obj.Key, obj.Value);
            }
        }
    }
}
