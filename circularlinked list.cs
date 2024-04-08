//using System;

//public class Node
//{
//    public int Value { get; set; }
//    public Node Next { get; set; }

//    public Node(int value)
//    {
//        Value = value;
//        Next = null;
//    }
//}

//public class CircularLinkedList
//{
//    private Node head;

//    public void Add(int value)
//    {
//        Node newNode = new Node(value);
//        if (head == null)
//        {
//            head = newNode;
//            head.Next = head;
//        }
//        else
//        {
//            Node current = head;
//            while (current.Next != head)
//                current = current.Next;
//            current.Next = newNode;
//            newNode.Next = head;
//        }
//    }

//    public void Display()
//    {
//        if (head == null)
//        {
//            Console.WriteLine("Circular Linked List is empty.");
//            return;
//        }

//        Node current = head;
//        do
//        {
//            Console.Write(current.Value + " ");
//            current = current.Next;
//        } while (current != head);


//        Console.WriteLine();
//    }
//}

//public class Program
//{
//    public static void Main()
//    {
//        CircularLinkedList myList = new CircularLinkedList();
//        myList.Add(10);
//        myList.Add(20);
//        myList.Add(30);
//        myList.Display();

//        Console.ReadLine();
//    }
//}