using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.LeetCode
{
    public class DeleteNodeinA_BST
    {
        public TreeNode Find(int value, TreeNode root, ref TreeNode parent)
        {
            if (root == null) return null;
            if (root.val == value)
                return root;
            else if (root.val < value)
            {
                parent = root;
                return Find(value, root.right, ref parent);
            }
            else
            {
                parent = root;
                return Find(value, root.left, ref parent);
            }
        }

        public bool IsLeftChild(TreeNode parent, TreeNode child)=> parent?.left != null && parent.left.val == child.val;
        private bool NodeIsLeaf(TreeNode node) => node.left == null && node.right == null;
        private bool NodeHasNoRightChild(TreeNode node) => node.right == null;
        private bool NodeHaseRightChildThatHasNullLeftChild(TreeNode node) => node.right != null && node.right.left == null;
        private bool NodeHaseRightChildThatHasNotNullLeftChild(TreeNode node) => node.right != null && node.right.left != null;

        public TreeNode DeleteNode(TreeNode root, int key)
        {
            var parent = (TreeNode)null;
            var node = Find(key, root, ref parent);
            if (node == null) return root;
            if (NodeIsLeaf(node))
            {
                if (parent == null) return null;
                if (IsLeftChild(parent, node))
                {
                    parent.left = node = null;
                }
                else
                {
                    parent.right = node = null;
                }
            }
            else if (NodeHasNoRightChild(node))
            {
                if (parent == null)
                    root = root.left;
                else
                {
                    if (IsLeftChild(parent, node))
                        parent.left = node.left;
                    else
                        parent.right = node.left;
                }
            }
            else if (NodeHaseRightChildThatHasNullLeftChild(node))
            {
                if(parent == null)
                {
                    root = root.right;
                    root.left = node.left;
                }
                else
                {
                    if (IsLeftChild(parent, node))
                    {
                        parent.left = node.right;
                        parent.left.left = node.left;
                    }
                    else
                    {
                        parent.right = node.right;
                        parent.right.left = node.left;
                    }
                }
            }
            else if (NodeHaseRightChildThatHasNotNullLeftChild(node))
            {
                //right child, find left most child node should replace it 
                var pointer = node.right;
                while (pointer.left.left!=null)
                {
                    pointer = pointer.left;
                }
                node.val = pointer.left.val;
                pointer.left = null;
            }

            return root;
        }
    }
}
