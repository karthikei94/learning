namespace search_algo.LinkedList;

public static class SingleLinkedListImplemntation
{
    public static void Execute()
    {
        SingleLinkedList list = new SingleLinkedList();
        list.InsertFront(1);
        list.InsertFront(2);
        list.InsertFront(3);
        list.InsertLast(9);
        list.InsertFront(8);
        list.InsertLast(7);
        
        var current = list.head;
        while (current != null)
        {
            Console.WriteLine(current.data);
            current = current.next;
        }
    }
}

internal class Node
{
    internal int data;
    internal Node next;

    public Node(int d)
    {
        data = d;
        next = null;
    }
}

internal class SingleLinkedList
{
    internal Node head;
}

internal static class SingleLinkedListExtensions
{
    public static void InsertFront(this SingleLinkedList list, int newData)
    {
        Node newNode = new Node(newData);
        newNode.next = list.head;
        list.head = newNode;
    }

    public static void InsertLast(this SingleLinkedList list, int newData)
    {
        Node newNode = new Node(newData);
        if (list.head == null)
        {
            list.head = newNode;
            return;
        }

        Node lastNode = GetLastNode(list);
        lastNode.next = newNode;
        // newNode.prev = lastNode;
    }

    public static Node GetLastNode(SingleLinkedList list)
    {
        Node temp = list.head;
        while (temp.next != null)
        {
            temp = temp.next;
        }
        return temp;
    }

    public static void InsertAfter(Node prev_Node, int new_data)
    {
        if (prev_Node == null)
        {
            Console.WriteLine("Given prev node can not be null");
            return;
        }

        Node new_node = new Node(new_data);
        new_node.next = prev_Node.next;
        prev_Node.next = new_node;

    }
}