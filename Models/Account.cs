using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NightFlow.Messenger.Models
{
    public class Account
    {

        public int Id { get; set; }
        public string Login { get; set; }

        public string Password  { get; set; }

        public int ConfirmationId { get; set; }

        public Confirmation Confirmation { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }
    }
}
