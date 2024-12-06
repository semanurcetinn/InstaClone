using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstaClone.Classes
{
    public class Comment : Sharing{
        public string Text { get; set; }
        public string UserCommender { get; set; }

        public Comment(ulong id, User author, string date, int countOfLike, string text, string userCommender)
            : base(id,author,date,countOfLike)
        {
            Text = text;
            UserCommender = userCommender;
        }
    }
}
