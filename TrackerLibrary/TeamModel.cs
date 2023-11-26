namespace TrackerLibrary
{
   public class TeamModel
    {
        /// <summary>
        /// Represents a list of members in a team
        /// </summary>
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();
        /// <summary>
        /// Represents the name of a team
        /// </summary>
        public string TeamName { get; set; }
    }
}
