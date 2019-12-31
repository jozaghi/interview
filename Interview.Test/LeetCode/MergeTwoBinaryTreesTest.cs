using FluentAssertions;
using Interview.LeetCode;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Interview.Test.LeetCode
{
    public class MergeTwoBinaryTreesTest
    {
        [Fact]
        public void MergeTrees()
        {
            var first = new TreeNode(1);
            first.left = new TreeNode(3);
            first.left.left = new TreeNode(5);
            first.right = new TreeNode(2);

            var second = new TreeNode(2);
            second.left = new TreeNode(1);
            second.left.right = new TreeNode(4);
            second.right = new TreeNode(3);
            second.right.right = new TreeNode(7);

            var result = new MergeTwoBinaryTrees().MergeTrees(first, second);

            result.Should().NotBeNull();

        }
    }
}
