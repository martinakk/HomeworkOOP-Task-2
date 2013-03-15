using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Human
{
    public string FisrtName{get; set;}
    public string LastName{get; set;}

    public override string ToString()
    {
        StringBuilder names = new StringBuilder();
        names.Append("Name: ");
        names.Append(this.FisrtName+ " ");
        names.Append(this.LastName + " ");
        return names.ToString();
    }
}
