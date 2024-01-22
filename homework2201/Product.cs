using System;
using static System.Reflection.Metadata.BlobBuilder;

namespace homework2201
{
	public class Product
	{

			
		public Product(string name,decimal price,decimal count)
		{
			this.Name = name;
			this.Price = price;
			this.Count = count;
		}
		public string Name { get; set; }
		public decimal Price { get; set; }
        public decimal Count { get; set; }


        //public Product[] Products = new Product[0];
        public void ShowInfo()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Price: " + Price);
            Console.WriteLine("Count: " + Count);
        }

    //    public void AddProduct(Product product)
    //    {
    //        Array.Resize(ref Products, Products.Length + 1);
				//Products[Products.Length - 1] = product;
    //    }
    //    public bool RemoveBookByName(string name)
    //    {
    //        int wantedIndex = FindProductIndexByName(name);

    //        if (wantedIndex == -1) return false;

    //        for (int i = wantedIndex; i < Products.Length - 1; i++)
    //        {
    //            var temp = Products[i];
    //            Products[i] = Products[i + 1];
    //            Products[i + 1] = temp;
    //        }

    //        Array.Resize(ref Products, Products.Length - 1);
    //        return true;
    //    }
    //    public int FindProductIndexByName(string name)
    //    {
    //        for (int i = 0; i < Products.Length; i++)
    //        {
    //            if (Products[i].Name == name) return i;
    //        }

    //        return -1;
    //    }
      
    }
}

