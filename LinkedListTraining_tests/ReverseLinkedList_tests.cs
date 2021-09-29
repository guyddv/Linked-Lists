using LinkedListsTraining.ReverseLinkedList;
using LinkedListTraining_tests.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListTraining_tests
{
    [TestClass]
    public class ReverseLinkedLists_tests
    {
        [TestMethod]
        public void ReverseList_FiveItesm_ReturnsReverseLists()
        {
            //Arrange
            var input = LinkedListBuilder.CreateSinglyLinkedList(new int[] { 1, 2, 3, 4, 5 });
            var expected = LinkedListBuilder.CreateSinglyLinkedList(new int[] { 5, 4, 3, 2, 1 });
            var sut = new Solution();
            //Act
            var actual = sut.ReverseList(input);
            //Assert
            AssertLinkedLists.NodesHaveEqualValue(expected, actual);
        }
    }
}
