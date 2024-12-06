using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstaClone.Classes
{
    public abstract class Sharing
    {
        public ulong Id { get; set; }
        public User Author { get; set; }
        public string Date { get; set; }
        public int CountOfLike { get; set; }
        public Sharing(ulong id, User author, string date, int countOfLike) 
        {
            Id = id;
            Author = author;
            Date = date;
            CountOfLike = countOfLike;
        }
    }
}