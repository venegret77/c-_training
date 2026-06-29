class Student
{
    public string Name;
    public int Grade;
    public bool IsActive;

    public Student(string name, int grade, bool isactive)
    {
        Name = name;
        Grade = grade;
        IsActive = isactive;
    }
}

Student student = new Student ("Edvard", 177, true);
Console.WriteLine(student.Name);
Console.WriteLine(student.Grade);
Console.WriteLine(student.IsActive);