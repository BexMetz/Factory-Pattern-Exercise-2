namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Would you like to use the List, SQL, or Mongo database?");
            var databaseType = Console.ReadLine();

            IDataAccess dataAccess = DataAccessFactory.GetDataAccessType(databaseType);

            Console.WriteLine("");

            List<Product> products = dataAccess.LoadData();

            Console.WriteLine("");

            foreach (var p in products)
            {
                Console.WriteLine($"{p.Name}");
                Console.WriteLine($"${p.Price}");
            }

            Console.WriteLine("");

            dataAccess.SaveData();
        }
    }
}
