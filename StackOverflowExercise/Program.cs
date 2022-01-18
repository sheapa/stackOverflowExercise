using System;

namespace StackOverflowExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Post = new Post();
            Post.CreatePost();
            Post.Vote();

        }
    }
}
