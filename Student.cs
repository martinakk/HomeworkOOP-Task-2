using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Student : Human
{
    public int Grade { get; set; }

    public Student(string firstName, string lastName, int grade) : base ()
    {
        this.FisrtName = firstName;
        this.LastName = lastName;
        this.Grade = grade;
    }
    
    public override string ToString()
    {
        StringBuilder studentInfo = new StringBuilder();
        studentInfo.Append(this.FisrtName.ToString()+" ");
        studentInfo.Append(this.LastName.ToString() + " ");
        studentInfo.Append(this.Grade.ToString());
        return studentInfo.ToString();
    }
}
