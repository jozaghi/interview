using FluentAssertions;
using Interview.Recursive;
using Interview.Shared;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Interview.Test.Recursive
{
    public class RobotNavigatorTest
    {

        [Fact]
        public void FindPath_GivenMatrix_ReturnPath()
        {
            var matrix = new int[,]
            {
                { 0,0,0,0,0,9 },
                { 0,1,0,0,1,1 },
                { 0,1,0,0,1,1 },
                { 10,0,0,0,1,1 }
            };

            var result = new RobotNavigator().FindPath(matrix);

            result.Should().NotBeNull();
        }

        [Fact]
        public void FindPath_GivenMatrixWithoutPathToGoal_ReturnNull()
        {
            var matrix = new int[,]
            {
                { 0,0,0,0,0,9 },
                { 0,1,0,0,1,1 },
                { 1,1,0,0,1,1 },
                { 10,1,0,0,1,1 }
            };

            var result = new RobotNavigator().FindPath(matrix);

            result.Should().BeNull();
        }
    }
}
