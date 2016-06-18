using System;
using System.Text;

namespace CSharpRefreshers.Challenges
{
    internal class FibonacciChallenge : ChallengeBase
    {
        public override string Name => "Print Fibonacci sequence.";

        protected override void StartChallenge()
        {
            int iterations;
            Console.Write("How many iterations of the Fibonacci sequence: ");
            int.TryParse(Console.ReadLine(), out iterations);

            var first = 0;
            var second = 0;

            StringBuilder output = new StringBuilder();
            for (var x = 0; x < iterations; x++)
            {
                var current = first + second;
                output.Append($"{current}");

                if (x < iterations - 1)
                    output.Append(", ");

                if (current == 0)
                    second = 1;
                else
                {
                    first = second;
                    second = current;
                }
            }

            Console.WriteLine(output.ToString());
        }
    }
}