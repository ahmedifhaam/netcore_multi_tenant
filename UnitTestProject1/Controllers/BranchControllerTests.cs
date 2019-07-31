using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Test1.Controllers;
using UnitTestProject1.Fakes;

namespace UnitTestProject1.Controllers
{
    [TestClass]
    public class BranchControllerTests

    {
        [TestMethod]
        public void BranchController_Get()
        {
            var ctrl = new BranchController(new SystemRepository(),new BranchRepository());
            Assert.IsTrue(false);
        }
    }
}
