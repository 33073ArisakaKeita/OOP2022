using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.Runtime.Serialization;

namespace Exercise1 {
    [XmlRoot("employee")]
    public class Employee {
        [XmlElement(ElementName = "id")]
        public int Id { get; set; }
        [XmlElement(ElementName = "name")]
        public string Name { get; set; }
        [XmlElement(ElementName = "hiredate")]
        public DateTime HireDate { get; set; }
    }

    class Program {
        static void Main(string[] args) {
            Exercise1_1("employee.xml");
            // これは確認用
            Console.WriteLine(File.ReadAllText("employee.xml"));
            Console.WriteLine();

            Exercise1_2("employees.xml");
            Exercise1_3("employees.xml");
            Console.WriteLine();

            //Exercise1_4("employees.json");

            //// これは確認用
            //Console.WriteLine(File.ReadAllText("employees.json"));
        }

        private static void Exercise1_1(string outfile) {
            var employee = new Employee {
                Id = 123,
                Name = "木林森",
                HireDate = new DateTime(1111, 1, 11),
            };

            //シリアル化
            using (var writer = XmlWriter.Create(outfile)) {
                var serializer = new XmlSerializer(employee.GetType());
                serializer.Serialize(writer, employee);
            }
            //Display(outfile);

            //逆シリアル化
            using (var reader = XmlReader.Create(outfile)) {
                var _serializer = new XmlSerializer(typeof(Employee));
                var _employee = _serializer.Deserialize(reader) as Employee;
                // 以下、内容を確認するコード
                Console.WriteLine(_employee);
            }
        }

        private static void Exercise1_2(string outfile) {
            var employees = new Employee[] {
                new Employee{
                    Id = 100,
                    Name = "木林森",
                    HireDate = new DateTime(1111, 1, 11),
                },
                new Employee{
                    Id = 101,
                    Name = "池湖海",
                    HireDate = new DateTime(2222, 2, 22),
                }
            };

            using (var writer = XmlWriter.Create(outfile)) {
                var serializer = new XmlSerializer(employees.GetType());
                serializer.Serialize(writer, employees);
            }
            //Display(outfile);
        }

        private static void Exercise1_3(string outfile) {
            using (var reader = XmlReader.Create(outfile)) {
                var serializer = new XmlSerializer(typeof(Employee[]));
                var novels = serializer.Deserialize(reader) as Employee[];
                // 以下、内容を確認するコード
                foreach (var novel in novels) {
                    Console.WriteLine(novel);
                }
            }
        }

        private static void Exercise1_4(string outfile) {
            var employees = new Employee[] {
                new Employee{
                    Id = 100,
                    Name = "木林森",
                    HireDate = new DateTime(1111, 1, 11),
                },
                new Employee{
                    Id = 101,
                    Name = "池湖海",
                    HireDate = new DateTime(2222, 2, 22),
                }
            };
            using (var stream = new MemoryStream()) {
                //var serializer = new DataContractJsonSerializer(employees.GetType());
                
            }
        }

        private static void Display(string filename) {
            var lines = File.ReadLines(filename);
            foreach (var line in lines)
                Console.WriteLine(line);
        }
    }
}
