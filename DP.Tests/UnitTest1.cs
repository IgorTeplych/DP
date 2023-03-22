namespace DP.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void FiveEightTest1()
        {
            FiveEight fiveEight = new FiveEight();
            int num = fiveEight.Solve(5, 8, 4);

            Assert.AreEqual(num, 16);
        }
        [Test]
        public void FiveEightTest2()
        {
            FiveEight fiveEight = new FiveEight();
            int num = fiveEight.Solve(5, 8, 5);

            Assert.AreEqual(num, 26);
        }
        [Test]
        public void FiveEightTest3()
        {
            FiveEight fiveEight = new FiveEight();
            int num = fiveEight.Solve(5, 8, 9);

            Assert.AreEqual(num, 178);
        }

        [Test]
        public void OneTwoBulletTest1()
        {
            OneTwoBullet oneTwoBullet = new OneTwoBullet();
            string result = oneTwoBullet.Solve("2/12+3/52");

            Assert.AreEqual("35/156", result);
        }
        [Test]
        public void OneTwoBulletTest2()
        {
            OneTwoBullet oneTwoBullet = new OneTwoBullet();
            string result = oneTwoBullet.Solve("1/38+3/52");

            Assert.AreEqual("83/988", result);
        }
        [Test]
        public void DigitalTree()
        {
            int[][] tree = new int[4][];
            tree[0] = new int[] { 1 };
            tree[1] = new int[] { 2, 3 };
            tree[2] = new int[] { 4, 5, 6 };
            tree[3] = new int[] { 9, 8, 0, 3 };
            DigitalSpruce digitalSpruce = new DigitalSpruce();
            int result = digitalSpruce.GetMaxWay(tree);

            Assert.AreEqual(17, result);
        }
        [Test]
        public void CountIslandsTest()
        {
            int[][] map = new int[10][];
            map[0] = new int[] { 0, 1, 1, 0, 0, 1, 0, 0, 1, 0 };
            map[1] = new int[] { 0, 0, 0, 0, 0, 0, 0, 1, 0, 1 };
            map[2] = new int[] { 0, 1, 0, 0, 0, 0, 1, 1, 1, 1 };
            map[3] = new int[] { 0, 1, 0, 0, 0, 0, 1, 1, 0, 1 };
            map[4] = new int[] { 0, 0, 0, 1, 1, 1, 0, 0, 0, 1 };
            map[5] = new int[] { 0, 0, 0, 1, 0, 1, 0, 0, 0, 1 };
            map[6] = new int[] { 0, 0, 0, 1, 0, 1, 0, 0, 1, 0 };
            map[7] = new int[] { 0, 0, 0, 1, 0, 1, 0, 0, 1, 0 };
            map[8] = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 1, 0 };
            map[9] = new int[] { 1, 1, 1, 1, 1, 1, 0, 0, 1, 0 };
            Islands islands = new Islands();
            int countIslands = islands.CountIslands(map);

            Assert.AreEqual(8, countIslands);
        }
        [Test]
        public void BarnBuildEnumTest()
        {
            int[][] map = new int[10][];
            map[0] = new int[] { 0, 1, 1, 0, 0, 1, 0, 0, 1, 0 };
            map[1] = new int[] { 0, 0, 0, 0, 0, 0, 0, 1, 0, 1 };
            map[2] = new int[] { 0, 1, 0, 0, 0, 0, 1, 1, 1, 1 };
            map[3] = new int[] { 0, 1, 0, 0, 0, 0, 1, 1, 0, 1 };
            map[4] = new int[] { 0, 0, 0, 1, 1, 1, 0, 0, 0, 1 };
            map[5] = new int[] { 0, 0, 0, 1, 0, 1, 0, 0, 0, 1 };
            map[6] = new int[] { 0, 0, 0, 1, 0, 1, 0, 0, 1, 0 };
            map[7] = new int[] { 0, 0, 0, 1, 0, 1, 0, 0, 1, 0 };
            map[8] = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 1, 0 };
            map[9] = new int[] { 1, 1, 1, 1, 1, 1, 0, 0, 1, 0 };

            BarnBuildSimple barnBuildSimple = new BarnBuildSimple();
            var size = barnBuildSimple.SimpleEnumeration(map);
            Assert.AreEqual(15, size);
        }
        [Test]
        public void BarnBuildByDynProgTest()
        {
            int[][] map = new int[10][];
            map[0] = new int[] { 0, 1, 1, 0, 0, 1, 0, 0, 1, 0 };
            map[1] = new int[] { 0, 0, 0, 0, 0, 0, 0, 1, 0, 1 };
            map[2] = new int[] { 0, 1, 0, 0, 0, 0, 1, 1, 1, 1 };
            map[3] = new int[] { 0, 1, 0, 0, 0, 0, 1, 1, 0, 1 };
            map[4] = new int[] { 0, 0, 0, 1, 1, 1, 0, 0, 0, 1 };
            map[5] = new int[] { 0, 0, 0, 1, 0, 1, 0, 0, 0, 1 };
            map[6] = new int[] { 0, 0, 0, 1, 0, 1, 0, 0, 1, 0 };
            map[7] = new int[] { 0, 0, 0, 1, 0, 1, 0, 0, 1, 0 };
            map[8] = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 1, 0 };
            map[9] = new int[] { 1, 1, 1, 1, 1, 1, 0, 0, 1, 0 };

            BurnBuildDynProgr burnBuildDynProgr = new BurnBuildDynProgr();
            var size = burnBuildDynProgr.Solve(map);
            Assert.AreEqual(15, size);
        }
    }
}