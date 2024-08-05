namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            bool correctInput;

            do {
                Console.Clear();
                correctInput = true;
                Console.WriteLine("Hello, what database would you like to use?");
                Console.WriteLine("Type: List");
                Console.WriteLine("Type: Mongo");
                Console.WriteLine("Type: SQL");

                userInput = Console.ReadLine();

                if (userInput != "sql" && userInput != "mongo" &&  userInput != "list")
                {
                    correctInput = false;
                    Console.WriteLine("Bad Input.");
                    Thread.Sleep(1000);
                }

            } while(correctInput == false);

           IDataAccess db = DataAccessFactory.GetDataAccessType(userInput);

            var products = db.LoadData();
            db.SaveData();

            foreach(var product in products)
            {
                Console.WriteLine($"Name: {product.Name} Price: {product.Price}");
            }

        



        }

      
    }
}
