using FluentAssertions;
using Interview.BinaryTree;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Interview.Test.BinaryTree
{
    public class CheckBalanceTreeTest
    {
        [Fact]
        public void Check_CallWithNullNodeAsRoot_ReturnsTrue()
        {
            var root = (TreeNode)null;
            var checkBalanceTree = new CheckBalanceTree();

            var result = checkBalanceTree.Check(root);

            result.Should().Be(true);
        }

        [Fact]
        public void Check_CallWithBalanceAsRoot_ReturnsTrue()
        {
            var root = new TreeNode
            {
                Value = 1,
                LeftChild = new TreeNode
                {
                    Value = 2,
                    LeftChild = new TreeNode(3),
                    RigthChild = new TreeNode(4)
                },
                RigthChild = new TreeNode
                {
                    Value = 5,
                    LeftChild = new TreeNode(6),
                    RigthChild = new TreeNode(7)
                }
            }; 
            var checkBalanceTree = new CheckBalanceTree();

            var result = checkBalanceTree.Check(root);

            result.Should().Be(true);
        }

        [Fact]
        public void Check_CallWithNotBalanceTreeAsRoot_ReturnsFalse()
        {
            var root = new TreeNode
            {
                Value = 1,
                LeftChild = new TreeNode
                {
                    Value = 2,
                    LeftChild = new TreeNode(3),
                    RigthChild = new TreeNode(4)
                },
                RigthChild = new TreeNode
                {
                    Value = 5,
                    LeftChild = new TreeNode {
                        Value = 6,
                        LeftChild = new TreeNode
                        {
                            Value=10,
                            LeftChild=new TreeNode(20)
                        }
                    },
                    RigthChild = new TreeNode(7)
                }
            };
            var checkBalanceTree = new CheckBalanceTree();

            var result = checkBalanceTree.Check(root);

            result.Should().Be(false);
        }
    }
}
