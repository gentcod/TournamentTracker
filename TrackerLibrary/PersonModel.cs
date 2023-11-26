using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class PersonModel
    {
        /// <summary>
        /// Represents unique identifier for Person
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Represents first name of Person
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// Represents last name of Person
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Represents email address of person
        /// </summary>
        public string EmailAddress { get; set; }
        /// <summary>
        /// Represents mobile contact of Person
        /// </summary>
        public string CellPhoneNumber { get; set; }
    }
}