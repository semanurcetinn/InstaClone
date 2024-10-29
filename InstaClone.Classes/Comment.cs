using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstaClone.Classes
{
    public class Comment{
        public int CommentId { get; set; }
        public string Text { get; set; }
        public string UserCommender { get; set; }

        public Comment(string text, string userCommender, int commentId)
        {
            Text = text;
            UserCommender = userCommender;
            CommentId = commentId;
        }
    }
}
