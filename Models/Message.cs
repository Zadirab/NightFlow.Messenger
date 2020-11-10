using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NightFlow.Messenger.Models
{
    public class Message
    {
        public int Id { get; set; }
        public DateTime CreatedTime { get; set; }
        public int SenderId { get; set; }

        public User GetSender(MessengerDbContext db) => db.Users.Where(x => x.Id == SenderId).FirstOrDefault();

        public int ReceiverId { get; set; }
        
        public User GetReceiver(MessengerDbContext db) => db.Users.Where(x => x.Id == ReceiverId).FirstOrDefault();

        public string Text { get; set; }

    }
}
