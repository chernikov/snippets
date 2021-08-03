using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

[TestFixture]
public class SolutionTest
{

    [Test]
    public void TestBasic()
    {

        string d = @".";

        /*Assert.AreEqual(4, Finder.PathFinder(a));
        Assert.AreEqual(-1, Finder.PathFinder(b));
        Assert.AreEqual(10, Finder.PathFinder(c));*/
        Assert.AreEqual(0, Finder.PathFinder(d));
    }

    
}

