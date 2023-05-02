using Microsoft.AspNetCore.Mvc;
using Moq;
using WebApp.Controllers;
using WebApp.Infrastructure;
using WebApp.Models;
using System.Collections.Generic;
using System.Linq;
using Xunit;
 
namespace WebAppTest
{
    public class AdmissionControllerTest
    {
        [Fact]
        public void Test_GET_AllAdmissions()
        {
            // Arrange
            var mockRepo = new Mock<IRepository>();
            mockRepo.Setup(repo => repo.Admissions).Returns(Multiple());
            var controller = new AdmissionController(mockRepo.Object);
 
            // Act
            var result = controller.Get();
 
            // Assert
            var model = Assert.IsAssignableFrom<IEnumerable<Admission>>(result);
            Assert.Equal(3, model.Count());
        }
 
        private static IEnumerable<Admission> Multiple()
        {
            var r = new List<Admission>();
            r.Add(new Admission()
            {
                instituteId = 01,
                instituteName = "Panuser",
                instituteDescription = "ABC",
                instituteAddress = "XYZ",
                mobile = "9876543210",
                email = "abc@gmail.com",
            });
            r.Add(new Admission()
            {
                instituteId = 02,
                instituteName = "Panuser",
                instituteDescription = "ABC",
                instituteAddress = "XYZ",
                mobile = "9876543210",
                email = "abc@gmail.com",
            });
            r.Add(new Admission()
            {
                instituteId = 03,
                instituteName = "Panuser",
                instituteDescription = "ABC",
                instituteAddress = "XYZ",
                mobile = "9876543210",
                email = "abc@gmail.com",
            });
            return r;
        }

        [Fact]
        public void Test_POST_AddAdmission()
        {
            // Arrange
            Admission r = new Admission()
            {
                instituteId = 04,
                instituteName = "Panuser",
                instituteDescription = "ABC",
                instituteAddress = "XYZ",
                mobile = "9876543210",
                email = "abc@gmail.com",
            };
            var mockRepo = new Mock<IRepository>();
            mockRepo.Setup(repo => repo.AddAdmission(It.IsAny<Admission>())).Returns(r);
            var controller = new AdmissionController(mockRepo.Object);
        
            // Act
            var result = controller.Post(r);
        
            // Assert
            var admission = Assert.IsType<Admission>(result);
            Assert.Equal(04, admission.instituteId);
            Assert.Equal("Panuser", admission.instituteName);
            Assert.Equal("ABC", admission.instituteDescription);
            Assert.Equal("XYZ", admission.instituteAddress);
            Assert.Equal("9876543210", admission.mobile);
            Assert.Equal("abc@gmail.com", admission.email);

        }

        [Fact]
        public void Test_PUT_UpdateAdmission()
        {
            // Arrange
            Admission r = new Admission()
            {
                instituteId = 01,
                instituteName = "PSG institute",
                instituteDescription = "ABC",
                instituteAddress = "XYZ",
                mobile = "9876543210",
                email = "abc@gmail.com",
            };
            var mockRepo = new Mock<IRepository>();
            mockRepo.Setup(repo => repo.UpdateAdmission(It.IsAny<Admission>())).Returns(r);
            var controller = new AdmissionController(mockRepo.Object);
        
            // Act
            var result = controller.Put(r);
        
            // Assert
            var admission = Assert.IsType<Admission>(result);
            Assert.Equal(01, admission.instituteId);
            Assert.Equal("PSG institute", admission.instituteName);
            Assert.Equal("ABC", admission.instituteDescription);
            Assert.Equal("XYZ", admission.instituteAddress);
            Assert.Equal("9876543210", admission.mobile);
            Assert.Equal("abc@gmail.com", admission.email);
        }

        [Fact]
        public void Test_DELETE_Admission()
        {
            // Arrange
            var mockRepo = new Mock<IRepository>();
            mockRepo.Setup(repo => repo.DeleteAdmission(It.IsAny<int>())).Verifiable();
            var controller = new AdmissionController(mockRepo.Object);
        
            // Act
            controller.Delete(3);

        
            // Assert
            mockRepo.Verify();
        }
    }
}