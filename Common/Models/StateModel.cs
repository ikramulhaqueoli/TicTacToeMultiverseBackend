namespace Common.Models
{
    public class StateModel
	{
		public StateModel(string boardId)
		{
			BoardId = boardId;
            Turns = new List<Turn>();
        }
		
		public string? BoardId { get; set; }

        public IList<Turn> Turns { get; set; }
	}
}

