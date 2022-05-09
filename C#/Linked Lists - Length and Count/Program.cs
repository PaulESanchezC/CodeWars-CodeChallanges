using System;

public partial class Node
{
    public int Data;
    public Node Next;

    public Node(int data)
    {
        this.Data = data;
        this.Next = null;
    }

    public static int Length(Node head)
    {
        var length = 0;
        var actualNode = head;
        while (actualNode != null)
        {
            actualNode = actualNode.Next;
            length++;
        }

        return length;
    }

    public static int Count(Node head, Predicate<int> func)
    {
        var count = 0;
        var actualNode = head;
        while (actualNode != null)
        {
            if (func(actualNode.Data))
                count++;
            if (actualNode.Next == null)
                break;
            actualNode = actualNode.Next;
        }
        return count;
    }
}