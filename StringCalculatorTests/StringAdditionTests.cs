using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringCalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculator.Tests
{
    [TestClass()]
    public class StringAdditionTests
    { 
        [TestMethod()]
       
        public void AddString_EmptyString_ReturnZero()
        {
            StringAddition stringAddition = new StringAddition();
            int res = stringAddition.AddString("");
            Assert.AreEqual(0, res);
        }
        [TestMethod()]
        public void AddString_OneNumber__ReturnNumber()
        {
            StringAddition stringAddition = new StringAddition();
            int res = stringAddition.AddString("1");
            Assert.AreEqual(1, res);
        }
        [TestMethod()]
        public void AddString_TwoNumber_ReturnSum()
        {
            StringAddition stringAddition = new StringAddition();
            int res = stringAddition.AddString("1,2");
            Assert.AreEqual(3, res);
        }
        [TestMethod()]
        public void AddString_CommaDelimeter_ReturnSum()
        {
            StringAddition stringAddition = new StringAddition();
            int res = stringAddition.AddString("1,2,25,55");
            Assert.AreEqual(83, res);
        }
        [TestMethod()]
        public void AddString_NewLineDelimeter_ReturnSum()
        {
            StringAddition stringAddition = new StringAddition();
            int res = stringAddition.AddString("1,2\n6,4");
            Assert.AreEqual(13, res);
        }
        [TestMethod()]
        public void AddString_AnotherDelimeter_ReturnSum()
        {
            StringAddition stringAddition = new StringAddition();
            int res = stringAddition.AddString("//;\n1;3;5");
            Assert.AreEqual(9, res);
        }
        [TestMethod()]
        public void AddString_NegativeNumer_ExceptionThrown()
        {
            try
            {
                StringAddition stringAddition = new StringAddition();
                int res = stringAddition.AddString("//;\n-1;3;-5");
                
            }catch(Exception e)
            {
                Assert.AreEqual("Negative Numbers Are Not Allowed: -1,-5", e.Message);
            }
        }

    }
}