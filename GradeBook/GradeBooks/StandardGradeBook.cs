

using GradeBook.Enums;

namespace GradeBook.GradeBooks
{
    public class StandardGradeBook : BaseGradeBook //to inherit the BaseGradeBook class
    {
        //make a new constructor
        public StandardGradeBook(string name, bool isWeighted) : base(name,isWeighted)
        {
            Type = GradeBookType.Standard;
           
        }
    }
}
