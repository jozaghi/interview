using FluentAssertions;
using Interview.LinkedList;
using System;
using System.Text;
using Xunit;
namespace Interview.Test.LinkedList
{
    public class LinkedListTest
    {
        private readonly Interview.LinkedList.LinkedList<int> _linkedList;
        public LinkedListTest()
        {
            _linkedList = new Interview.LinkedList.LinkedList<int>();
        }

        #region find nth number from the end of linkedlist

        [Fact]
        public void FindNthItemFromTheEnd_TestEmptyList_ReturnsFailResult()
        {
            var result = _linkedList.FindNthItemFromTheEnd(0);
            result.IsFailure.Should().BeTrue();
        }

        [Fact]
        public void FindNthItemFromTheEnd_ItemInRange_ReturnsSuccessResultAndValue()
        {
            _linkedList.Prepend(3)
                       .Prepend(6)
                       .Prepend(9);

            var result = _linkedList.FindNthItemFromTheEnd(2);
            
            result.IsSuccess.Should().BeTrue();
            result.Data.Should().Be(6);
        }

        [Fact]
        public void FindNthItemFromTheEnd_FistItemInRange_ReturnsSuccessResultAndValue()
        {
            _linkedList.Prepend(3)
                       .Prepend(6)
                       .Prepend(9);

            var result = _linkedList.FindNthItemFromTheEnd(1);

            result.IsSuccess.Should().BeTrue();
            result.Data.Should().Be(3);
        }

        [Fact]
        public void FindNthItemFromTheEnd_LastItemInRange_ReturnsSuccessResultAndValue()
        {
            _linkedList.Prepend(3)
                       .Prepend(6)
                       .Prepend(9);

            var result = _linkedList.FindNthItemFromTheEnd(3);

            result.IsSuccess.Should().BeTrue();
            result.Data.Should().Be(9);
        }
        [Fact]
        public void FindNthItemFromTheEnd_ItemOutIfRange_ReturnsFailResult()
        {
            _linkedList.Prepend(3)
                       .Prepend(6)
                       .Prepend(9);

            var result = _linkedList.FindNthItemFromTheEnd(4);

            result.IsFailure.Should().BeTrue();
        }
        #endregion

        #region sum of numbers in two linked list
        
        [Fact]
        public void SumTwoLinkedList()
        {
            

            //var result = LinkedList<int>.Sum(null, null);

            //result.IsFailure.Should().BeTrue();
            
        }
        
        #endregion

    }
}
