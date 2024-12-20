namespace search_algo.LinkedList;

public static class DoubleLinkedListImplemntation
{
    public static void Execute()
    {
        DoubleLinkedList list = new DoubleLinkedList();
        list.InsertFront(1);
        list.InsertFront(2);
        list.InsertFront(3);
        // list.InsertLast(9);
        list.InsertFront(8);
        // list.InsertLast(7);

        var current = list.head;
        while (current != null)
        {
            Console.WriteLine(current.data);
            current = current.next;
        }
    }
}

internal class DNode
{

    internal int data;
    internal DNode prev;
    internal DNode next;

    public DNode(int d)
    {
        data = d;
        prev = null;
        next = null;
    }
}

internal class DoubleLinkedList
{
    internal DNode head;
}

internal static class DoubleLinkedListExtensions
{
    public static void InsertFront(this DoubleLinkedList list, int newData)
    {
        DNode current = new DNode(newData);
        current.next = list.head;
        current.prev = null;

        if (list.head != null)
        {
            list.head.prev = current;
        }
        list.head = current;
    }

    public static void InsertAfter(DNode prev_node, int new_data)
    {
        if (prev_node == null)
        {
            Console.WriteLine("the previous canot be null");
            return;
        }
        DNode current = new DNode(new_data);
        current.next = prev_node.next;
        prev_node.next = current;
        current.prev = prev_node;
        if (current.next != null)
            current.next.prev = current;
    }
}