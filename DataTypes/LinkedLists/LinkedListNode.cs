namespace CSharpRefreshers.DataTypes.LinkedLists
{
    public class LinkedListNode<T>
    {
        public LinkedListNode(T value)
        {
            Value = value;
        }

        public T Value { get; set; }

        public LinkedListNode<T> Next { get; set; }

        public LinkedListNode<T> AddNext(T value)
        {
            Next = new LinkedListNode<T>(value);
            return Next;
        }

        public override string ToString()
        {
            return $"Value: {Value}";
        }
    }
}