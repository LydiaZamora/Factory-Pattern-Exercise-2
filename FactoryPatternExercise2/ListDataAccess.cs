using System;
namespace FactoryPatternExercise2
{
	public class ListDataAccess : IDataAccess
	{
		public void LoadData()
		{
			Console.WriteLine("I am reading data from a List database.");
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

