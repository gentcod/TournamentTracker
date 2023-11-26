using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class SQLConnector : IDataConnection
    {
        // TODO: Make CreatePrize method save to the database
        /// <summary>
        /// Saves a new prize to the database
        /// </summary>
        /// <param name="prizeModel"></param>
        /// <returns>The prize information</returns>
        /// <exception cref="NotImplementedException"></exception>
        public PrizeModel CreatePrize(PrizeModel prizeModel)
        {
            prizeModel.Id = 1;
            return prizeModel;
            throw new NotImplementedException();
        }
    }
}
