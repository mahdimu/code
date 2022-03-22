using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePackage
{
    internal class MergeLinkedLlists
    {
        public class node
        {
            public int value;
            public node? next;
            public node? pre;
            public node? first;
            public node? last;
            public node(int s)
            {
                value = s;
                next = null;
                pre = null;
                first = null;
                last = null;
            }
        }

        public node bulkNode(string stringNodes)
        {
            string[] items = stringNodes.Split(',');
            if (items.Length > 0)
            {
                node firstNode = new node(Int32.Parse(items[0]));
                node nextNode = firstNode;
                for (int i = 1; i < items.Length; i++)
                {
                    node newNode = new node(Int32.Parse(items[i]));
                    nextNode.next = newNode;
                    newNode.pre = nextNode;
                    nextNode = newNode;
                }
                return firstNode;
            }
            return new node(Int32.Parse(""));
        }



        public node mergeTwoList(node node1, node node2)
        {
            node result = new node(0);
            node pointer = null;
            node head1 = node1;
            node head2 = node2;
            //print(head1);

            node head1next = head1.next;
            node head2next = head2.next;


            if ((head1 != null) && (head2 != null))
                if (head2.value < head1.value)
                {
                    result.next = head2;  // head2 smaller
                    pointer = head2;
                    head2 = head2.next; 
                }
                else {
                    result.next = head1; //head1 smaller
                    pointer = head1;
                    head1 = head1.next;
                }



            while ((head1 != null) && (head2 != null))
            {
               // Console.Write(" ({0},{1}) ", head1.value, head2.value);
                if ((head1 != null) && (head2 != null))
                    if (head1.value < head2.value)
                    {
                        pointer.next = head1;
                        pointer = head1;
                        head1 = head1.next;
                    }
                    else
                    {
                        pointer.next = head2;
                        pointer = head2;
                        head2 = head2.next;
                    }


            }
            if ((head1 == null) && (head2 != null)) pointer.next = head2;
            if ((head2 == null) && (head1 != null)) pointer.next = head1;

            return result;
        }



        public void print(node n1)
        {
            node m1 = n1;
            if (n1 != null)
            {
                while (m1 != null)
                {
                    Console.Write("[" + m1.value + "] ");
                    m1 = m1.next;
                }
            }
            Console.WriteLine("");
        }


        public void testNode()
        {
            node n1 = bulkNode("1,2,3,4,6,9,11,14,15,17");
            node n2 = bulkNode("4,5,7,8,10,12,13,16,18,19,20,21,22");
            print(n1);
            print(n2);
            print(mergeTwoList(n1, n2));
            }
    }
}
