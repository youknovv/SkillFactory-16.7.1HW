using System.Collections.Generic;
using Module16;
using Moq;
using Xunit;

namespace Modul16.Test.xUnit
{
    public class BookRepositoryTests
    {
        [Fact]
        public void FindAll_Basic()
        {
            var books = new List<Book>()
            {
                new Book
                {
                    Title = "Война и мир"
                },
                new Book
                {
                    Title = "Человек-невидимка"
                },
                new Book
                {
                    Title = "Анна Каренина"
                }
            };

            var mockBook = new Mock<IBookRepository>();

            mockBook.Setup(s => s.FindAll()).Returns(books);
            Assert.Contains(books, x => x.Title == "Война и мир");
            Assert.Contains(books, x => x.Title == "Человек-невидимка");
            Assert.Contains(books, x => x.Title == "Анна Каренина");
        }
    }
}