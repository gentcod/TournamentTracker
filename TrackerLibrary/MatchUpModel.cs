namespace TrackerLibrary
{
    public class MatchUpModel
    {
        /// <summary>
        /// Represents lists of match up entires
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new  List<MatchupEntryModel>();
        /// <summary>
        /// Represents the information of a team that emerges as a winner
        /// </summary>
        public TeamModel Winner { get; set; }
        /// <summary>
        /// Represents information on rounds in Tournament MatchUp
        /// </summary>
        public int MatchupRound { get; set; }
    }
}