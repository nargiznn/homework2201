using System;
namespace homework2201
{
	public interface IStore
	{
		public string Products { get; }
		public int ProductLimit { get; }
        public int Totalİncome { get; }
        void AddProduct(Product product);
        bool RemoveProductByName(string name);
        void ShowProducts();
    }
}

