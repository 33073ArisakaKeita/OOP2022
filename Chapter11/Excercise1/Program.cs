using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Excercise1 {
    class Program {
        static void Main(string[] args) {
            var file = "Sample.xml";
            Exercise1_1("sports.xml");
            Console.WriteLine("------------");
            Exercise1_2("sports.xml");
            Console.WriteLine("------------");
            Exercise1_3("sports.xml");
            Console.WriteLine("------------");

            var newfile = "sports.xml";
            //Exercise1_4(file, newfile);

            //確認用
            var text = File.ReadAllText(newfile);
            Console.WriteLine(text);
        }

        private static void Exercise1_1(string file) {
            var xdoc = XDocument.Load(file);
            var xitem = xdoc.Root.Elements()
                                 .Select(x => new {
                                     Name = (string)x.Element("name"),
                                     Teammembers = (int)x.Element("teammembers")
                                 });
            foreach (var item in xitem) {
                Console.WriteLine("{0} {1}", item.Name, item.Teammembers);
            }
        }

        private static void Exercise1_2(string file) {
            var xdoc = XDocument.Load(file);
            var xitem = xdoc.Root.Elements()
                                .Select(x => new {
                                    KanjiName = (string)(x.Element("name").Attribute("kanji")),
                                    Firstplayed = (int)x.Element("firstplayed")
                                })
                                .OrderBy(x => x.Firstplayed);
            foreach (var item in xitem) {
                Console.WriteLine("{0}({1})", item.KanjiName, item.Firstplayed);
            }
        }

        private static void Exercise1_3(string file) {
            var xdoc = XDocument.Load(file);
            var xitem = xdoc.Root.Elements()
                                 .Select(x => new {
                                     Name = x.Element("name").Value,
                                     Teammembers = x.Element("teammembers").Value
                                 })
                                 .OrderByDescending(x => int.Parse(x.Teammembers)).FirstOrDefault();
            Console.WriteLine("{0}({1})", xitem.Name,xitem.Teammembers);
        }

        private static void Exercise1_4(string file, string newfile) {
            var element = new XElement("ballsport",
                            new XElement("name", "サッカー", new XAttribute("kanji", "蹴球")),
                            new XElement("teammembers", "11"),
                            new XElement("firstplayed", "1873"));
            var xdoc = XDocument.Load(file);
            xdoc.Root.Add(element);
            xdoc.Save(newfile);
        }
    }
}
