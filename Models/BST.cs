using System.Runtime.InteropServices;
using BinarySearchTree.Models;

namespace BinarySearchTree.Models
{
    public class BST
    {
        public Node Root{get;set;}

        public BST(int val){
            Root = new Node(val);
        }
        public BST(){
            Root = null;
        }

        public BST InsertAt(Node newNode){
            if(Root == null){
                Root = newNode;
                return this;
            }
            else{
                var runner = Root;
                if(newNode.Val < runner.Val){
                    if(runner.Left == null){
                        runner.Left = newNode;
                        return this;
                    }
                    else{
                        runner = runner.Left;
                        return InsertAt(newNode);
                    }
                }
                else{
                    if(runner.Right == null){
                        runner.Right = newNode;
                        return this;
                    }
                    else{
                        runner = runner.Right;
                        return InsertAt(newNode);
                    }
                }
            }
        }
    }
}