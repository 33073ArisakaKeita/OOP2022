using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1 {
    class Program {
        static void Main(string[] args) {

            Exercise1_2();
            Console.WriteLine();
            Exercise1_3();
            Console.WriteLine();
            Exercise1_4();
            Console.WriteLine();
            Exercise1_5();
            Console.WriteLine();
            Exercise1_6();
            Console.WriteLine();
            Exercise1_7();
            Console.WriteLine();
            Exercise1_8();

            Console.ReadLine();
        }

        private static void Exercise1_2() {
            foreach (var book in Library.Books) {
                if (Library.Books.Max(b => b.Price) == book.Price)
                    Console.WriteLine($" {book.CategoryId},{book.PublishedYear}年,{book.Title},{book.Price}円");
            }
        }

        private static void Exercise1_3() {
            var groups = Library.Books
                                .GroupBy(b => b.PublishedYear)
                                .OrderBy(g => g.Key);
            foreach (var group in groups) {
                Console.WriteLine($"{group.Key}　{group.Count()}冊");
            }
        }

        private static void Exercise1_4() {
        }

        private static void Exercise1_5() {
        }

        private static void Exercise1_6() {
        }

        private static void Exercise1_7() {
        }

        private static void Exercise1_8() {
        }
    }
}
