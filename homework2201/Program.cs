using System;
using static System.Reflection.Metadata.BlobBuilder;

namespace homework2201
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product(name,price,count);
            string opt;
            do
            {
                ShowMenu();
                Console.WriteLine("Əməliyyat secin!");
                opt=Console.ReadLine();
                switch (opt)
                {
                    case "1":
                        var addResult = Add(product1);
                        if (addResult) Console.WriteLine("Product elave olundu");
                        else Console.WriteLine("Product var!");
                        break;
                    case "2":
                        var removeResult = Remove(product);
                        if (removeResult) Console.WriteLine("Book successfully removed");
                        else Console.WriteLine("Book not found!");
                        break;
                    case "3":
                        for (int i = 0; i < product.Products.Length; i++)
                        {
                            product.Products[i].ShowInfo();
                        }
                        break;
                    case "4":
                        Console.WriteLine("Əməliyyat bitmisdir");
                        break;
                    default:
                        Console.WriteLine("Əməliyyat yanlisdir!");
                        break;

                }
            } while (opt != "4");

            static void ShowMenu()
            {
                Console.WriteLine("=================Menu=================");
                Console.WriteLine("1.Product əlavə et");
                Console.WriteLine("2.Product sat");
                Console.WriteLine("3.Productlara bax");
                Console.WriteLine("4.Menudan çıx");
            }
            static bool Add(Product product)
            {
                string name;
                do
                {
                    Console.WriteLine("Name:");
                    name = Console.ReadLine();

                } while (!CheckName(name));

                string priceStr;
                decimal price;
                do
                {
                    Console.WriteLine("Price:");
                    priceStr = Console.ReadLine();

                } while (!decimal.TryParse(priceStr, out price) || price < 0);

                string countStr;
                decimal count;
                do
                {
                    Console.WriteLine("Count:");
                    countStr = Console.ReadLine();

                } while (!decimal.TryParse(countStr, out count) || count < 0);

                Product product1 = new Product(name, price,count);
                product.AddProduct(product1);

                return true;
                static bool CheckName(string name)
                {
                    if (String.IsNullOrWhiteSpace(name)) return false;
                    return true;
                }

            }
            static bool Remove(Product product)
            {
                Console.WriteLine("Product name: ");
                string name = Console.ReadLine();

                return product.RemoveBookByName(name);
            }


        }

    }

}

