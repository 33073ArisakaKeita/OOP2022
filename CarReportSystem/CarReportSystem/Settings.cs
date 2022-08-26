﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CarReportSystem {
    //設定情報
    public class Settings {
        public int MainFormColor { get; set; }
        private static Settings settings;

        //コンストラクタ
        private Settings() {
            //Console.WriteLine("インスタンスを生成しました。");
        }

        public static Settings getInstance() {
            if (settings == null)
                settings = new Settings();
            return settings;
        }
    }
}
