using Microsoft.VisualStudio.TestTools.UnitTesting;
using DevOps_iConfigurator.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Moq;

namespace DevOps_iConfigurator.Controllers.Tests
{
    [TestClass()]
    public class QuestionsControllerTests
    {
        [TestMethod()]
        public void QuestionsTest1()
        {           
            var controller = new QuestionsController();
            var context = new Mock<ControllerContext>();
            var session = new Mock<HttpSessionStateBase>();
            context.Setup(m => m.HttpContext.Session).Returns(session.Object);
            controller.ControllerContext = context.Object;
         
            var result = controller.Index(null,0) as ViewResult;
            Assert.IsNotNull(result.ViewName);
        }
    }
}