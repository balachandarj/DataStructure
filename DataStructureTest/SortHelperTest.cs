using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Core;
using NUnit.Framework;
using DataStructure;

namespace DataStructureTest
{
    [TestFixture]
    public class SortHelperTest
    {
        [Test]
        public void BubbleSortTest()
        {
            int[] myArray = new int[7] { 22, 34, 11, 45, 32, 48, 21 };
            int[] expected = new int[7] { 11, 21, 22, 32, 34, 45, 48 };

            var result = SortHelper.BubbleSort(myArray);
            Assert.AreEqual(expected, result);        
        }

        [Test]
        public void BubbleSortTest_OneElement()
        {
            int[] myArray = new int[1] { 22};
            int[] expected = new int[1] { 22 };

            var result = SortHelper.BubbleSort(myArray);
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void BubbleSortTest_EmptyArray()
        {
            int[] myArray = new int[0];
            Assert.That(()=>SortHelper.BubbleSort(myArray),Throws.TypeOf<Exception>().With.Message.EqualTo("Invalid input"));
        }

    }
}
