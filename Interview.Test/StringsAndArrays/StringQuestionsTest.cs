using FluentAssertions;
using Interview.StringsAndArrays;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Interview.Test.StringsAndArrays
{
    public class StringQuestionsTest
    {

        private readonly StringQuestions _stingQuestion;

        public StringQuestionsTest()
        {
            _stingQuestion = new StringQuestions();
        }

        [Theory]
        [InlineData("Aabcdt",true)]
        [InlineData("Aabcadt",false)]
        [InlineData("",true)]
        public void CheckStringHasUniqueChars(string @string, bool expectedResult)
        {
            var stringQuestions = new StringQuestions();

            var result = stringQuestions.IsStringHasUniqueChars(@string);

            result.Should().Be(expectedResult);
        }



        [Theory]
        [InlineData("abc", new string[]{ "abc","acb","bac","bca","cba","cab"})]
        [InlineData("ab", new string[]{ "ab","ba"})]
        public void CreateAllPermutaionOfOneString(string input,string[] expected)
        {
            var stringQuestions = new StringQuestions();

            var result = stringQuestions.GetAllPermutation(input);

            result.Should().BeEquivalentTo(expected);
        }

        

        [Theory]
        [InlineData("","")]
        [InlineData("aaabbbccc","a3b3c3")]
        [InlineData("abcdef","abcdef")]
        public void CompressString(string input, string expectedResult)
        {
            var result = _stingQuestion.Compress(input);

            result.Should().Be(expectedResult);
        }


        [Fact]
        public void RotateMatrix()
        {
            var matrix = new int[,]
            {
                { 1,2,3 },
                { 6,5,4 },
                { 9,8,7 },
            };
            var expectedResult = new[,]
            {
                { 9,6,1 },
                { 8,5,2 },
                { 7,4,3 },
            };

            var result = _stingQuestion.RotateMatrix(matrix);

            result.Should().BeEquivalentTo(expectedResult);
        
        
        }



    }
}
