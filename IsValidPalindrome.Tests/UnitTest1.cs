namespace IsValidPalindrome.Tests;

[TestClass]
public class UnitTest1
{
    private readonly Class1 _test;

    public UnitTest1() { _test = new Class1(); }
    
    [TestMethod]
    public void TestMethod1()
    {
        string s = "A man, a plan, a canal: Panama";
        var result = _test.IsPalindrome(s);
        Assert.IsTrue(result);
    }
    
    [TestMethod]
    public void TestMethod2()
    {
        string s = "race a car";
        var result = _test.IsPalindrome(s);
        Assert.IsFalse(result);
    }
    
    [TestMethod]
    public void TestMethod3()
    {
        string s = " ";
        var result = _test.IsPalindrome(s);
        Assert.IsTrue(result);
    }
    
    [TestMethod]
    public void TestMethod4()
    {
        string s = "0P";
        var result = _test.IsPalindrome(s);
        Assert.IsFalse(result);
    }
}