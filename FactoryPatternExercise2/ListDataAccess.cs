using System;
namespace FactoryPatternExercise2
{
	public class ListDataAccess : IDataAccess
	{
		public ListDataAccess()
		{
		}

        public List<Product> Products = new List<Product>()
        {
             new Product() { Name = "Charlie's: Half Pint", Price = 34.99 },
             new Product() { Name = "Charlie's: Kush Mints", Price = 34.99},
             new Product() { Name = "Charlie's: Cookie Fam Sherb", Price = 34.99},
             new Product() { Name = "SR Jar: MAC", Price = 44.99},
             new Product() { Name = "SR Jar: Cookie Fam Sherb", Price = 44.99},
             new Product() { Name = "Bulk Deli: LPC (14g)", Price = 124.99}
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

