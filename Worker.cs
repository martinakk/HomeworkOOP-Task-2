using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Worker : Human
{
    public int WeekSalary { get; set; }
    public int WorkHoursPerDay { get; set; }
    public double MoneyPerHour { get; set; }

    public Worker(string firstName, string lastName, int WeekSalary, int WorkHoursPerDay)
        : base()
    {
        this.FisrtName = firstName;
        this.LastName = lastName;
        this.WeekSalary = WeekSalary;
        this.WorkHoursPerDay = WorkHoursPerDay;
        this.MoneyPerHour = MoneyEarnedPerHour();
    }

    public double MoneyEarnedPerHour()
    {
        double MoneyPerDay = WeekSalary / 5;                       //divide week salary by 5 work days
        MoneyPerHour = MoneyPerDay / WorkHoursPerDay;      // divide money for one day by the work hours
        return this.MoneyPerHour;
    }

    public override string ToString()
    {
        StringBuilder workerInfo = new StringBuilder();
        workerInfo.Append(this.FisrtName.ToString()+ " ");
        workerInfo.Append(this.LastName.ToString() + ": ");
        workerInfo.Append(this.WeekSalary.ToString() + "/week; ");
        workerInfo.Append(this.WorkHoursPerDay.ToString() + " work hours per day; ");
        workerInfo.Append(this.MoneyPerHour.ToString() + " money per hour");
        return workerInfo.ToString();
    }

}
