using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePackage
{
  
    public class Btree
    {
        public Btree left;
        public Btree right;
        public int value;
        public string leftChildrens;
        public string rightChildrens;
        public string childrens;
        public Btree(int _value, Btree _left, Btree _right)
        {
            left = _left;
            right = _right;
            value = _value;
            leftChildrens = "";
            rightChildrens = "";
            childrens = "";
        }
    }

 public class BtreeCheck
    {
        Stack st = new Stack();
        Queue q = new Queue();

        string childrens = "";

        public void ScanChildren(Btree btree)
        {
          
            childrens += btree.value.ToString() + ",";
            if (btree.left != null)
             ScanChildren(btree.left);
            
            if (btree.right != null)
             ScanChildren(btree.right);
                    }


        public string TreeChild(Btree btree)
        {
            childrens = "";
            ScanChildren(btree.left);
            string left = childrens;

            childrens = "";
            ScanChildren(btree.right);
            string right = childrens;
            Console.Write("left:[");
            Console.Write(left);
            Console.Write("] Right:[");
            Console.Write(right+"]");

            if (left == right) return "YES";
            else return "NO";
        }
       

     

        public string TraversalofBinaryTree()
        {
            Btree b = new Btree(1, new Btree(2, new Btree(4, null, null), new Btree(3, null, null)), new Btree(2, new Btree(4, null, null), new Btree(3, null, null)));

            Queue q = new Queue();
            
            return "";
        }


        public string isSymmetric()
        {
          Btree b = new Btree(1, new Btree(2, new Btree(4, null, null), new Btree(3, null, null)), new Btree(2, new Btree(4, null, null), new Btree(3, null, null)));
          return TreeChild(b);
          
        }
    }
}
