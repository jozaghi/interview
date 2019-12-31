using FluentAssertions;
using Interview.BinaryTree;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Interview.Test.BinaryTree
{
    public class CreateListFromBinaryTreeTest
    {

        [Fact]
        public void Create_GivenATreeWithDepthOf3_Returns3ListOfNodes_OneForEachLevel()
        {
            var root = new TreeNode {
                Value =1,
                LeftChild = new TreeNode
                {
                    Value=2,
                    LeftChild =new TreeNode(3),
                    RigthChild =new TreeNode(4)
                },
                RigthChild =new TreeNode
                {
                    Value = 5,
                    LeftChild = new TreeNode(6),
                    RigthChild = new TreeNode(7)
                }
            };
            var createListFromBinaryTree = new CreateListFromBinaryTree();

            var result = createListFromBinaryTree.Create(root);

            result.Data.Count.Should().Be(3);
        }
    }
}
