using Interview.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interview.BinaryTree
{
    public class CreateMinimalBinaryTreeFromSortedArray
    {
        public Result Create(int[] array)
        {
            if (array.Length == 0) return Result.Fail("array cannot be empty");

            var tree = CreateMinimalTree(array, 0, array.Length);

            return Result<TreeNode>.Ok(tree);
        }

        private TreeNode CreateMinimalTree(int[] array, int low, int high)
        {
            if (low >= high) return null;

            var mid = (high + low) / 2;

            var node = new TreeNode(array[mid]);
            node.LeftChild = CreateMinimalTree(array, low, mid);
            node.RigthChild = CreateMinimalTree(array, mid + 1, high);

            return node;
        }
    }
}
