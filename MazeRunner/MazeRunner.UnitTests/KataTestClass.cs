namespace MazeRunner.UnitTests;

[TestFixture]
class KataTestClass
{

    private readonly int[,] _maze = new int[,]
    {
        { 1, 1, 1, 1, 1, 1, 1 },
        { 1, 0, 0, 0, 0, 0, 3 },
        { 1, 0, 1, 0, 1, 0, 1 },
        { 0, 0, 1, 0, 0, 0, 1 },
        { 1, 0, 1, 0, 1, 0, 1 },
        { 1, 0, 0, 0, 0, 0, 1 },
        { 1, 2, 1, 0, 1, 0, 1 }
    };


     [TestCase, Order(1)]
        public void FinishTest1()
        {
            string[] directions = new string[] { "N", "N", "N", "N", "N", "E", "E", "E", "E", "E" };
            Kata test = new Kata();
            string result = test.MazeRunner(_maze, directions);
            Assert.That(result, Is.EqualTo("Finish"), "Should return: 'Finish'");
        }
        
        [TestCase, Order(2)]
        public void FinishTest2()
        {
            string[] directions = new string[] { "N","N","N","N","N","E","E","S","S","E","E","N","N","E" };
            Kata test = new Kata();
            string result = test.MazeRunner(_maze, directions);
            Assert.That(result, Is.EqualTo("Finish"), "Should return: 'Finish'");
        }
        
        [TestCase, Order(3)]
        public void FinishTest3()
        {
            string[] directions = new string[] { "N","N","N","N","N","E","E","E","E","E","W","W" };
            Kata test = new Kata();
            string result = test.MazeRunner(_maze, directions);
            Assert.That(result, Is.EqualTo("Finish"), "Should return: 'Finish'");
        }

        [TestCase, Order(6)]
        public void LostTest1()
        {
            string[] directions = new string[] { "N","E","E","E","E" };
            Kata test = new Kata();
            string result = test.MazeRunner(_maze, directions);
            Assert.That(result, Is.EqualTo("Lost"), "Should return: 'Lost'");
        }

        [TestCase, Order(4)]
        public void DeadTest1()
        {
            string[] directions = new string[] { "N","N","N","W","W" };
            Kata test = new Kata();
            string result = test.MazeRunner(_maze, directions);
            Assert.That(result, Is.EqualTo("Dead"), "Should return: 'Dead'");
        }

        [TestCase, Order(5)]
        public void DeadTest2()
        {
            string[] directions = new string[] { "N","N","N","N","N","E","E","S","S","S","S","S","S" };
            Kata test = new Kata();
            string result = test.MazeRunner(_maze, directions);
            Assert.That(result, Is.EqualTo("Dead"), "Should return: 'Dead'");
        }
}