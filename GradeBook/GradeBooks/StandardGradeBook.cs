using System;
using System.Collections.Generic;
using System.Text;

public class GradeBook.GradeBooks
{
	public StandardGradeBook : BaseGradeBook()
	{
	public StandardGradeBook(string name) : base(name)
		{
		Type = Enums.GradeBookType.Standard;
		}
	}
}
