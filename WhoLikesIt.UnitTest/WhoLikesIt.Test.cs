namespace WhoLikesIt.UnitTest;

public class WhoLikesItTest
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        var sut = new WhoLikesIt();
        List<string> data = new List<string>();
        sut.Likes(data);
    }
}