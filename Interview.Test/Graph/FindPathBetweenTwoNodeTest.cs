using FluentAssertions;
using Interview.Graph;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Interview.Test.Graph
{
    public class FindPathBetweenTwoNodeTest
    {

        [Fact]
        public void Find_GivenNullNodes_ReturnFailResult()
        {
            GraphNode<int> firstNode = null;
            GraphNode<int> secondNode = null;
            var finder = new FindPathBetweenTwoNode<int>();

            var result = finder.Find(firstNode, secondNode);

            result.IsSuccess.Should().BeFalse();
        }

        [Fact]
        public void Find_GivenTwoNodeWithExistingPath_ReturnSuccessResult()
        {
            var node1 = new GraphNode<int>(5);
            var node2 = new GraphNode<int>(7);
            var node3 = new GraphNode<int>(8);
            node1.AddChild(node2);
            node2.AddChild(node3);

            var finder = new FindPathBetweenTwoNode<int>();

            var result = finder.Find(node1, node2);

            result.IsSuccess.Should().BeTrue();
        }

        [Fact]
        public void Find_GivenTwoNodeWithNoPath_ReturnSuccessResult()
        {
            var node1 = new GraphNode<int>(5);
            var node2 = new GraphNode<int>(7);
            var node3 = new GraphNode<int>(8);
            var node4 = new GraphNode<int>(10);
            node1.AddChild(node2);
            node2.AddChild(node3);

            var finder = new FindPathBetweenTwoNode<int>();

            var result = finder.Find(node1, node4);

            result.IsSuccess.Should().BeFalse();
        }
    }
}
