
using Core.Infrastructure.Services;
using Infrastracture;
using Infrastracture.Repository.Context;
using Infrastracture.Services;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Xunit;
using Core.Infrastructure.Services.Models;
using Core.Infrastructure.Repository.Entities;
using Microsoft.EntityFrameworkCore;

namespace XUnitTestProject
{
    public class DeptServiceTests
    {
        private readonly DeptService _service;
        private AppDbContext _context;
        private readonly Mock<Response> _responseMock = new Mock<Response>();
        
        // No Way to Mock the context because it has a lot of providers
        // so we made a newContext with same configuration but in memory
        DbContextOptions<AppDbContext>options = new DbContextOptionsBuilder<AppDbContext>()
            .UseInMemoryDatabase(databaseName: "TestRepo").Options;
        public DeptServiceTests()
        {
            _context = new AppDbContext(options);
            _context.DoSeedInMemory();
            _service = new DeptService(_context, _responseMock.Object);
        }
        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        public void GetById_ShouldReturnDept_IfExist(int id)
        {

            //Arrange

 
            //Fact
            var response = _service.GetById(id);

            //Assert
            Assert.True(response.status);
        }
        [Theory]
        [InlineData(5)]
        [InlineData(6)]
        [InlineData(7)]
        public void GetById_ShouldNotReturnDept_IfExist(int id)
        {
            //Fact
            var response = _service.GetById(id);

            //Assert
            Assert.False(response.status);
        }
    }
}
