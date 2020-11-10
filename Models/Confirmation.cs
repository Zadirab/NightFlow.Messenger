using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NightFlow.Messenger.Models
{
    public class Confirmation
    {
        public int Id { get; set; }

        public DateTime CreatedTime { get; set; }

        public bool IsConfimated { get; set; }

        public int AccountId { get; set; }
        public Account Account { get; set; }
    }
}
