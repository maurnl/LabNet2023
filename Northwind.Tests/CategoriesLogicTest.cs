using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Northwind.Data;
using Northwind.Data.Abstractions;
using Northwind.Entities;
using Northwind.Logic;
using System;
using System.Data.Entity;

namespace Northwind.Tests
{
    [TestClass]
    public class CategoriesLogicTest
    {
        [TestMethod]
        public void Add_ConCategoriaValida_InvocaAddDelRepoYSaveChangesDelContext()
        {
            // Arrange
            var mockSet = new Mock<DbSet<Categories>>();
            var mockContext = new Mock<NorthwindContext>();
            var mockRepo = new Mock<GenericRepository<Categories>>(mockContext.Object);

            mockContext.Setup(m => m.Set<Categories>()).Returns(mockSet.Object);

            // Act
            var logic = new CategoriesLogic(mockRepo.Object);

            logic.Add(new Categories
            {
                CategoryID = 1,
                CategoryName = "Nueva categoria",
                Description = "La nueva categoria"
            });

            // Assert
            mockSet.Verify(m => m.Add(It.IsAny<Categories>()), Times.Once());
            mockContext.Verify(m => m.SaveChanges(), Times.Once());
        }
    }
}
