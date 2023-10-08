using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace TestMain;

public class Node<T>
{
    internal T data;
    internal Node<T> next;
}

public class A_LinkedList<T>
{
    private Node<T> head = new Node<T>();
    private Node<T> list;

    public A_LinkedList() //LinkedList Initialize
    {
        Console.WriteLine("linked List 생성");
        head.next = null;
    }

    public Node<T> AllocNode()
    {
        return new Node<T>();
    }


    // 가장 앞단에 Node 삽입
    public void InsertFront(T data)
    {
        Node<T> _node = AllocNode();
        if (head.next == null)
        {
            _node.next = null;
            _node.data = data;
            head.next = _node;
        }
        else
        {
            Node<T> _next = head.next;
            _node.next = _next;
            _node.data = data;
            head.next = _node;
        }
    }
    //가장 뒷단에 Node 삽입
    public void InsertRear(T Data)
    {
        Node<T> _node = AllocNode();
        _node.data = Data;
        _node.next = null;
        if (head.next == null)
            head.next = _node;
        else
        {
            var tempNode = head;
            while (tempNode.next != null)
            {
                tempNode = tempNode.next;
            }

            tempNode.next = _node;
        }
    }
    public void RemoveFront()
    {
        if (head.next != null)
        {
            var frontNode = head.next;
            head.next = frontNode.next;
            frontNode.next = null;
        }
    }
    public void RemoveRear()
    {
        var _tempNode = head;
        Node<T> prevNode = _tempNode;
        while (_tempNode.next != null)
        {
            prevNode = _tempNode;
            _tempNode = _tempNode.next;
        }
        prevNode.next = null;
    }

    public Node<T> GetNode()
    {
        return head;
    }
}