﻿using System;
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
            var books = Library.Books
                               .OrderByDescending(b => b.PublishedYear)
                               .ThenByDescending(b => b.Price)
                               .Join(Library.Categories,
                                    book => book.CategoryId,
                                    category => category.Id,
                                    (book, category) => new {
                                        Title = book.Title,
                                        Category = category.Name,
                                        PublishedYear = book.PublishedYear,
                                        Price = book.Price
                                    }
                                );
            foreach (var book in books) {
                Console.WriteLine($"{book.PublishedYear}年  {book.Price}円  {book.Title}({book.Category})");

            }
        }

        private static void Exercise1_5() {
            var categories = Library.Books
                               .Where(b=>b.PublishedYear == 2016)
                               .Join(Library.Categories,
                                    book => book.CategoryId,
                                    category => category.Id,
                                    (book, category) => category.Name)
                               .Distinct();
            foreach (var category in categories) {
                Console.WriteLine(category);
            }

        }

        private static void Exercise1_6() {
            var books = Library.Books
                               .Join(Library.Categories,
                                    book => book.CategoryId,
                                    category => category.Id,
                                    (book, category) => new {
                                        Title = book.Title,
                                        Category = category.Name,
                                        PublishedYear = book.PublishedYear,
                                        Price = book.Price
                                    }
                                )
                               .GroupBy(b => b.Category)
                               .OrderBy(b => b.Key);
            foreach (var categories in books) {
                Console.WriteLine($"#{categories.Key}");
                foreach (var book in categories) {
                    Console.WriteLine($" {book.Title}");
                }
            }
        }

        private static void Exercise1_7() {
            //var books = Library.Books
            //                   .Join(Library.Categories,
            //                        book => book.CategoryId,
            //                        category => category.Id,
            //                        (book, category) => new {
            //                            Title = book.Title,
            //                            Category = category.Name,
            //                            PublishedYear = book.PublishedYear,
            //                            Price = book.Price
            //                        }
            //                    )
            //                   .Where(b=>b.Category.Equals("Development"))
            //                   .GroupBy(b=> b.PublishedYear)
            //                   .OrderBy(b=> b.Key);
            //foreach (var years in books) {
            //    Console.WriteLine($"#{years.Key}");
            //    foreach (var book in years) {
            //        Console.WriteLine($" {book.Title}");
            //    }
            //}
            var CategoryId = Library.Categories.Single(c => c.Name == "Development").Id;
            var books = Library.Books
                               .Where(b => b.CategoryId == CategoryId)
                               .GroupBy(b => b.PublishedYear)
                               .OrderBy(b => b.Key);
            foreach (var group in books) {
                Console.WriteLine($"#{group.Key}");
                foreach (var book in group) {
                    Console.WriteLine($" {book.Title}");
                }
            }

        }

        private static void Exercise1_8() {
            var groups = Library.Categories
                                .GroupJoin(Library.Books,
                                    c => c.Id,
                                    b => b.CategoryId,
                                    (c, books) => new {
                                        Category = c.Name,
                                        Count = books.Count()
                                    })
                                .Where(x => x.Count >= 4);
            foreach (var obj in groups) {
                Console.WriteLine(obj.Category);

            }
        }
    }
}
