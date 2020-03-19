using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SSO1;

namespace TestSSO
{
    [TestClass]
    public class TestInterfarces
    {
        [TestMethod]
        public void Factorielle_0()
        {
            double facto = MathHelper.Factorielle(0);
            Assert.AreEqual(1, facto);
        }

        //public void TestAddUserID(){ using (UserInterface interface = new UsersRepository()) {}}
    }
}
