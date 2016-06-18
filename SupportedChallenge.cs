using CSharpRefreshers.Challenges;

namespace CSharpRefreshers
{
    internal class SupportedChallenge
    {
        public SupportedChallenge(string name, ChallengeBase challenge)
        {
            Name = name;
            Challenge = challenge;
        }

        public string Name { get; private set; }

        public ChallengeBase Challenge { get; private set; }
    }
}