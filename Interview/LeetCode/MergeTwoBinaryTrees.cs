using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.LeetCode
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }
    public class MergeTwoBinaryTrees
    {
        public TreeNode MergeTrees(TreeNode first, TreeNode second)
        {
            if (first == null && second == null) return null;
            
            var value = (first?.val??0) + (second?.val??0);
            var node = new TreeNode(value);
            node.left = MergeTrees(first?.left, second?.left);
            node.right = MergeTrees(first?.right, second?.right);

            return node;
        }
    }
}
