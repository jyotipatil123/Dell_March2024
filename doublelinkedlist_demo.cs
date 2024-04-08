
// doulby linked list

using A;
using System;
using System.Collections.Generic;
using System.Text;

namespace A
{
    public class Node
    {
        private string data;
        private Node next = null;
        private Node prev = null;

        public string Data
        {
            get { return this.data; }
            set { this.data = value; }
        }

        public Node Next
        {
            get { return this.next; }
            set { this.next = value; }
        }

        public Node Prev
        {
            get { return this.prev; }
            set { this.prev = value; }
        }
    }

    public class DoubleLinkedList
    {
        private Node root = null;
        private Node current = null;
        private int length;

        public Node Root
        {
            get { return this.root; }
            set { this.root = value; }
        }

        public int Length
        {
            get { return this.length; }
            set { this.length = value; }
        }

        public void add(Node node)
        {
            node.Next = null;
            if (root == null)
            {
                root = node;
                length = 1;
                current = root;
                root.Prev = null;
            }
            else
            {
                current.Next = node;
                node.Prev = current;
                current = node;
                length++;
            }
        }

        public Node getCurrent()
        {
            return this.current;
        }

        public Node getRoot()
        {
            current = root;
            return this.root;
        }

        public Node getNext()
        {
            if (current.Next != null)
            {
                current = current.Next;
                return current;
            }
            else
                return null;
        }

        public Node getPrev()
        {
            if (current.Prev != null)
            {
                current = current.Prev;
                return current;
            }
            else
                return null;
        }

        public int getLengthOfList()
        {
            return this.length;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        runApp();

        Console.ReadLine();
    }

    public static void runApp()
    {
        DoubleLinkedList list = new DoubleLinkedList();

        Node n = new Node();
        n.Data = "root";
        list.add(n);

        for (int i = 0; i < 10; i++)
        {
            Node node = new Node();
            node.Data = Convert.ToString(i);
            list.add(node);
        }

        Console.WriteLine("length of singly linked list=" + list.getLengthOfList());

        Console.WriteLine("Traversing forward..");
        n = list.getRoot();

        while (n != null)
        {
            Console.WriteLine(n.Data);
            n = list.getNext();
        }


        Console.WriteLine("Traversing backwards..");
        n = list.getPrev();
        while (n != null)
        {
            Console.WriteLine(n.Data);
            n = list.getPrev();
        }

    }
}
