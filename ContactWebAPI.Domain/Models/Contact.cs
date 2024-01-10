using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Numerics;

namespace ContactWebAPI.Domain.Models
{
    public class Contact
    {

        public Contact()
        {
            Addresses = new List<Address>();
            Phones = new List<Phone>();
        }
        public int ContactId { get; set; }
        [Required]
        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        [Required]
        public string LastName { get; set; }

        [EmailAddress]
        public string EmailAddress { get; set; }

        [Required]
        public DateTime Birthday { get; set; }

        public DateTime? Anniversary { get; set; }

        [Url]
        public string ImageUrl { get; set; }

        public List<Address> Addresses { get; set; }
        public List<Phone> Phones { get; set; }

        public string FullName
        {
            get
            {
                if (string.IsNullOrEmpty(FirstName) && string.IsNullOrEmpty(LastName) &&
                    string.IsNullOrEmpty(MiddleName))
                {
                    return "Could not determine the contact name";
                }

                if (string.IsNullOrEmpty(MiddleName))
                {
                    return $"{FirstName} {LastName}";
                }

                return $"{FirstName} {MiddleName} {LastName}";
            }
        }
    }
}