// See https://aka.ms/new-console-template for more information

using TestMain;

class Node_Data
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
        void PrintAllNodes(A_LinkedList<Node_Data> linkedList)
        {
            var r = linkedList.GetNode();
            while (r.next != null)
            {
                r.next.data.PrintAllValues();
                r = r.next;
            }
        }
        
        
        A_LinkedList<Node_Data> linkedList = new A_LinkedList<Node_Data>();
        linkedList.InsertFront(new Node_Data("eunggi",35));
        linkedList.InsertRear(new Node_Data("rear",34));
        linkedList.InsertFront(new Node_Data("juhee",34));
        linkedList.InsertFront(new Node_Data("front",34));
        linkedList.RemoveRear();
        linkedList.RemoveRear();
        linkedList.InsertFront(new Node_Data("juhee",34));
        linkedList.InsertFront(new Node_Data("front",34));
        linkedList.RemoveRear();

        
        PrintAllNodes(linkedList);
    }
}