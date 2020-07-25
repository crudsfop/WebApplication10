using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;
using WebApplication10.Controllers;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            ILogger<HomeController> logger=null;
            //var hc = Moq<HttpContext>;
            var controller = new HomeController(logger);
            controller.ControllerContext = new ControllerContext();
            controller.ControllerContext.HttpContext = new DefaultHttpContext();
            var result = controller.Index()/* .Details(2)*/ as ViewResult;
            Thread.Sleep(0);
            //Assert.AreEqual("Details", result.ViewName);

        }
    }
}
