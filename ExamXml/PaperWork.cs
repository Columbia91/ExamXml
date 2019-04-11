using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamXml
{
    class PaperWork
    {
        /*
         1) Можно ли изменить строку
         
            string source = "The mountains are behind the clouds today.";

            var replacement = source.Replace("mountains", "peaks");

            Исходная строка не изменяется. Возвращается новая строка с заменой.

        2) Рефлексия
            Рефлексия представляет собой процесс выявления типов во время выполнения приложения. Каждое приложение 
            содержит набор используемых классов, интерфейсов, а также их методов, свойств и прочих кирпичиков, 
            из которых складывается приложение. И рефлексия как раз и позволяет определить все эти составные 
            элементы приложения.

            using System;
            using System.Reflection;
            using System.IO;

            namespace ConsoleApp1
            {
                class Program
                {
                static void Types(Assembly ass)
                {
                    Console.WriteLine("Типы сборки {0}: \n", ass.FullName);
                    Type[] types = ass.GetTypes();
                    foreach (Type t in types)
                        Console.WriteLine("--> " + t);
                    Console.WriteLine();
                }

                static void Main()
                {
                    Assembly ass = null;
                    do
                    {
                        Console.WriteLine("Введите имя или путь к интересующей сборке или нажмите 'E' для выхода");
                        string assemblyName = Console.ReadLine();
                        if (assemblyName.ToUpper() == "E")
                        {
                            break;
                        }
                        try
                        {
                            ass = Assembly.Load(assemblyName);
                            Types(ass);
                        }
                        catch
                        {
                            Console.WriteLine("Сборка не найдена");
                        }
                    }
                        while (true);
                  }
               }
           }

        3) Сериализация
            Сериализация представляет процесс преобразования какого-либо объекта в поток байтов. После преобразования 
            мы можем этот поток байтов или записать на диск или сохранить его временно в памяти
            
            Класс должен быть публичным, и иметь аттрибут [Serializable]
            Поключаем using System.Xml.Serialization;

            product.Name = "Планшет";
            product.Brand = "Apple";
            product.Price = "1000";

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

        4) Создать Generic с ограничением : IDisposable
        public class ArchiveStorage<T> : IDisposable
        {
            private readonly ZipFile _zipFile;

            public void Dispose()
            {
                _zipFile.Close();
            }
         }

        5) Абстрактный класс и Интерфейс
            В абстрактном можно написать уже готовый метод, а в интерфейсе нет
            И соответственно при наследовании от абс. класса можно переопределить метод либо оставить также
            Преимущество интерфейса в том что, можно наследоваться больше чем от одного интерфейса

        6) Nullable
            Значение null по умолчанию могут принимать только объекты ссылочных типов. Однако в различных ситуациях
            бывает удобно, чтобы объекты числовых типов данных имели значение null, то есть были бы не определены. 
            Стандартный пример - работа с базой данных, которая может содержать значения null. И мы можем заранее 
            не знать, что мы получим из базы данных - какое-то определенное значение или же null. 

            int? z = null;
            bool? enabled = null;
         */
    }
}
