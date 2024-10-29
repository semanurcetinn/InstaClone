using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstaClone.Classes
{
    public class Post{
        public int PostId { get; set; }
        public string Content { get; set; }
        public string Title { get; set; }
        public int CountOfLike { get; set; }
        
        public Post(int postId, string content, string title, int countOfLike) 
        {
            PostId = postId;
            Content = content;
            Title = title;
            CountOfLike = countOfLike;
        }
    }
}