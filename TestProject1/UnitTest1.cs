using TaiwainStock.Utility;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase ("2022/10/29")]
        [TestCase ("2022/10/30")]
        public void IsTradingTimeTest_星期六日傳回false(string dt)
        {
            DateTime today = Convert.ToDateTime(dt);
            bool actual = new TaiwainStockUtility().IsTradingTime(today);

            //var obj = new TaiwainStockUtility();
           Assert.IsFalse(actual);
        }
        [TestCase("2022/10/29 8:59:59")]
        [TestCase("2022/10/30 13:30:01")]
        public void IsTradingTimeTest_非營業時間傳回false(string dt)
        {
            DateTime today = Convert.ToDateTime(dt);
            bool actual = new TaiwainStockUtility().IsTradingTime(today);

            //var obj = new TaiwainStockUtility();
            Assert.IsFalse(actual);
        }
        [TestCase("2022/11/1 10:30:00")]
        public void IsTradingTimeTest_星期一到五傳回True(string dt)
        {
            DateTime today = Convert.ToDateTime(dt);
            bool actual = new TaiwainStockUtility().IsTradingTime(today);

            //var obj = new TaiwainStockUtility();
            Assert.IsTrue(actual);
        }
    }
}