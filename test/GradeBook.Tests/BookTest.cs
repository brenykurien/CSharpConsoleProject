using System;
using Xunit;

namespace GradeBook.Tests
{
    public class BookTest
    {
        [Fact]
        public void EmptyBookNameTest()
        {
            Book book = new Book();
            Assert.Equal("Default", book.Name);
        }

        [Fact]
        public void EmptyBookTest()
        {
            Book book = new Book();
            Assert.Equal(0, book.getHighestGrade());
            Assert.Equal(0, book.getLowestGrade());
            Assert.Equal(0, book.getAverageGrade());
        }

        [Fact]
        public void OneGradeTest()
        {
            double bookValue = 5.0;
            Book book = new Book();
            book.AddGrade(bookValue);
            Assert.Equal(bookValue, book.getHighestGrade());
            Assert.Equal(bookValue, book.getLowestGrade());
            Assert.Equal(bookValue, book.getAverageGrade());
        }

        [Fact]
        public void NormalGradeTest()
        {
            Book book = new Book();
            book.AddGrade(1.0);
            book.AddGrade(2.0);
            book.AddGrade(3.0);
            Assert.Equal(3.0, book.getHighestGrade());
            Assert.Equal(1.0, book.getLowestGrade());
            Assert.Equal(2.0, book.getAverageGrade());
        }

        [Fact]
        public void InvalidGradeTest()
        {
            Book book = new Book();
            Assert.Throws<ArgumentException>(() => book.AddGrade(-1.02));
            Assert.Throws<ArgumentException>(() => book.AddGrade(102));
        }

        [Fact]
        public void SameReferenceTest()
        {
            Book book1 = new Book();
            Book book2 = book1;
            Assert.Same(book1, book2);
        }

        [Fact]
        public void ChangingBookName()
        {
            Book book = new Book();
            SetBookName(book, "New Name");
            Assert.Equal("New Name", book.Name);
        }

        private void SetBookName(Book book, string name)
        {
            book.Name = name;
        }
    }
}
