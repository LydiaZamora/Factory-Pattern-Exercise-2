namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello, what database would you like to use?");

            var userAnswer = Console.ReadLine();
            userAnswer.ToLower();
          
            var dataBase = DataAccessFactory.GetDataAccessType(userAnswer);
            dataBase.LoadData();
            dataBase.SaveData();



        }

        public void userInputChecker(string input)
        {
            if( input  )
        }
    }
}
