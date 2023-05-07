using System;
namespace FactoryPatternExercise2
{
	public class SQLDataAccess : IDataAccess
	{
		public SQLDataAccess()
		{
		}

        public List<Product> Products = new List<Product>()
        {
             new Product() { Name = "Canamo (3g): The Woah", Price = 74.99},
             new Product() { Name = "Live Resin Cart (.5g): GFB", Price = 29.99},
             new Product() { Name = "Live Resin Cart (.5g): KMT", Price = 29.99},
             new Product() { Name = "Live Resin Cart (.5g): HPT", Price = 29.99},
             new Product() { Name = "Canamo Battery (Teal)", Price = 9.99},
             new Product() { Name = "Canamo Battery (Black)", Price = 9.99}
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

