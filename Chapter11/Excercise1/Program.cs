using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Excercise1 {
    class Program {
        static void Main(string[] args) {
            var file = "sample.xml";
            Exercise1_1(file);
            Console.WriteLine();
            Exercise1_2(file);
            Console.WriteLine();
            Exercise1_3(file);
            Console.WriteLine();

            var newfile = "sports.xml";
            //Exercise1_4(file, newfile);
        }

        private static void Exercise1_1(string file) {
            var xdoc = XDocument.Load(file);
            var xitem = xdoc.Root.Elements()
                                 .Select(x => new {
                                     Name = (string)x.Element("name"),
                                     Teammembers = (int)x.Element("teammembers")
                                 });
            foreach (var item in xitem) {
                Console.WriteLine("{0} {1}",item.Name ,item.Teammembers);
            }
        }

        private static void Exercise1_2(string file) {
            var xdoc = XDocument.Load(file);
            var xitem = xdoc.Root.Elements()
                                .Select(x => new {
                                    KanjiName = (string)(x.Element("name").Attribute("kanji")),
                                    Firstplayed = (int)x.Element("firstplayed")
                                })
                                .OrderByDescending(x => x.Firstplayed);
            foreach (var item in xitem) {
                Console.WriteLine("{0}({1})", item.KanjiName, item.Firstplayed);
            }
        }

        private static void Exercise1_3(string file) {
            var xdoc = XDocument.Load(file);
            var xitem = xdoc.Root.Elements()
                                 .Select(x => new {
                                     Name = (string)x.Element("name"),
                                     Teammembers = (int)x.Element("teammembers")
                                 });
            foreach (var item in xitem) {
                Console.WriteLine("{0}", item.Name);
            }

        }

        private static void Exercise1_4(string file, string newfile) {
            var element = new XElement("ballsports",
                            new XElement("name", "サッカー", new XAttribute("kanji", "蹴球")),
                            new XElement("teammembers", "9"),
                            new XElement("firstplayed", "1873"));
            var xdoc = XDocument.Load("newfile");
            xdoc.Root.Add(element);
            //確認用
        }
    }
}
