using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ExamXml
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            product.AddEvent += RecordToFile;
           
            Console.Write("Введите данные продукта\n" +
            "1) Наименование: ");
            product.Name = Console.ReadLine();
            Console.Write("2) Производитель: ");
            product.Brand = Console.ReadLine();
            product.Price = EnterPrice();

            Console.WriteLine("Нажмите клавишу S чтобы сохранить запись");

            ConsoleKeyInfo keyInfo;
            while (true)
            {
                keyInfo = Console.ReadKey(true);
                if (keyInfo.Key == ConsoleKey.S)
                {
                    product.AddProduct(product);
                }
                if (keyInfo.Key == ConsoleKey.Enter)
                {
                    break;
                }
            }
            
        }
        static void RecordToFile(Product product)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Product));
            try
            {
                using (var stream = new FileStream("products.xml", FileMode.OpenOrCreate))
                {
                    serializer.Serialize(stream, product);
                    Console.WriteLine("есть запись!");
                }
            }
            catch (InvalidOperationException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
        static double EnterPrice()
        {
            double result = 0;
            while (result == 0)
            {
                Console.Write("3) Цена: ");
                double.TryParse(Console.ReadLine(), out result);
                if (result == 0)
                    Console.WriteLine("Неправильный ввод, введите заново");
            }
            return result;
        }
    }
}