namespace binarysearchtrees;

public class BinarySearchTree : BinaryTree
{
    public void Insert(int value)
    {
        Node parentNode = null;
        Node auxPointer = Root;

        while (auxPointer != null)
        {
            parentNode = auxPointer;

            if (value < auxPointer.Data)
                auxPointer = auxPointer.Left;
            else
                auxPointer = auxPointer.Right;
        }

        if (parentNode is null)
            Root = new Node(value);
        else if (value < parentNode.Data)
            parentNode.Left = new Node(value);
        else
            parentNode.Right = new Node(value);
    }

    public BinaryTree Search(int value, Node? node = null)
    {
        if (node == null)
            node = this.Root;

        if (node is null)
            return null;

        if (node.Data == value)
            return new BinaryTree(node);

        if (value < node.Data)
            return this.Search(value, node.Left);
        return this.Search(value, node.Right);
    }

    
    public Node Remove(int value, Node? node = null)
    {
        if (node is null)
            node = this.Root;

        if (node is null)
            return node;

        if (value < node.Data)
            node.Left = this.Remove(value, node.Left);
        else if (value > node.Data)
            node.Right = this.Remove(value, node.Right);
        else
        {
            if (node.Left is null)
                return node.Right;
            else if (node.Right is null)
                return node.Left;
            else
            {
                int substitute = this.Min(node.Right);
                node.Data = substitute;
                node.Right = this.Remove(substitute, node.Right);
            }
        }

        return node;
    }
    
    public int Min(Node? node = null)
    {
        if (node is null)
            node = this.Root;

        while (node.Left is not null)
            node = node.Left;
        
        return node.Data;
    }

    public int Max(Node? node = null)
    {
        if (node is null)
            node = this.Root;

        while (node.Right != null)
        {
            node = node.Right;
        }
        
        return node.Data;
    }
}