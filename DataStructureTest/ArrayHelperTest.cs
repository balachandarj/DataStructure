using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructure;
using NUnit.Framework;

namespace DataStructureTest
{
   [TestFixture]
    public class ArrayHelperTest
    {
       [Test]
       public void RemoveDuplicateCharacterTest()
       {
           var inputText = "ABCDAADDB";
           var expectedText = "ABCD";
           var result = ArrayHelper.RemoveDuplicateCharacter(inputText);
           Assert.AreEqual(expectedText, result);

       }
    }
}
