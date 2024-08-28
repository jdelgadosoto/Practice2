
using System.Runtime.InteropServices.Marshalling;

public class Student
{
    private string _name;
    private string _rollNumber;
    private int _semester;
    private List<int> Grades = new List<int>();

    public Student(string name, string rollNumber, int semester)
    {
        _name = name;
        _rollNumber = rollNumber;
        _semester = semester;
    }

    public string Details() => $"Student name: {_name} \nRoll number: {_rollNumber} \nSemester: {_semester}";


    public string AddGrade(int grade)
    {
        
        Grades.Add(grade);
        return $"The grade you added is { grade}";

    }

    public int CalculateGrade()
    {
        var sum = 0;
        foreach (var grade in Grades) { sum += grade; }
        int average = sum / Grades.Count;
        return average;
    }

}

public class Classroom
{
    private List<Student> ListOfStudents = new List<Student>();

    public List<Student> AddStudent(Student student)   
    {
        ListOfStudents.Add(student);
        return ListOfStudents;
    }

    public List<Student> RemoveStudent(Student student)
    {
        ListOfStudents.Remove(student);
        return ListOfStudents;
    }

    public void ShowList()
    {
        foreach (Student student in ListOfStudents)
        {
            Console.WriteLine(student);
        }

    }


}