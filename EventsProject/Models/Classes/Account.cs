using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EventsProject.Models.Classes
{
    public class Account
    {
        public Account(int accountID, string login, string password)
        {
            this.accountID = accountID;
            this.login = login;
            this.password = password;
        }
        public int accountID { get; set; }   
        public string login { get; set; }
        public string password { get; set; }

        public int? PersonId { get; set; }
        public virtual Person Person { get; set; }
    }
}