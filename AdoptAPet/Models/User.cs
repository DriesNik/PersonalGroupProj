using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace AdoptAPet.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public Address Address { get; set; }
        public string AddressID { get; set; }
        public string EMail { get; set; }
        public AdoptionStatus AdoptionStatus { get; set; }
        public Boolean AdoptionId { get; set; }
        public int PetId { get; set; }


    }
}