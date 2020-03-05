using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using DAL.Models;

namespace BAL.API
{
    public class PeopleWork
    {
        public void AddPerson(Person person)
        {
            using var db = new PersonDBContext();
            var newPerson = new Person()
            {
                FirstName = person.FirstName,
                LastName = person.LastName,
                Position = person.Position,
                StartDate = person.StartDate,
                DateEnd = person.DateEnd
            };
            db.People.Add(newPerson);
            db.SaveChanges();
        }

        public static Person GetPerson(int id)
        {
            using (var db = new PersonDBContext())
            {
                var person = db.People.FirstOrDefault(x => x.Id == id);
                return person;
            } 
        }
        public static List<Person> GetPeople()
        {
            using (var db = new PersonDBContext())
            {
                var peopleList = db.People.Where(x => x.FirstName != null).ToList();

                return peopleList;
            }
        }
    }
}
