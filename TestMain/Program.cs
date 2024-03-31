// See https://aka.ms/new-console-template for more information

using TestMain;

struct Node_Data
{
    private string name;
    private int age;

    public Node_Data(string name,int age)
    {
        this.name = name;
        this.age = age;
    }

    public void PrintAllValues()
    {
        Console.Write("name : " + name + ", ");
        Console.WriteLine("age : "  + age);
    }
}

class Program
{
    static void Main(string[] args)
    {
        BinaryTree binaryTree1 = new BinaryTree(1);
        BinaryTree binaryTree2= new BinaryTree(2);
        BinaryTree binaryTree3 = new BinaryTree(3);
        BinaryTree binaryTree4 = new BinaryTree(4);
        BinaryTree binaryTree5 = new BinaryTree(5);
        BinaryTree binaryTree6 = new BinaryTree(6);
        BinaryTree binaryTree7 = new BinaryTree(7);

        binaryTree1.LeftSubTree = binaryTree2;
        binaryTree1.RightSubTree = binaryTree3;

        binaryTree2.LeftSubTree = binaryTree4;
        binaryTree2.RightSubTree = binaryTree5;

        binaryTree3.LeftSubTree = binaryTree6;
        binaryTree3.RightSubTree = binaryTree7;
        
        
        binaryTree1.PreOrderTraversal(binaryTree1);
    }
}