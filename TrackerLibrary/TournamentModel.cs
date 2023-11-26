namespace TrackerLibrary
{
   public class TournamentModel
    {
        /// <summary>
        /// Represents the name of the tournament
        /// </summary>
        public string TournamentName { get; set; }
        /// <summary>
        /// Represents information on tournament enrollment fee
        /// </summary>
        public decimal EntryFee { get; set; }
        /// <summary>
        /// Represents a list of teams enrolled in a tournament
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();
        /// <summary>
        /// Represents information of prize poll for winning teams
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();
        /// <summary>
        /// Represents a list of tournament matchups
        /// </summary>
        public List<List<MatchUpModel>> Rounds { get; set; } = new List<List<MatchUpModel>>();
    }
}