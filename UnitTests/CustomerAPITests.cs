﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using IDataInterface;
using Library;

namespace UnitTests
{
    [TestClass]
    public class CustomerAPITests
    {
        [TestMethod]
        public void TestAddCustomer()
        {
            Mock<ICustomerManager> customerManagerMock = SetupMockCustomer(null);
            bool successfull = AddCustomerNumberOne(customerManagerMock);
            Assert.IsTrue(successfull);
            customerManagerMock.Verify(m =>
                m.AddCustomer(It.Is<int>(i => i == 1)),
                Times.Once());
        }

        private static bool AddCustomerNumberOne(Mock<ICustomerManager> customerManagerMock)
        {
            var customerAPI = new CustomerAPI(customerManagerMock.Object);
            var successfull = customerAPI.AddCustomer(1);
            return successfull;
        }
        private static Mock<ICustomerManager> SetupMockCustomer(Customer customer)
        {
            var customerManagerMock = new Mock<ICustomerManager>();

            customerManagerMock.Setup(m =>
                    m.GetCustomerByCustomerNumber(It.IsAny<int>()))
                .Returns(customer);

            customerManagerMock.Setup(m =>
                m.AddCustomer(It.IsAny<int>()));
            return customerManagerMock;
        }
    }
}