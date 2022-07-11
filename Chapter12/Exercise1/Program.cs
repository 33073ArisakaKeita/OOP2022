using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.Runtime.Serialization.Json;
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

        public override string ToString() {
            return string.Format("[Id={0}, Name={1}, HireDate={2}]",
                                  Id, Name, HireDate);
        }
    }
    [DataContract(Name = "employee2")]
    public class Employee2 {

        public int Id { get; set; }
        [DataMember(Name = "name")]
        public string Name { get; set; }
        [DataMember(Name = "hiredate")]
        public DateTime HireDate { get; set; }
    }

    class Program {
        static void Main(string[] args) {
            Exercise1_1("employee.xml");
            // これは確認用
            //Console.WriteLine(File.ReadAllText("employee.xml"));
            Console.WriteLine();

            Exercise1_2("employees.xml");
            Exercise1_3("employees.xml");
            Console.WriteLine();

            Exercise1_4("employees.json");

            //// これは確認用
            Console.WriteLine(File.ReadAllText("employees.json"));
        }

        private static void Exercise1_1(string outfile) {
            var employee = new Employee {
                Id = 100,
                Name = "田中太郎",
                HireDate = new DateTime(2000, 1, 1),
            };

            //シリアル化
            using (var writer = XmlWriter.Create(outfile)) {
                var serializer = new XmlSerializer(employee.GetType());
                serializer.Serialize(writer, employee);
            }
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
                    Name = "田中太郎",
                    HireDate = new DateTime(2000, 1, 1),
                },
                new Employee{
                    Id = 101,
                    Name = "鈴木次郎",
                    HireDate = new DateTime(2001, 2, 12),
                }
            };
            var settings = new XmlWriterSettings {
                Encoding = new System.Text.UTF8Encoding(false),
                Indent = true,
                IndentChars = "  ",
            };

            using (var writer = XmlWriter.Create(outfile,settings)) {
                var serializer = new XmlSerializer(employees.GetType());
                serializer.Serialize(writer, employees);
            }
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
            var employees = new Employee2[] {
                new Employee2{
                    Id = 100,
                    Name = "田中太郎",
                    HireDate = new DateTime(2000, 1, 1),
                },
                new Employee2{
                    Id = 101,
                    Name = "鈴木次郎",
                    HireDate = new DateTime(2001, 2, 12),
                }
            };
            using (var stream = new FileStream(outfile, FileMode.Create,
                                                FileAccess.Write)) {
                var serializer = new DataContractJsonSerializer(employees.GetType(),new DataContractJsonSerializerSettings {
                    DateTimeFormat = new DateTimeFormat("yyyy-MM-dd")
                });
                serializer.WriteObject(stream, employees);
            }
        }
    }
}