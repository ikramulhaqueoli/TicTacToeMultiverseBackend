using Common.Models;

namespace DataAccess.Implementations
{
	public class BoardRepository : IBoardRepository
	{
        private readonly InMemoryDatabase _inMemoryDatabase;

        public BoardRepository(InMemoryDatabase inMemoryDatabase)
        {
            _inMemoryDatabase = inMemoryDatabase;
        }

        public StateModel GetState(string boardId)
        {
            if (!_inMemoryDatabase.BoardsData.ContainsKey(boardId))
                _inMemoryDatabase.BoardsData[boardId] = new StateModel(boardId);

            return _inMemoryDatabase.BoardsData[boardId];
        }

        public void Reset(string boardId)
        {
            if (_inMemoryDatabase.BoardsData.ContainsKey(boardId))
                _inMemoryDatabase.BoardsData.Remove(boardId);
        }

        public void SetMove(string boardId, Turn turn)
        {
            if (!_inMemoryDatabase.BoardsData.ContainsKey(boardId))
                _inMemoryDatabase.BoardsData[boardId] = new StateModel(boardId);

            _inMemoryDatabase.BoardsData[boardId].Turns.Add(turn);
        }
    }
}

