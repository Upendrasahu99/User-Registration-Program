using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistration;
using System;
using System.Collections.Generic;
using System.Text;

namespace UserRegistration.Tests
{
    [TestClass()]
    public class UserDetailTests
    {
        [TestMethod()]
        public void CheckFirstNameTest()
        {
            UserDetail userDetail = new UserDetail();
            Assert.IsTrue(userDetail.CheckFirstName("Ram"));
        }

        public  void CheckLastNameTest()
        {
            UserDetail userDetail = new UserDetail();
            bool actualValue = userDetail.CheckLastName("Gupta");
            Assert.IsTrue(actualValue);
        }
        public void CheckMobileNumber()
        {
            UserDetail userDetail = new UserDetail();
            bool actualValue = userDetail.CheckMobileNumber("9574981587");
            Assert.IsTrue(actualValue);
        }
        public void CheckPassword()
        {
            UserDetail userDetails = new UserDetail();
            bool actualValue = userDetails.CheckPassword("123utsadsnv");
            Assert.IsTrue(actualValue);
        }
        public void CheckEmail()
        {
            UserDetail userDetails = new UserDetail();
            bool actualValue = userDetails.CheckEmail("upe.ds.@gamil.com");
            Assert.IsTrue(actualValue);
        }
    }
}