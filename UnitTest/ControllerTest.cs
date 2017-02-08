using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using AdoptAPet;
using AdoptAPet.Controllers;


namespace UnitTest
{
    [TestClass]
    public class ControllerTest
    {
        [TestMethod]
        public void Index()
        {
            //Arrange
            HomeController controller = new HomeController();

            //Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void About()
        {
            //Arrange
            HomeController controller = new HomeController();

            //Act
            ViewResult result = controller.About() as ViewResult;

            // Assert
            Assert.AreEqual("Your application description page.", result.ViewBag.message);
        }
        [TestMethod]
        public void Contacts()
        {
            //Arrange
            HomeController controller = new HomeController();

            //Act
            ViewResult result = controller.Contact() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void Community()
        {
            //Arrange
            HomeController controller = new HomeController();

            //Act
            ViewResult result = controller.Community() as ViewResult;

            // Assert
            Assert.AreEqual("Your Community page.", result.ViewBag.message);
        }
      
       
    }
}
