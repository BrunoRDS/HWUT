using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.Json.Serialization;
using HWUT.Models;
using System;
using Newtonsoft.Json;
using System.Text.Json;

namespace UnitTests
{
    [TestClass]
    public class ProductModelTests
    {
        [TestMethod]
        public void ProductModel_Constructor_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ProductModel_Get_Date_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.AreEqual(DateTime.UtcNow.ToShortDateString(), result.Date.ToShortDateString());
        }

        [TestMethod]
        public void ProductModel_ID_Set_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();
            string test = "Test_id";

            // Act
            result.Id = "Test_id";

            // Assert
            Assert.AreEqual(result.Id, test);

        }
        
        [TestMethod]
        public void ProductModel_Maker_Set_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();
            string test = "Test_Maker";

            // Act
            result.Maker = "Test_Maker";

            // Assert
            Assert.AreEqual(result.Maker, test);

        }

        [TestMethod]
        public void ProductModel_Image_Set_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();
            string test = "Test_Image";

            // Act
            result.Image = "Test_Image";

            // Assert
            Assert.AreEqual(result.Image, test);

        }

        [TestMethod]
        public void ProductModel_Url_Set_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();
            string test = "Test.Url.Com";

            // Act
            result.Url = "Test.Url.Com";

            // Assert
            Assert.AreEqual(result.Url, test);

        }

        [TestMethod]
        public void ProductModel_Title_Set_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();
            string test = "Test_Title";

            // Act
            result.Title = "Test_Title";

            // Assert
            Assert.AreEqual(result.Title, test);

        }

        [TestMethod]
        public void ProductModel_Description_Set_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();
            string test = "Test_Desc";

            // Act
            result.Description = "Test_Desc";

            // Assert
            Assert.AreEqual(result.Description, test);

        }


        [TestMethod]
        public void ProductModel_Email_Set_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();
            string test = "Test_Email@email.com";

            // Act
            result.Email = "Test_Email@email.com";

            // Assert
            Assert.AreEqual(result.Email, test);

        }

        [TestMethod]
        public void ProductModel_Sequence_Set_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();
            string test = "Test_Sequence";

            // Act
            result.Sequence = "Test_Sequence";

            // Assert
            Assert.AreEqual(result.Sequence, test);

        }

        [TestMethod]
        public void ProductModel_toString_Override__Executes_JsonSerializer_Should_Pass()
        {
            // Arrange
            ProductModel result = new ProductModel();

            // Act
            string fromJson = System.Text.Json.JsonSerializer.Serialize<ProductModel>(result);

            string fromToString = result.ToString();

            // Assert
            Assert.IsTrue(System.Text.Json.JsonSerializer.Equals(result, result));

            Assert.AreEqual(fromJson, fromToString);

        }

        [TestMethod]
        public void ProductModel_AverageRating_Null_Catch_Should_Pass()
        {
            //Arrange 
            ProductModel result = new ProductModel();

            // Act
            result.Ratings = null;

            int test = result.AverageRating();

            //Assert
            Assert.AreEqual(test, 0);
        }

        [TestMethod]
        public void ProductModel_AverageRating_Count_Zeros_Should_Pass()
        {
            //Arrange 
            ProductModel result = new ProductModel();
            int[] test_array = new int[] { 0, 0, 0, 0, 0 };

            // Act
            result.Ratings = test_array;

            int test = result.AverageRating();

            //Assert
            Assert.AreEqual(test, 0);
        }

        [TestMethod]
        public void ProductModel_AverageRating_Empty_Array_Should_Pass()
        {
            //Arrange 
            ProductModel result = new ProductModel();
            int[] test_array = new int[] {};

            // Act
            result.Ratings = test_array;

            int test = result.AverageRating();

            //Assert
            Assert.AreEqual(test, 0);
        }

        [TestMethod]
        public void ProductModel_AverageRating_Calculate_Average_Should_Pass()
        {
            //Arrange 
            ProductModel result = new ProductModel();
            int[] test_array = new int[] { 1, 2, 3, 4, 5};

            // Act
            result.Ratings = test_array;

            int test = result.AverageRating();

            //Assert
            Assert.AreEqual(test, 3);
        }
    }
}
