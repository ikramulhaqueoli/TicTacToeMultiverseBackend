using Common.Models;

namespace DataAccess
{
	public interface IBoardRepository
	{
		void SetMove(string boardId, Turn turn);

		StateModel GetState(string boardId);

        void Reset(string boardId);
    }
}

