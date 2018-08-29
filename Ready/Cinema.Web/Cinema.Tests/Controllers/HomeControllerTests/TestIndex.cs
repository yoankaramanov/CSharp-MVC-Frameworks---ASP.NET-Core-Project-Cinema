using Cinema.Web.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.Tests.Controllers.HomeControllerTests
{
    [TestClass]
    public class TestIndex
    {
        [TestMethod]
        public void Index_ReturnsTheProperView()
        {
            var controller = new HomeController();

            var result = controller.Index();

            Assert.IsInstanceOfType(result, typeof(RedirectToActionResult));
        }
    }
}
