﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Threading.Tasks;
namespace FlatMoniApiTest.Services
{
    [TestClass]
    public class UserServiceTest
    {
        [TestMethod]
        public async Task Test()
        {

            var measureRepositoryMock = new Mock<IMeasureRepository>();

            true.Equals(true);
        }

    }
}
