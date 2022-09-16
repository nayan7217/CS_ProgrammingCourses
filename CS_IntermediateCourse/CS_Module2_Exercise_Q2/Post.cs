using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Module2_Exercise_Q2
{
    public class Post
    {
        public string title { get; set; }

        public string  description { get; set; }

        public DateTime createdDate{ get; set; }

        public int vote { get; set; }


        public Post(string postTitle, string postDescription, DateTime createdON)
        {
            this.title = postTitle;
            this.description = postDescription;
            this.createdDate = createdON;
        }

        public void UpVote()
        {
            this.vote ++;
            return;
        }
        public void DawnVote()
        {
            this.vote--;
            return ;
        }
        public void PrintVote()
        {
            Console.WriteLine($"Total No of vote for the Post {this.title} are {this.vote}");
        }
    }
}
