using Microsoft.VisualStudio.TestTools.UnitTesting;
using RepositoryPatterns;
using System;
using System.Collections.Generic;

namespace StreamingContentRepositoryTest
{
    [TestClass]
    public class RepositoryTest
    {
        //Test The Add Method 
        [TestMethod]
        public void AddToDirectory_ShouldGetCorrectBoolean()
        {
            //Arrange
            StreamingContent content = new StreamingContent();
            StreamingContentRepository repository = new StreamingContentRepository();

            //Act 
            bool addResult = repository.AddContentToDirectory(content);

            //Assert
            Assert.IsTrue(addResult);

            Console.WriteLine(addResult);


        }

        [TestMethod]
        public void GetDirectory_ShouldReturnCorrectCollection()

        {
            //Arrange
            //Creating Content
            StreamingContent content = new StreamingContent();
            //Creating Repo
            StreamingContentRepository repo = new StreamingContentRepository();
            //Adding to the Repo
            repo.AddContentToDirectory(content);

            //Act

            List<StreamingContent> contents = repo.GetContent();

            bool directoryHasContent = contents.Contains(content);

            //Assert 
            Assert.IsTrue(directoryHasContent);
            Console.WriteLine(directoryHasContent);

        }

        private StreamingContentRepository _repo;
        private StreamingContent _content;

        [TestInitialize]
        public void Arrange()
        {
            _repo = new StreamingContentRepositoy();
            //we make a now movie here 
            _content = new StreamingContent("Rubber","A description",
                MaturityRating.R, GenreType.Horror,5.8d);

            //now the movie is in our database 
            _repo.AddContentToDirectory(_content);


        }
        //retrieve content by title
        [TestMethod]
        public void GetByTitle_ShouldReturnCorrectContent()
        {
            //Arrange already done above 

            //Act
            StreamingContent searchResult = _repo.GetContentByTitle("Rubber");

            //Assert 
            Assert.AreEqual(_content, searchResult);
        }
        //Test the Update Method
        [TestMethod]
        public void UpdateExistingContent_ShouldReturnTrue()
        {
            //Arrange > Updated version of our movie 
            StreamingContent newContent = new StreamingContent("Rubber 2", "A description",
                MaturityRating.R, GenreType.Horror, 9.8d);
            //act 
            bool updateResult = _repo.UpdateExistingContent("Rubber", newContent);

            //assert 
            Assert.IsTrue(updateResult);
        }

        //test the delete method 
        [TestMethod]
        public void DeleteExistingContent_ShouldReturnTrue()
        {
            //Arange 
            StreamingContent content = _repo.GetContentByTitle("Rubber");

            //Act 
            bool removeResult = _repo.DeleteExistingContent(content);

            //Assert 
            Assert.IsTrue(removeResult);


        }
       

    }
}
