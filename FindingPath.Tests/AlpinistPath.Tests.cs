using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

[TestFixture]
public class AlpinistTest
{
     [Test]
    public void SampleTests()
    {
       string a = "000\n" +
                   "000\n" +
                   "000",

               b = "010\n" +
                   "010\n" +
                   "010",

               c = "010\n" +
                   "101\n" +
                   "010",

               d = "0707\n" +
                   "7070\n" +
                   "0707\n" +
                   "7070",

               e = "700000\n" +
                   "077770\n" +
                   "077770\n" +
                   "077770\n" +
                   "077770\n" +
                   "000007",

               f = "777000\n" +
                   "007000\n" +
                   "007000\n" +
                   "007000\n" +
                   "007000\n" +
                   "007777",

               g = "000000\n" +
                   "000000\n" +
                   "000000\n" +
                   "000010\n" +
                   "000109\n" +
                   "001010";

         Assert.AreEqual(0, Alpinist.PathFinder(a));
          Assert.AreEqual(2, Alpinist.PathFinder(b));
          Assert.AreEqual(4, Alpinist.PathFinder(c));
          Assert.AreEqual(42, Alpinist.PathFinder(d));
          Assert.AreEqual(14, Alpinist.PathFinder(e));
         Assert.AreEqual(0, Alpinist.PathFinder(f));
        Assert.AreEqual(4, Alpinist.PathFinder(g));
    }

}