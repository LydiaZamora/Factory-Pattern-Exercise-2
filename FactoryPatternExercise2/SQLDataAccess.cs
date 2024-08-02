using System;
namespace FactoryPatternExercise2
{
	public class SQLDataAccess : IDataAccess
	{
        public void LoadData()
        {
            Console.WriteLine("I am reading data from a SQL database.");
        }

        public void SaveData()
        {
            Console.WriteLine("I am saving data from a SQL database");
        }

        public SQLDataAccess()
		{
		}
	}
}

