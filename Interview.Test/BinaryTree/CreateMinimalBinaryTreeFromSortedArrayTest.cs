using FluentAssertions;
using Interview.BinaryTree;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Interview.Test.BinaryTree
{
    public class CreateMinimalBinaryTreeFromSortedArrayTest
    {
        [Fact]
        public void Create_GivenEmptyArray_ReturnsFailResult()
        {
            var array = new int[] { };

            var minimalBinaryTreeCreator = new CreateMinimalBinaryTreeFromSortedArray();

            var result = minimalBinaryTreeCreator.Create(array);

            result.IsFailure.Should().BeTrue();
        }


        [Fact]
        public void Create_GivenASortedArray_ReturnsMinimalBinaryTree()
        {
            var array = new int[] { 1,2,3,4,5,6,7,8,9 };

            var minimalBinaryTreeCreator = new CreateMinimalBinaryTreeFromSortedArray();

            var result = minimalBinaryTreeCreator.Create(array);

            result.IsSuccess.Should().BeTrue();
        }
    }
}
