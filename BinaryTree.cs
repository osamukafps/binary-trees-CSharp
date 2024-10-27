using System.Reflection;

namespace binarysearchtrees;

public class BinaryTree
{
    public Node? Root { get; set; }

    public BinaryTree()
    {
        Root = null;
    }

    public BinaryTree(Node node)
    {
        this.Root = node;
    }

    public void InorderTraversal(Node? node = null)
    {
        if (node is null)
            node = Root;
        
        if(node.Left is not null)
            InorderTraversal(node.Left);
        
        Console.Write(node.Data + " ");
        
        if(node.Right is not null)
            InorderTraversal(node.Right);
    }

    public void LevelOrderTraversal(Node? node = null)
    {
        if (node is null)
            node = this.Root;

        Queue<Node> nodeQueue = new Queue<Node>();
        nodeQueue.Enqueue(node);

        while (nodeQueue.Count > 0)
        {
            node = nodeQueue.Dequeue();
            
            if(node.Left is not null)
                nodeQueue.Enqueue(node.Left);
            if(node.Right is not null)
                nodeQueue.Enqueue(node.Right);
            
            Console.WriteLine(node.Data);
        }
    }

    
}