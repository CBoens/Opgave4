using Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProjectBog
{
    [TestClass]
    public class Bogtest
    {
        private Bog _bog;
        //private Bog _bog2;


        
        [TestInitialize]
        public void BeforeTest()
        {
            _bog = new Bog("Tosser", "landsby tossen", 657, "1234567890123");
            //_bog2 = new Bog("Jeg har RET", "lallende jubel", 1002, "1234567890124");
        }
        


        [TestMethod]
        public void BogTest()
        {
            Assert.AreEqual("Tosser", _bog.Titel);
            _bog.Titel = "John";
            Assert.AreEqual("John", _bog.Titel);

            Assert.AreEqual(657, _bog.Sidetal, 3);

            try
            {
                _bog.Titel = null;
                Assert.Fail();
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("Titel skal være længere end 2 tegn og være Gyldig", ex.Message);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestTitelException()
        {
            _bog.Titel = "e";
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestTitelExceptionTom()
        {
            _bog.Titel = "";
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestCheckForfatter()
        {
            _bog.Forfatter = "";
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestSidetalException()
        {
            _bog.Sidetal = 9;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestCheckISBN13()
        {
            _bog.ISBN13 = "123456789012";
        }

        

    }
}
