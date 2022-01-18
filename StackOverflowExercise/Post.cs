using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverflowExercise
{
    internal class Post
    {
        private string _title;
        private string _descritption;
        private string _dateTime;
        private int _upvote;
        private int _downvote;
        private string _fullPost;

        public Post()
        {
            this._title = null;
            this._descritption = null;
            this._upvote = 0;
            this._downvote = 0;
        }

        public void CreatePost()
        {
            Console.WriteLine("What is the title of your post?");
            this._title = Console.ReadLine();
            Console.WriteLine("Please write a descprition of your post.");
            this._descritption = Console.ReadLine();
            this._dateTime = DateTime.Now.ToString("MM/dd/yyyy hh:mm tt");
            Console.Write("Your Post: " + " | " + _title + " | " + _descritption + " | " + _dateTime);
        }

        public void Vote()
        {
            
            bool endVote = false;

          
            
                while (endVote = false)
                {
                    Console.WriteLine(
                        "Type and enter 'upvote' or 'downvote' to rate the post. When finished voting type 'done'.");
                    string VoteInput = Console.ReadLine();
                    if (VoteInput == "upvote")
                    {
                        _upvote += 1;
                    }
                    else if (VoteInput == "downvote")
                    {
                        _downvote += 1;
                    }
                    else if (VoteInput == "done")
                    {
                        endVote = true;
                    }

                    Console.Write("Your Post: " + " | " + _title + " | " + _descritption + " | " + _dateTime);
                    Console.WriteLine("You recieved: " + _upvote + " upvotes & " + _downvote + " downvotes");
                }
            
        }
    }
}
