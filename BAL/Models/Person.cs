using System;
using System.Collections.Generic;
using System.Text;


namespace BAL.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }
        public DateTime StartDate { get; set; }
    }
}
