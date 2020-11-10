using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NightFlow.Messenger.Models
{
    public class User
    {

        public int Id { get; set; }
        public string FirstName { get; set; }

        public string LastName  { get; set; }

        public string UserType { get; set; }

        public int AccountId { get; set; }

        public Account Account { get; set; }

       

    }
}
