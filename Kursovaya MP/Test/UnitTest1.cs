using NUnit.Framework;

namespace Test
{
    public class Tests
    {

        [Test]
        public void StoimostNeprodKnig()
        {
            //arrange
            int[] cost = { 150, 200, 80, 20, 300 };
            int expected = 750;

            //act
            int actual=0;
            for (int i = 0; i < cost.Length; i++)
            {
                actual += cost[i];
            }

            //assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void ColichestvoProdanKnig()
        {
            //arrange
            int[] colich = { 17, 13, 5, 10, 15, 20 };
            int expected = 80;

            //act
            int actual = 0;
            for (int i = 0; i < colich.Length; i++)
            {
                actual += colich[i];
            }

            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void SrednyaCost()
        {
            //arrange
            int[] cost = { 250, 200, 100, 80, 400, 50, 150, 70 };
            double expected = 162.5;

            //act
            double actual = 0;
            for (int i = 0; i < cost.Length; i++)
            {
                actual += cost[i];
            }
            actual = actual / cost.Length;

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}