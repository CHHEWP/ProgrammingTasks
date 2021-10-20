using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; }
        public DateTime DOB { get; set; }
        public void SetPerson(int id, string surname, string address)
        {
            Id = id;
            Surname = surname;
            Address = address;
        }
    }
}
