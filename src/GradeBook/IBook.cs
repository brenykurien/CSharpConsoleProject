namespace GradeBook
{
    interface IBook
    {
        string Name { get; }
        void AddGrade(double g);
    }
}
