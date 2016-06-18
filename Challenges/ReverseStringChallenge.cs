using System;

namespace CSharpRefreshers.Challenges
{
    internal class ReverseStringChallenge : ChallengeBase
    {
        public override string Name => "Reverse string (in-place)";

        protected override void StartChallenge()
        {
            Console.Write("Enter string to reverse: ");
            var input = Console.ReadLine();
            var asCharArray = new char[0];

            if (input != null)
             asCharArray = input.ToCharArray();

            Console.WriteLine();

            for (int x = 0, y = asCharArray.Length - 1; x != y && y > 0; x++, y--)
            {
                var swap = asCharArray[x];
                asCharArray[x] = asCharArray[y];
                asCharArray[y] = swap;

            }

            Console.WriteLine("Reversed string: {0}", new string(asCharArray));
        }
    }
}