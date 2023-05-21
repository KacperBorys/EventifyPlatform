using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventsProject.Models.Classes
{
    public class Accounts
    {
        List<Person> accounts = new List<Person>();

        public Accounts() 
        { 
        }

        public void AddAccount(Person p)
        {
            accounts.Add(p);
        }
        public void RemoveAcount(Person p)
        {
            accounts.Remove(p);
        }


    }
}