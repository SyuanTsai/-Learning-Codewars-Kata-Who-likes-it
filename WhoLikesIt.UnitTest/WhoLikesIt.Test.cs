namespace WhoLikesIt.UnitTest;

public class WhoLikesItTest
{
    private WhoLikesIt? _sut;

    [SetUp]
    public void Setup()
    {
        _sut = new WhoLikesIt();
    }

    [Test]
    public void Should_Return_End_With_Likes_this()
    {
        List<string> data = new List<string>();
        var act =  _sut.Likes(data);
        Assert.That( act, Does.EndWith("likes this"), "End string should be `likes this`");
    }
}