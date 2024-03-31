namespace TestMain;

public class A_CircularLinkedList<T>
{
    private Node<T> head = new Node<T>();
    private Node<T> list;
    
    public Node<T> AllocNode()
    {
        return new Node<T>();
    }
    
    public void InsertFront(T data)
    {
        Node<T> _node = AllocNode();
        if (head.next == null)
        {
            _node.next = _node;
            _node.data = data;
            head.next = _node;
        }
        else
        {
            Node<T> temp = head.next; //첫번째 노드의 주소를 임시 순회 포인터 temp에 저장

            while (temp.next != head.next)
            {
                temp = temp.next;
            }
            _node.next = head.next;
            temp.next = _node;
            head.next = _node;
        }
    }

    public T FindNode(T data)
    {
         //TODO 구현 필요
        Node<T> _list = head;
        Node<T> temp = _list;
        return temp.data;
    }

    public void InsertMiddle(T data)
    {
        
    }
}