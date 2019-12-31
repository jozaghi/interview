using FluentAssertions;
using Interview.BinaryTree;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Interview.Test.BinaryTree
{
    public class CheckBinarySearchTreeTest
    {
        [Fact]
        public void Check_GivenBinarySeachTree_ReturnTrue()
        {
            var root = new TreeNode
            {
                Value = 3,
                LeftChild = new TreeNode
                {
                    Value = 1,
                    RigthChild = new TreeNode(3)
                },
                RigthChild = new TreeNode
                {
                    Value = 5,
                    LeftChild = new TreeNode(4)
                }
            };
            var checkBinaryTree = new CheckBinarySearchTree();

            var result = checkBinaryTree.Check(root);

            result.Should().Be(true);
        }

    }
}
