using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.BinaryTree
{
    public class CheckBinarySearchTree
    {
        public bool Check(TreeNode root)
        {
            return ValidateTree(root, null, null);
        }

        private bool ValidateTree(TreeNode root, int? min, int? max)
        {
            if (root == null) return true;

            if( (min!=null && min>=root.Value) ||
                (max!=null && max<root.Value))
            {
                return false;
            }
            if (!ValidateTree(root.LeftChild, min, root.Value) ||
                !ValidateTree(root.RigthChild, root.Value, max))
                return false;
            return true;
        }
    }
}
