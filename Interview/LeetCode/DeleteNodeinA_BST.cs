using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.LeetCode
{
    public class DeleteNodeinA_BST
    {
        public TreeNode Find(int value, TreeNode root, TreeNode parent)
        {
            if (root == null) return null;
            if (root.val == value) 
                return root;
            else if (root.val < value)
                return Find(value, root.right, root);
            else
                return Find(value, root.left, root);
        }

        public bool IsLeftChild(TreeNode parent, TreeNode child)
        {
            return parent?.left != null && parent.left.val == child.val;
        }

        public TreeNode DeleteNode(TreeNode root, int key)
        {
            var parent = (TreeNode)null;
            var node = Find(key, root, parent);
            if (node == null) return null;
            //leaf
            if(node.left ==null && node.right ==null)
            {
                if (parent == null)
                {
                    root = null;
                }
                if (IsLeftChild(parent,node))
                    parent.left = null;
                else
                    parent.right = null;
            }
            //no right child
            else if (node.right == null)
            {
                if (parent == null)
                {
                    root = root.left;
                }
                else
                {
                    if (IsLeftChild(parent,node))
                        parent.left = root.left;
                    else
                        parent.right = root.left;
                }
            }
            else if(node.right != null && node.right.left == null)
            {
                if(parent == null)
                {
                    root = node.right;
                    root.left = node.left;
                }
                else
                {
                    if (IsLeftChild(parent, node))
                    {
                        parent.left = node.right;
                        parent.left.left = node.left;
                    }
                }
            }
            else if(node.right != null && node.right.left != null)
            {
                //find left most child and replace it with the node 
            }

            return node;
        }
    }
}
