using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class TestHuman
{

    public static void OrderStudents(List<Student> aClass)
    {
        var orderedByGrade =                                    //Ordering student by grade
            from student in aClass
            orderby student.Grade
            select student;
        foreach (var student in orderedByGrade)
        {
            Console.WriteLine(student.ToString());
        }
    }

    public static void OrderWorkers(List<Worker> workers)
    {

        var orderedWorkers =                                        //Ordering workers by money they earn per hour
            from worker in workers
            orderby worker.MoneyPerHour.ToString() descending
            select worker;
        foreach (var worker in orderedWorkers)
        {
            Console.WriteLine(worker.ToString());
        }
    }

    public static void MergeLists(List<Human> people, List<Student> aClass, List<Worker> workers)
    {
        foreach (var student in aClass)                             //Merge workers and students
        {
            people.Add(student);
        }
        foreach (var worker in workers)
        {
            people.Add(worker);
        }
    }

    public static void OrderPeople(List<Human> people)
    {
        var orderHumans =                                       //Ordering humans by their names
            from human in people
            orderby human.FisrtName ascending, human.LastName ascending
            select human;
        foreach (var human in orderHumans)
        {
            Console.WriteLine(human.ToString());
        }
    }

    static void Main()
    {
        List<Student> aClass = new List<Student>();             //List of students
        aClass.Add(new Student("Pesho", "Petrov", 6));
        aClass.Add(new Student("Poli", "Atanasova", 3));
        aClass.Add(new Student("Pavel", "Dimitrov", 4));
        aClass.Add(new Student("Mirela", "Simeonova", 5));
        aClass.Add(new Student("Mario", "Stoqnov", 5));
        aClass.Add(new Student("Desislava", "Andonova", 6));
        aClass.Add(new Student("Aleksandra", "Filipova", 4));
        aClass.Add(new Student("Stanislava", "Hristova", 3));
        aClass.Add(new Student("Gosho", "Iordanov", 2));
        aClass.Add(new Student("Stamat", "Georgiev", 6));

        List<Worker> workers = new List<Worker>();                  //List of the workers
        workers.Add(new Worker("Ivan", "Ivanov", 250, 8));
        workers.Add(new Worker("Zahari", "Dobrev", 300, 8));
        workers.Add(new Worker("Ioana", "Dimova", 200, 6));
        workers.Add(new Worker("Darina", "Popova", 150, 4));
        workers.Add(new Worker("Shushi", "Shalala", 200, 8));
        workers.Add(new Worker("Desislava", "Andreeva", 350, 8));
        workers.Add(new Worker("Marina", "Simova", 300, 6));
        workers.Add(new Worker("Dilaila", "Tequila", 280, 6));
        workers.Add(new Worker("Rum", "Morgan", 190, 4));
        workers.Add(new Worker("Delirium", "Nirvana", 100, 4));

        Console.WriteLine("Ordered Stydents");
        OrderStudents(aClass);
        Console.WriteLine();
        Console.WriteLine("Ordered Workers");
        OrderWorkers(workers);
        Console.WriteLine();
        List<Human> people = new List<Human>();
        Console.WriteLine("Merge Humans");
        MergeLists(people, aClass, workers);
        Console.WriteLine();
        Console.WriteLine("Order People");
        OrderPeople(people);
    }
}
