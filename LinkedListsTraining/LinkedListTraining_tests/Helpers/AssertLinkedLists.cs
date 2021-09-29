using LinkedListsTraining;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListTraining_tests.Helpers
{
    /*
     * Assert Linked Lists
     * 
     * Normally we would not create a helper method like this because the .Net Framework and MS Tests framework provide us with AssertCollect.AreEqual(), LinkList<List>, and LinkListNode.  We want to our chances of introducing errors and standardize or practice of using the test framework when possible.
     * 
     * This test helper method is an alternative and simple way for us check our LinkeLists working within the parameters and naming conventions of the problems posted at leetcode.
     */ 
    public static class AssertLinkedLists
    {
        public static void NodesHaveEqualValue(ListNode expected, ListNode actual)
        {
            while (expected != null)
            {
                Assert.AreEqual(expected.val, actual.val);
                expected = expected.next;
                actual = actual.next;
            }
        }
    }
}
