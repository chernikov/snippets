using NUnit.Framework;

namespace FindingPath.Tests
{
    public class FinderTests
    {

        [Test]
        public void test1()
        {
            string d = "......\n" +
                "......\n" +
                "......\n" +
                "......\n" +
                ".....W\n" +
                "....W.";
            var result = Finder.PathFinder(d);
            Assert.AreEqual(false, result);
        }

        [Test]
        public void test2()
        {

            string a = ".W.\n" +
                ".W.\n" +
                "...";
            var result = Finder.PathFinder(a);
            Assert.AreEqual(true, result);
        }

        [Test]
        public void test3()
        {
            string b = ".W.\n" +
                ".W.\n" +
                "W..";
            var result = Finder.PathFinder(b);
            Assert.AreEqual(false, result);
        }

        [Test]
        public void test4()
        {
            string c = "......\n" +
                "......\n" +
                "......\n" +
                "......\n" +
                "......\n" +
                "......";
            var result = Finder.PathFinder(c);
            Assert.AreEqual(true, result);
            
        }

        [Test]
        public void test5()
        {
            string c = 
                ".W...W\n" +
                ".W.W.W\n" +
                ".W.W.W\n" +
                ".W.W.W\n" +
                ".W.W.W\n" +
                "...W..";
            var result = Finder.PathFinder(c);
            Assert.AreEqual(true, result);
            
        }
    }
}