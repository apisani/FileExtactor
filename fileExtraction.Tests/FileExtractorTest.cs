using System;
using System.IO;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using XML_Extractor;

namespace fileExtraction.Tests
{
    [TestClass]
    public class FileExtractorTest
    {
        [TestMethod]
        [ExpectedException(typeof(System.Exception),"Invalid file path.")]
        public void Load_InvalidJsonFilePath_ExpectExceptionThrown()
        {
            //Arrange
            //Invalid path set
            JsonExtractor.JsonExtractor jsonExtractor = new JsonExtractor.JsonExtractor();
            var jsonFilePath = (@"TestData\invalid_test_path.json");

            //Act
            var testList = jsonExtractor.LoadJson(jsonFilePath);

            //Assert above method - Expected exception is set
        }

        [TestMethod]
        [ExpectedException(typeof(System.Exception), "Invalid file path.")]
        public void Load_InvalidXMLFilePath_ExpectExceptionThrown()
        {
            //Arrange
            //Invalid path set
            XmlExtractor xmlExtractor = new XmlExtractor();
            var xmlFilePath = (@"TestData\invalid_test_path.xml");

            //Act
            var testList = xmlExtractor.LoadXml(xmlFilePath);

            //Assert above method - Expected exception is set
        }


        [TestMethod]
        [ExpectedException(typeof(System.Exception), "Invalid JSON path.")]
        public void Load_InvalidJsonFile_ExpectExceptionThrown()
        {
            //Arrange
            //Incorect path set
            JsonExtractor.JsonExtractor jsonExtractor = new JsonExtractor.JsonExtractor();
            var jsonFilePath =  (@"TestData\InvalidJSON.json");

            //Act
            var testList = jsonExtractor.LoadJson(jsonFilePath);

            //Assert above method - Expected exception is set
        }

        [TestMethod]
        [ExpectedException(typeof(System.Exception), "Invalid XML file.")]
        public void Load_InvalidXMLFile_ExpectExceptionThrown()
        {
            //Arrange
            //Invalid path set
            XmlExtractor xmlExtractor = new XmlExtractor();
            var xmlFilePath = (@"TestData\InvalidXML.xml");

            //Act
            var testList = xmlExtractor.LoadXml(xmlFilePath);

            //Assert above method - Expected exception is set
        }

        [TestMethod]
        public void Load_JSONFile_Expect_TwoItemInList()
        {
            //Arrange
            JsonExtractor.JsonExtractor jsonExtractor = new JsonExtractor.JsonExtractor();
            var jsonFilePath =  (@"TestData\ValidJSON.json");

            //Act
            var testList = jsonExtractor.LoadJson(jsonFilePath);

            //Assert
            Assert.AreEqual(testList.Count, 2);
        }

        [TestMethod]
        public void Load_XMLFile_Expect_TwoItemInList()
        {
            //Arrange
            XmlExtractor xmlExtractor = new XmlExtractor();
            var xmlFilePath = (@"TestData\ValidXML.xml");

            //Act
            var testList = xmlExtractor.LoadXml(xmlFilePath);

            //Assert
            Assert.AreEqual(testList.Count, 2);
        }

        [TestMethod]
        //This test has for only purpose to check if the the list has been populater correctly from the file
        public void Load_XMLFile_Expect_CorrectHorsesNames()
        {
            //Arrange
            XmlExtractor xmlExtractor = new XmlExtractor();
            var xmlFilePath = (@"TestData\ValidXML.xml");

            //Act
            var testList = xmlExtractor.LoadXml(xmlFilePath);

            //Assert
            Assert.AreEqual(testList[0].Name, "Advancing");
            Assert.AreEqual(testList[1].Name, "Coronel");
        }

        [TestMethod]
        //This test has for only purpose to check if the the list has been populater correctly from the file
        public void Load_JSONFile_Expect_CorrectHorsesNames()
        {
            //Arrange
            JsonExtractor.JsonExtractor jsonExtractor = new JsonExtractor.JsonExtractor();
            var jsonFilePath = (@"TestData\ValidJSON.json");

            //Act
            var testList = jsonExtractor.LoadJson(jsonFilePath);

            //Assert
            
            Assert.AreEqual(testList[0].Name, "Toolatetodelegate");
            Assert.AreEqual(testList[1].Name, "Fikhaar");
        }
    }
}
