namespace binarysearchtrees;

public class Node
{
    public int Data { get; set; }
    public Node? Left { get; set; }
    public Node? Right { get; set; }

    public Node(int data)
    {
        this.Data = data;
        Left = null;
        Right = null;
    }
}