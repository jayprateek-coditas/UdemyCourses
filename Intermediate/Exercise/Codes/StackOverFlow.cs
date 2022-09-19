using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.Codes
{
    public class StackOverFlow
    {
        private DateTime created;
        public String Title { get; set; }
        public String Description { get; set; }
        private int upVote { get; set; }
        private int downVote { get; set; }

        public StackOverFlow()
        {
            this.created = DateTime.Now;
        }

        public void created_()
        {
            Console.WriteLine($"Created at {this.created}");
        }
        public void setUpVode()
        {
            upVote += 1;
        }
        public void setDownVode()
        {
            downVote += 1;
        }
        public void totalVote()
        {
            Console.WriteLine($"UpVote of {this.Title} is {upVote}");
            Console.WriteLine($"downVote of {this.Title} is {downVote}");
        }

    }
}
