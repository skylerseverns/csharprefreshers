using System;
using System.Text;
using CSharpRefreshers.DataTypes.LinkedLists;

namespace CSharpRefreshers.Challenges
{
    internal class ReverseSinglyLinkedList : ChallengeBase
    {
        public override string Name => "Reverse Singly Linked List (non-recursive)";

        protected override void StartChallenge()
        {
            var list = new LinkedList<int>();
            list.AddStart(1)
                .AddNext(2)
                .AddNext(3)
                .AddNext(4)
                .AddNext(5)
                .AddNext(6);

            Console.WriteLine("Current list order:");
            PrintList(list);
            ReverseList(list);
            Console.WriteLine("Ending list order:");
            PrintList(list);
        }

        private void ReverseList(LinkedList<int> list)
        {
            var originalStart = list.Start;
            LinkedListNode<int> newEnd = null;

            var count = 0;
            while (originalStart.Next != null)
            {
                var firstNode = originalStart;
                var secondNode = originalStart.Next;
                
                while (secondNode.Next != null)
                {
                    firstNode = secondNode;
                    secondNode = secondNode.Next;
                }

                if (secondNode != null)
                {
                    if (count == 0)
                    {
                        list.Start = secondNode;
                        newEnd = secondNode;
                    }
                    else
                    {
                        newEnd.Next = secondNode;
                        newEnd = secondNode;
                    }
                    
                    firstNode.Next = null;
                }

                count++;
            }

            newEnd?.AddNext(originalStart.Value);
        }

        private void PrintList(LinkedList<int> list)
        {
            var output = new StringBuilder();

            var currentNode = list.Start;
            do
            {
                output.Append($"{currentNode.Value}");

                if (currentNode.Next != null)
                {
                    output.Append(", ");
                }

                currentNode = currentNode.Next;  
            } while (currentNode != null);

            Console.WriteLine(output.ToString());
        }
    }
}