using Cinema.Web.Areas.Admin.Controllers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cinema.Tests.Admin
{
    [TestClass]
    public class AccessTests
    {
        [TestMethod]
        public void UsersController_ShouldBeAccessedByAdmins()
        {
            var authorization = typeof(UsersController)
                        .GetCustomAttributes(true)
                        .FirstOrDefault(attr => attr is AuthorizeAttribute) as AuthorizeAttribute;

            var roles = authorization.Roles.Split(",");
            var adminRole = roles[0];
            Assert.IsNotNull(adminRole);
            Assert.AreEqual("Administrator", adminRole);
        }

        [TestMethod]
        public void UsersController_ShouldBeInAdminArea()
        {
            var area = typeof(UsersController)
                        .GetCustomAttributes(true)
                        .FirstOrDefault(attr => attr is AreaAttribute) as AreaAttribute;


            Assert.IsNotNull(area);
            Assert.AreEqual("Admin", area.RouteValue);
        }


       
    }
}
