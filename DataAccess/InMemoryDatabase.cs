using Common.Models;

namespace DataAccess
{
	public class InMemoryDatabase
	{
		private static readonly Dictionary<string, StateModel> _boardsData = new();

        public Dictionary<string, StateModel> BoardsData => _boardsData;
	}
}

