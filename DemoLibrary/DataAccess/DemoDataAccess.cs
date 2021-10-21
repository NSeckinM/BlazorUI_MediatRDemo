using DemoLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.DataAccess
{
    public class DemoDataAccess : IDataAccess
    {

        private List<PersonModel> people = new();

        public DemoDataAccess()
        {
            people.Add(item: new PersonModel { Id = 1, FirstName = "Can", LastName = "Gün" });
            people.Add(new PersonModel { Id = 2, FirstName = "Cansu", LastName = "Güneş" });
            people.Add(new PersonModel { Id = 3, FirstName = "Canan", LastName = "Yıldırım" });
            people.Add(new PersonModel { Id = 4, FirstName = "Kemal", LastName = "Batmaz" });
            people.Add(new PersonModel { Id = 5, FirstName = "Mehmet", LastName = "Dalyan" });
        }

        public void DeletePerson(int Id)
        {
            PersonModel p = people.Find(x => x.Id == Id);
            people.Remove(p);
        }

        public PersonModel GetById(int id)
        {
            PersonModel p = people.Find(x => x.Id == id);
            return p;
        }

        public List<PersonModel> GetPeople()
        {
            return people;
        }

        public PersonModel InsertPerson(string firstName, string lastName)
        {
            PersonModel p = new PersonModel() { FirstName = firstName, LastName = lastName };
            p.Id = people.Max(x => x.Id) + 1;
            people.Add(p);
            return p;
        }


    }
}
