using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesCalculator {
    //売上集計クラス
    public class SalesCounter {
        private IEnumerable<Sale> _sales;//csvファイルから読み込んだデータ

        //コンストラクタ
        public SalesCounter(String filePath) {
            _sales = ReadSales(filePath);
            
        }

        //売上データを読み込み、Saleオブジェクトのリストを返す
        private static IEnumerable<Sale> ReadSales(String filePath) {
            List<Sale> sales = new List<Sale>();
            String[] lines = File.ReadAllLines(filePath);
            foreach (String line in lines) {
                String[] items = line.Split(',');
                Sale sale = new Sale {//p105 オブジェクトの初期化
                    ShopName = items[0],
                    ProductCategory = items[1],
                    Amount = int.Parse(items[2])
                };
                sales.Add(sale);
            }
            return sales;
        }

        //店舗別売り上げを求める
        public IDictionary<String, int> GetPerStoreSales() {
            var dict = new Dictionary<String, int>();
            foreach (var sale in _sales) {
                if (dict.ContainsKey(sale.ShopName))
                    dict[sale.ShopName] += sale.Amount;
                else
                    dict[sale.ShopName] = sale.Amount;
            }
            return dict;
        }
    }
}
