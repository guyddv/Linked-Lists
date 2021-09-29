using LinkedListsTraining.AddTwoNumbers;
using LinkedListTraining_tests.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinkedListTraining_tests
{
    [TestClass]
    public class AddTwoNumbers_tests
    {
        [TestMethod]
        public void AddTwoNumbers_SingleDigits_ReturnsAddedNumbers()
        {
            //Arrange
            var input_l1 = LinkedListBuilder.CreateSinglyLinkedList(new int[] { 1 });
            var input_l2 = LinkedListBuilder.CreateSinglyLinkedList(new int[] { 2 });
            var expected = LinkedListBuilder.CreateSinglyLinkedList(new int[] { 3 });
            var sut = new Solution();
            //Act
            var actual = sut.AddTwoNumbers(input_l1, input_l2);
            //Assert
            AssertLinkedLists.NodesHaveEqualValue(expected, actual);
        }

        [TestMethod]
        public void AddTwoNumbers_MultipleDigits_ReturnsAddedNumbers()
        {
            var input_l1 = LinkedListBuilder.CreateSinglyLinkedList(new int[] { 1, 1, 1 });
            var input_l2 = LinkedListBuilder.CreateSinglyLinkedList(new int[] { 2, 2, 2 });
            var expected = LinkedListBuilder.CreateSinglyLinkedList(new int[] { 3, 3, 3 });
            var sut = new Solution();

            var actual = sut.AddTwoNumbers(input_l1, input_l2);

            AssertLinkedLists.NodesHaveEqualValue(expected, actual);
        }
    }
}
