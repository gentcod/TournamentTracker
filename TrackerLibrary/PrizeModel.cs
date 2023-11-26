using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class PrizeModel
    {
        /// <summary>
        /// Represents unique identifier for prize
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Represents place number for a prize
        /// </summary>
        public int PlaceNumber { get; set; }
        /// <summary>
        /// Represents place name for a prize
        /// </summary>
        public string  PlaceName { get; set; }
        /// <summary>
        /// Represents the winning prize amount
        /// </summary>
        public decimal PrizeAmount { get; set; }
        /// <summary>
        /// Represents the percentage of winning
        /// </summary>
        public double PricePercentage { get; set; }

        public PrizeModel(){}
        public PrizeModel(string placeName, string placeNumber, string prizeAmount, string prizePercentage)
        {
            int.TryParse(placeNumber, out int placeNumValue);
            decimal.TryParse(placeNumber, out decimal prizeAmountValue);
            double.TryParse(placeNumber, out double prizePercentageValue);

            PlaceName = placeName;
            PlaceNumber = placeNumValue;
            PrizeAmount = prizeAmountValue; 
            PricePercentage = prizePercentageValue;
        }
    }
}