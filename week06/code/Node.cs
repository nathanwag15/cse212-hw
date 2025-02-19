public class Node
{
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data)
    {
        this.Data = data;
    }

    public void Insert(int value)
    {
        if (value < Data)
        {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        else if (value > Data) 
        {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }

    }

    public bool Contains(int value)
    {
        if (value == Data)
            return true; // Value found

        if (value < Data)
        {
            // Search in the left subtree
            return Left != null && Left.Contains(value);
        }
        else
        {
            // Search in the right subtree
            return Right != null && Right.Contains(value);
        }
    }

    public int GetHeight()
    {
        // Base case: If the node is a leaf (no children), height is 1
        int leftHeight = Left?.GetHeight() ?? 0;
        int rightHeight = Right?.GetHeight() ?? 0;

        // Height of the tree is 1 + the maximum height of its subtrees
        return 1 + Math.Max(leftHeight, rightHeight);
    }

}