using System.Runtime.Serialization;

namespace TestMain;

public class BinaryTree
{
    public int Data { get; set; }
    public BinaryTree? LeftSubTree { get; set; }
    public BinaryTree? RightSubTree { get; set; }
    
    public BinaryTree(int data,BinaryTree? leftSubTree = null,BinaryTree? rightSubTree = null)
    {
        Data = data;
        LeftSubTree = leftSubTree;
        RightSubTree = rightSubTree;
    }


    public void PreOrderTraversal(BinaryTree? tree)
    {
        if (tree == null) return;
        Console.WriteLine(tree.Data);
        PreOrderTraversal(tree.LeftSubTree);
        PreOrderTraversal(tree.RightSubTree);
    }
    
    
    
}