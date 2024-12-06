using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstaClone.Classes
{
    public class Hashtag : Sharing
    {
        public string Tag { get; set; }
        public List<Post> Posts { get; set; }

        public Hashtag(ulong id, User author, string date, int countOfLike, string tag, List<Post> posts) 
            : base(id, author, date, countOfLike)
        { 
            Tag = tag;
            Posts = posts;
        }
    }
}
