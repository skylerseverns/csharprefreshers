using System;
using CSharpRefreshers.DataTypes.LinkedLists;

namespace CSharpRefreshers.Challenges
{
    internal class FindCyclesInLinkedList : ChallengeBase
    {
        public override string Name => "Find Cycles in a linked list.";

        protected override void StartChallenge()
        {
            var noCycles = new LinkedList<int>();
            noCycles.AddStart(1).AddNext(2).AddNext(3).AddNext(4).AddNext(5).AddNext(6);

            Console.Write("First attempt: ");
            FindCycle(noCycles);

            var withCyles = new LinkedList<int>();
            var linkedListNode = withCyles.AddStart(1).AddNext(2).AddNext(3);
            var listNode = linkedListNode.AddNext(4).AddNext(5);
            listNode.AddNext(6);
            listNode.Next = linkedListNode;

            Console.Write("Second attempt: ");
            FindCycle(withCyles);
        }

        private void FindCycle(LinkedList<int> list)
        {
            var firstNode = list.Start;
            var secondNode = list.Start?.Next?.Next;
            
            var cycleFound = false;

            do
            {
                if (firstNode == secondNode)
                {
                    cycleFound = true;
                    break;
                }

                firstNode = firstNode.Next;
                secondNode = secondNode?.Next?.Next;
            } while (secondNode != null);

            if (cycleFound)
            {
                Console.WriteLine("Cycle found.");
            }
            else
            {
                Console.WriteLine("No Cycles.");
            }
        }
    }
}