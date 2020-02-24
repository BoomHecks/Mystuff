using NUnit.Framework;
using Problems;

namespace Problems.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Program p = new Program();
            string output = p.Prifix("Hello");
            Assert.AreEqual("5,1:Hello", output);
            Assert.Pass();
        }
        [Test]
        public void Test2()
        {
            Program p = new Program();
            string output = p.Prifix("Hello world");
            Assert.AreEqual("11,2:Hello world", output);
            Assert.Pass();
        }
        [Test]
        public void Test3()
        {
            Program p = new Program();
            string output = p.Prifix("");
            Assert.AreEqual("0,0:", output);
            Assert.Pass();
        }





    }
}