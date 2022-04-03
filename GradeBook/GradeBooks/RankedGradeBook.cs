using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name, bool isWeighted) : base(name, isWeighted)
        {
            Type = Enums.GradeBookType.Ranked;
        }

        public override char GetLetterGrade(double averageGrade)
        {
            if (StudentCount() < 5)
            {
                throw new InvalidOperationException("Not enough students");
            }
            else
            {
                if (averageGrade >= 80)
                    return 'A';
                else if (averageGrade >= 60)
                    return 'B';
                else if (averageGrade >= 40)
                    return 'C';
                else if (averageGrade >= 20)
                    return 'D';
                else
                    return 'F';
            }
        }

        public override void CalculateStatistics()
        {
            if (StudentCount() < 5)
                Console.WriteLine("Ranked grading requires at least 5 students.");
            else if (StudentCount() >= 5)
                base.CalculateStatistics();
        }

        public override void CalculateStudentStatistics(string name)
        {
            if (StudentCount() < 5)
                Console.WriteLine("Ranked grading requires at least 5 students.");
            else if (StudentCount() >= 5)
                base.CalculateStudentStatistics(name);
        }
    }
}
