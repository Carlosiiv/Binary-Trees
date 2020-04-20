namespace BinarySearchTree.Models
{
    public class Node
    {
        public int Val{get;set;}
        public Node Left{get;set;}
        public Node Right{get;set;}

        public Node(int val){
            Val = val;
            Left = null;
            Right = null;
        }
    }
}