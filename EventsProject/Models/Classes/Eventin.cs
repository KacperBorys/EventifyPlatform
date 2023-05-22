using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventsProject.Models.Classes
{
    public class Eventin
    {
        public List<Event> Events { get; set; } 
        public List<Account> Accounts { get; set; }

        List<Person> accounts = new List<Person>();

        public Eventin() 
        {
            Events = new List<Event>();
            Accounts = new List<Account>();
        }
        public void addAccount(Person p)
        {
            accounts.Add(p);
        }
        public void RemoveAcount(Person p)
        {
            accounts.Remove(p);
        }
    }

}