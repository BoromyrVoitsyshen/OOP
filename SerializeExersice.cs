using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;

namespace ConsoleApp1
{
    public class PublishingHouse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }

    public class Book
    {
        [JsonIgnore]//2.
        public int PublishingHouseId { get; set; }

        [JsonPropertyName("Title")]//3. замінити тут Title на Name
        public string Title { get; set; }

        [JsonPropertyName("PublishingHouseId")]
        public PublishingHouse PublishingHouse { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            var publishingHouse1 = new PublishingHouse()
            {
                Id = 1,
                Name = "name1",
                Address = "address1"
            };
            var publishingHouse2 = new PublishingHouse()
            {
                Id = 2,
                Name = "name1",
                Address = "address2"
            };
            var book1 = new Book()
            {
                PublishingHouseId = publishingHouse2.Id,
                Title = "book1",
                PublishingHouse = publishingHouse2
            };
            var book2 = new Book()
            {
                PublishingHouseId = publishingHouse1.Id,
                Title = "book2",
                PublishingHouse = publishingHouse1
            };
            var book3 = new Book()
            {
                PublishingHouseId = publishingHouse2.Id,
                Title = "book3",
                PublishingHouse = publishingHouse2
            };

            var books1 = new List<Book> { book1, book2, book3 };

            string path = @"C:\Users\boris\source\repos\ConsoleApp1\ConsoleApp1\output.json";

            var options1 = new JsonSerializerOptions()
            {
                WriteIndented = true,
                DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingDefault
            };

            using (FileStream fstream = new FileStream(path, FileMode.Create))
            {
                JsonSerializer.Serialize(fstream, books1, options1);
                Console.WriteLine("Записано у файл");
            }
            string inputPath = @"C:\Users\boris\source\repos\ConsoleApp1\ConsoleApp1\output.json";

            List<Book> books = new List<Book>();

            if (File.Exists(inputPath))
            {
                var options = new JsonSerializerOptions()
                {
                    WriteIndented = true,
                    DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingDefault
                };

                using (FileStream inputFileStream = new FileStream(inputPath, FileMode.Open))
                {
                    books = JsonSerializer.DeserializeAsync<List<Book>>(inputFileStream, options).Result;
                }

                if (books != null)
                {
                    foreach (var book in books)
                    {
                        Console.WriteLine(System.Text.Json.JsonSerializer.Serialize(book));
                    }
                }
                else
                {
                    Console.WriteLine("Не вдалося зчитати дані з файлу.");
                }
            }
            else
            {
                Console.WriteLine("Файл не існує.");
            }

            Console.ReadKey();
        }

    }
}
