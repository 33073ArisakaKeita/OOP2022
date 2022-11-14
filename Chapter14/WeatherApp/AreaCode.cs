using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp {
    public class AreaCode {
        private IEnumerable<Area> _areas;//csvファイルから読み込んだデータ

        //コンストラクタ
        public AreaCode(string filePath ) {
            _areas = ReadAreas(filePath);
        }

        //売上データを読み込み、Areaオブジェクトのリストを返す
        private static IEnumerable<Area> ReadAreas(string filePath) {
            List<Area> areas = new List<Area>();
            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines) {
                string[] items = line.Split(',');
                Area area = new Area {//p105 オブジェクトの初期化
                    areaName = items[0],
                    areaCode = items[1]
                };
                areas.Add(area);
            }
            return areas;
        }

        public string getAreacode(string areaname) {
            string a = "";
            foreach(var area in _areas) {
                if (area.areaName.Equals(areaname))
                    a = area.areaCode;
            }
            return a;
        }
    }
}
