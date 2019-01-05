using GradeBook.Enums;

namespace GradeBook.GradeBooks
{
    publec class StandardGradeBook : BaseGradeBook
    {
        public StandardGradeBook(string name) : base(name)
        {
            Type = GradeBookType.Standard;
        }
    }
}
