namespace CSharpRefreshers.DataTypes.LinkedLists
{
    public class LinkedList<T>
    {
        public LinkedListNode<T> Start { get; set; }

        public LinkedListNode<T> AddStart(T value)
        {
            Start = new LinkedListNode<T>(value);
            return Start;
        }
    }
}