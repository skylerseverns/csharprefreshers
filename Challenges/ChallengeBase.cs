using System;

namespace CSharpRefreshers.Challenges
{
    internal abstract class ChallengeBase
    {
        public abstract string Name { get; }

        public void Start()
        {
            Console.WriteLine();
            Console.WriteLine("######");
            Console.WriteLine($"###### {Name} ######");   
            StartChallenge(); 
            Console.WriteLine("######");
            Console.WriteLine("######");
            Console.WriteLine();    
        }

        protected abstract void StartChallenge();
    }
}