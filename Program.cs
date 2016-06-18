using System;
using System.Collections.Generic;
using System.Text;
using CSharpRefreshers.Challenges;


namespace CSharpRefreshers
{
    class Program
    {
        static readonly IList<ChallengeBase> Challenges = new List<ChallengeBase>();

        static void Main(string[] args)
        {
            var loopAgain = true;

            do
            {
                LoadChallenges();
                var selection = PrintAndPrompt();

                ChallengeBase challenge = null;

                if (selection < Challenges.Count)
                    challenge = Challenges[selection];
                else
                    loopAgain = false;

                if (challenge != null)
                    challenge.Start();

            } while (loopAgain); 
        }

        private static int PrintAndPrompt()
        {
            int output;
            var builder = new StringBuilder();
            builder.AppendLine("Select a challenge to test:");
            builder.AppendLine();

            for (var x = 0; x < Challenges.Count;x++)
            {
                builder.AppendLine($"{x + 1}) {Challenges[x].Name}");
            }

            builder.AppendLine($"{Challenges.Count + 1}) Exit");

            builder.AppendLine();
            builder.Append("> ");

            Console.Write(builder.ToString());
            var readLine = Console.ReadLine();
            
            var parsed = int.TryParse(readLine, out output);

            if (!parsed)
                output = Challenges.Count + 1;

            return output - 1;
        }

        private static void LoadChallenges()
        {
            Challenges.Clear();
            Challenges.Add(new ReverseStringChallenge());
            Challenges.Add(new FibonacciChallenge());
            Challenges.Add(new ReverseSinglyLinkedList());
            Challenges.Add(new FindCyclesInLinkedList());
        }
    }
}
