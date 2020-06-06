using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            book.getHighestGrade();
            book.getLowestGrade();

            try
            {
                book.AddGrade(85.6);
                book.AddGrade(21);
                book.AddGrade(-1);
                book.AddGrade(109);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Avg Grade : " + book.getAverageGrade());
                Console.WriteLine("Highest Grade : " + book.getHighestGrade());
                Console.WriteLine("Lowest Grade : " + book.getLowestGrade());
            }
        }
    }
}
