using System.Collections;
using NUnit.Framework;
using UnityEngine;

public class SimpleTest
{
    [Test]
    public void SimpleTest_BasicArithmetic()
    {
        // Basic test to verify 1 + 1 = 2
        int result = 1 + 1;
        Assert.AreEqual(2, result, "Basic addition test failed");
    }

    [Test]
    public void SimpleTest_StringComparison()
    {
        // String comparison test
        string expected = "Hello Unity";
        string actual = "Hello " + "Unity";
        Assert.AreEqual(expected, actual, "String concatenation test failed");
    }
}