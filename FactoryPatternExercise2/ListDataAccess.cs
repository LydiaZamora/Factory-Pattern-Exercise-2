using System;
namespace FactoryPatternExercise2
{
	public class ListDataAccess : IDataAccess
	{
        public static List<Product> Products = new List<Product>()
        {
            new Product(){Name = "Laptop", Price = 1000.50},
            new Product(){Name = "Cat Food", Price = 15.50},
            new Product(){Name = "Book", Price = 10.99},
            new Product(){Name = "Shoes", Price = 85.99}
        };

        public List<Product> LoadData()
        {
            Console.WriteLine("I am reading data from List Data Access");

            return Products;
        }
        public void SaveData()
		{
			Console.WriteLine("I am saving data from a List database.");
		}

		public ListDataAccess()
		{
		}
	}
}

