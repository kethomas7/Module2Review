
using Module2Review;



var students = new List<Student>();

var student1 = new Student
{
    Name = "John",
    ID = 1,
    Grades = new List<double> { 85, 86, 90, 92, 100 }

};

var student2 = new Student
{
    Name = "Lauren",
    ID = 2,
    Grades = new List<double> { 85, 65, 60, 72, 80 }

};

var student3 = new Student
{
    Name = "Zack",
    ID = 3,
    Grades = new List<double> { 95, 96, 90, 92, 100 }

};

var student4 = new Student
{
    Name = "Dan",
    ID = 4,
    Grades = new List<double> { 75, 86, 70, 72, 80 }

};

students.Add(student1);
students.Add(student2);
students.Add(student3);
students.Add(student4);

student1.AddGrade(85);
student1.AddGrade(75, 78, 98);

student2.AddGrade(55);
student2.AddGrade(69, 88, 78);

student3.AddGrade(65);
student3.AddGrade(85, 80, 85);

student4.AddGrade(95);
student4.AddGrade(100, 95, 90);


foreach (var person in students)
{
    Console.WriteLine($"Name:{person.Name}\n ID:{person.ID}\n Grades:{person.Grades} Average:{person.CalculateAverageGrade}");

    
}