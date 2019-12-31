using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.BinaryTree
{
    public class CheckBalanceTree
    {
        const int MinValue = int.MinValue;
        public bool Check(TreeNode root)
        {
            return CheckHeight(root) != MinValue;
        }

        private int CheckHeight(TreeNode root)
        {
            if (root == null) return -1;

            var leftHeight = CheckHeight(root.LeftChild);
            if (leftHeight == MinValue) return MinValue;

            var rightHeight = CheckHeight(root.RigthChild);
            if (rightHeight == MinValue) return MinValue;

            var differnce = Math.Abs(leftHeight - rightHeight);
            if (differnce > 1) return MinValue;

            return Math.Max(leftHeight, rightHeight) + 1;
        }
    }
}
