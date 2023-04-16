using System;

namespace ClinicManagementApp.Model
{
    /// <summary>
    /// The Person model class.
    /// </summary>
    public class Person
    {
        public int RecordID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }   
        public DateTime DateOfBirth { get; set; }
        public string AddressStreet { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Phone { get; set; }

        /// <summary>
        /// Returns person's full name
        /// </summary>
        public string FullName
        {
            get { return $"{FirstName} {LastName}"; }
        }

        public string Sex { get; set; }
        public string SSN { get; set; }


        /// <summary>
        /// Person constructor.
        /// </summary>
        public Person ()
        {

        }

        /// <summary>
        /// Person constructor.
        /// </summary>
        /// <param name="recordID"> recordID of an person</param>
        /// <param name="lastName"> last name of person </param>
        /// <param name="firstName"> first name of person</param>
        /// <param name="dateOfBirth"> dob of person</param>
        /// <param name="addressStreet"> street address of person</param>
        /// <param name="city"> city of person</param>
        /// <param name="state"> state of person</param>
        /// <param name="zip"> zip code of person</param>
        /// <param name="phone"> phone number of person</param>
        /// <param name="sex"> sex of person</param>
        /// <param name="ssn"> ssn of person</param>
        public Person(string lastName, string firstName, DateTime dateOfBirth, string addressStreet, string city, string state, string zip, string phone, string sex, string ssn)
        {
            _ = lastName ?? throw new ArgumentNullException("Last name cannot be null");
            _ = firstName ?? throw new ArgumentNullException("First name cannot be null");
            _ = addressStreet ?? throw new ArgumentNullException("Street address cannot be null");
            _ = city ?? throw new ArgumentNullException("City cannot be null");
            _ = state ?? throw new ArgumentNullException("State cannot be null");
            _ = zip ?? throw new ArgumentNullException("Zip cannot be null");
            _ = phone ?? throw new ArgumentNullException("Phone number cannot be null");
            _ = sex ?? throw new ArgumentNullException("Zip cannot be null");
            _ = ssn ?? throw new ArgumentNullException("Phone number cannot be null");

            this.LastName = lastName;
            this.FirstName = firstName;
            this.DateOfBirth = dateOfBirth;
            this.AddressStreet = addressStreet;
            this.City = city;
            this.State = state;
            this.Zip = zip;
            this.Phone = phone;
            this.Sex = sex;
            this.SSN = ssn;
        }

        /// <summary>
        /// Person constructor.
        /// </summary>
        /// <param name="recordID"> recordID of an person</param>
        /// <param name="lastName"> last name of person </param>
        /// <param name="firstName"> first name of person</param>
        /// <param name="dateOfBirth"> dob of person</param>
        /// <param name="addressStreet"> street address of person</param>
        /// <param name="city"> city of person</param>
        /// <param name="state"> state of person</param>
        /// <param name="zip"> zip code of person</param>
        /// <param name="phone"> phone number of person</param>
        public Person(int recordID, string lastName, string firstName, DateTime dateOfBirth, string addressStreet, string city, string state, string zip, string phone)
        {
            _ = lastName ?? throw new ArgumentNullException("Last name cannot be null");
            _ = firstName ?? throw new ArgumentNullException("First name cannot be null");
            _ = addressStreet ?? throw new ArgumentNullException("Street address cannot be null");
            _ = city ?? throw new ArgumentNullException("City cannot be null");
            _ = state ?? throw new ArgumentNullException("State cannot be null");
            _ = zip ?? throw new ArgumentNullException("Zip cannot be null");
            _ = phone ?? throw new ArgumentNullException("Phone number cannot be null");

            this.RecordID = recordID;
            this.LastName = lastName;
            this.FirstName = firstName;
            this.DateOfBirth = dateOfBirth;
            this.AddressStreet = addressStreet;
            this.City = city;
            this.State = state;
            this.Zip = zip;
            this.Phone = phone;
        }
    }
}
