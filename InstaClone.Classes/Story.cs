using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstaClone.Classes
{
    public class Story : Sharing
    {
        public DateTime DatePosted { get; set; }
        public bool IsActive => DateTime.Now > DatePosted.AddHours(24); //24 saat kontrolü

        public Story(ulong id, User author, string date, int countOfLike, DateTime datePosted, bool isActive) 
            : base(id, author, date, countOfLike)
        {
            DatePosted = datePosted;
        }
    }
}
