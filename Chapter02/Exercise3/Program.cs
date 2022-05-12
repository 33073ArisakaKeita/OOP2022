using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3 {
    class Program {
        static void Main(string[] args) {
            var sales = new SalesCounter("sales.csv");
            var amountPerProduct = sales.GetPerProductSales();
            foreach (var obj in amountPerProduct) {
                Console.WriteLine("{0}{1}", obj.Key, obj.Value);
            }
        }
    }
}
