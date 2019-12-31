namespace Interview.BinaryTree
{
    public class TreeNode
    {
        public TreeNode()
        {

        }
        public TreeNode(int value)
        {
            Value = value;
        }
        public int Value { get; set; }
        public TreeNode LeftChild { get; set; }
        public TreeNode RigthChild { get; set; }
    }
}
