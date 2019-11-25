using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StringProcessing;
using Xunit;



namespace DemoLibrary.Tests
{
    public class NonDecreasingTaskListTests
    {
        [Fact]
        public void NonDecreasingTaskList_InputValidation()
        {
            //Arrange
            int[] expected = { 2, 5, 3, 7, 4 };

            //Act 
            MonkTasks mT = new MonkTasks();
            string tasks = "3 4 7 10";
            int[] actual = mT.NonDecreasingTaskList(4, tasks);
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
