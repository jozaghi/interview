using FluentAssertions;
using Interview.Stack;
using System;
using System.Text;
using Xunit;

namespace Interview.Test.StackAndQueue
{
    public class StackTest
    {
        [Fact]
        public void PushAndPopDataFromStack()
        {
            var stack = new Stack<int>();
            stack.Push(1)
                 .Push(2)
                 .Push(3);

            stack.Peek().Data.Should().Be(3);
            stack.Pop().Data.Should().Be(3);
            stack.Pop().Data.Should().Be(2);
            stack.Pop().Data.Should().Be(1);

        }

        [Fact]
        public void IsEmpty_GivenAnEmptyStack_ReturnsTrue()
        {
            var stack = new Stack<int>();
            stack.IsEmpty().Should().BeTrue();
        }

        [Fact]
        public void IsEmpty_GivenNotEmptyStack_ReturnsFalse()
        {
            var stack = new Stack<int>()
                .Push(1);
            stack.IsEmpty().Should().BeFalse();
        } 

        [Fact]
        public void Min_GivenAFullStack_ReturnsMinimumValue()
        {
            var stack = new Stack<int>()
                .Push(3)
                .Push(1)
                .Push(30)
                .Push(2);
            stack.Min.Data.Should().Be(1);
        }

    }
}
