using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstaClone.Classes
{
    public class Post : Sharing{
        public string Content { get; set; }
        public string Title { get; set; }
        
        public Post(ulong id, User author, string date, int countOfLike, string content, string title) 
            : base(id, author, date, countOfLike)
        {
            Content = content;
            Title = title;
        }
    }
}