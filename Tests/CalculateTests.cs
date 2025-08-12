using UsingHusky.NET.Classes;

namespace Tests
{
   [TestClass]
   public sealed class CalculateTests
   {
      [TestMethod]
      public void SummingTest()
      {
         int number = new Sum([5, 5, 5]).Result;
         Assert.AreEqual(17, number);
      }
      [TestMethod]
      public void SubtractingTest()
      {
         int number = new Subtract([5, 5, 5]).Result;
         Assert.AreEqual(-15, number);
      }
   }
}
