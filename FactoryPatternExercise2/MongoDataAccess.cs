using System;
namespace FactoryPatternExercise2
{
	public class MongoDataAccess : IDataAccess
	{
		public MongoDataAccess()
		{
		}

        public List<Product> Products = new List<Product>()
        {
             new Product() { Name = "ATHENA Nutrients: Grow (25lb)", Price = 24.99},
             new Product() { Name = "ATHENA Nutrients: Grow (50lb)", Price = 49.99},
             new Product() { Name = "ATHENA Nutrients: Bloom (25lb)", Price = 24.99},
             new Product() { Name = "ATHENA Nutrients: Bloom (50lb)", Price = 49.99},
        };

        public List<Product> LoadData()
        {
            Console.WriteLine($"Loading data from {GetType().Name}....");
            return Products;
        }

        public void SaveData()
        {
            Console.WriteLine($"Saving data from {GetType().Name}.");
        }
    }
}

