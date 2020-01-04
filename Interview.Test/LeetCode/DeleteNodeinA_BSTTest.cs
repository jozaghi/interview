using FluentAssertions;
using Interview.LeetCode;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Interview.Test.LeetCode
{
    public class DeleteNodeinA_BSTTest
    {
        private TreeNode GetTree()
        {
            var root = new TreeNode(5);

            root.left = new TreeNode(3);
            root.left.left = new TreeNode(2);
            root.left.right = new TreeNode(4);

            root.right = new TreeNode(6);
            root.right.right = new TreeNode(7);
            return root;

        }
        [Fact]
        public void Find()
        {
            var root = GetTree();

            root.right = new TreeNode(6);
            root.right.right = new TreeNode(7);


            var d = new DeleteNodeinA_BST();
            var parent = (TreeNode)null;
            var node = d.Find(5, root, ref parent);

            parent.Should().BeNull();
            node.Should().NotBeNull();
            node.val.Should().Be(5);

        }

        [Fact]
        public void Find2()
        {
            var root = GetTree();


            var d = new DeleteNodeinA_BST();
            var parent = (TreeNode)null;
            var node = d.Find(2, root, ref parent);

            parent.Should().NotBeNull();
            parent.val.Should().Be(3);
            node.Should().NotBeNull();
            node.val.Should().Be(2);

        }


        [Fact]
        public void DeleteNode_GivenAnullTree_ReturnsNull()
        {
            var root = (TreeNode)null;

            var d = new DeleteNodeinA_BST();
            var result = d.DeleteNode(root, 5);

            result.Should().BeNull();
        }

        [Fact]
        public void DeleteNode_TryToDeleteNodeWhichIsNotExist_ReturnsRoot()
        {
            var root = GetTree();

            var d = new DeleteNodeinA_BST();
            var result = d.DeleteNode(root, 9);

            result.Should().NotBeNull();
        }

        [Fact]
        public void DeleteNode_TryToDeleteLeafNode_ReturnsRootWithoutTheLeaf()
        {
            var root = GetTree();

            var d = new DeleteNodeinA_BST();
            var result = d.DeleteNode(root, 4);

            result.Should().NotBeNull();
        }

        [Fact]
        public void DeleteNode_TryToDeleteNodeWithoutRightChild_ReturnsRootWithoutTheNode()
        {
            var root = GetTree();

            root.left.right = null;

            var d = new DeleteNodeinA_BST();
            var result = d.DeleteNode(root, 3);

            result.Should().NotBeNull();
        }

    }


}
