using System;
using TddAssignment;
using Xunit;

namespace TddAssignmentsTest
{
    public class CodewarsTest
    {
        /* not needed, static method
        private readonly Codewars codewars;

        public CodewarsTest()
        {
            codewars = new Codewars();
        }*/

        [Theory] //you can run a test multiple times with different data sets
        [InlineData(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 }, "(123) 456-7890")]
        [InlineData(new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }, "(111) 111-1111")]
        
        public void Should_Return_The_Proper_String_Format(int[] input, string expected)
        {

            //arrange - InlineData

            //act
            string actual = Codewars.ConvertArrayToRequestedStringFormat(input);

            //assert
            Assert.Equal(expected, actual);
            
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4, 5, 6, 7, 8})]
        [InlineData(new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1,2 })]

        public void InvalidInputShouldFail(int[] input)
        {

            //assert
            Assert.True(input.Length != 10);
            Assert.Throws<ArgumentException>(() => 
                Codewars.ConvertArrayToRequestedStringFormat(input));

        }
    }
}