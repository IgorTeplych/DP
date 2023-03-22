namespace DP.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void OneTwoBulletTest1()
        {
            OneTwoBullet oneTwoBullet = new OneTwoBullet();
            string result = oneTwoBullet.Solve("2/12+3/52");

            Assert.AreEqual("35/156", result);
        }
    }
}