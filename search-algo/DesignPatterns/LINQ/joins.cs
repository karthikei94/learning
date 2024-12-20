using System.Linq;
namespace search_algo.DesignPatterns.LINQ;

class JoinOperations
{
    public static void Execute()
    {
        var students = new List<Student>();
        var departments = new List<Department>();
        var teachers = new List<Teacher>();


        var first = from student in students
                    join department in departments on student.DepartmentID equals department.ID
                    select new { Name = $"{student.FirstName} {student.LastName}", DepartmentName = department.Name };

        // var firstEquaivalent = students.Join(departments =>
        //                         student => student.DepartmentID,
        //                         department => department.ID,
        //                         (student, department) => new
        //                         {
        //                             Name = $"{student.FirstName} {student.LastName}",
        //                             DepartmentName = department.Name
        //                         });
        object studentGroup = null;
        var firstEquaivalentGroup = departments.GroupJoin(students,
        department => department.ID, student => student.DepartmentID,
        (department, student) => studentGroup);

        // inner join
        var query = from department in departments
                    join teacher in teachers on department.TeacherID equals teacher.ID
                    select new
                    {
                        DepartmentName = department.Name,
                        TeacherName = $"{teacher.First} {teacher.Last}"
                    };

        // composite key

        IEnumerable<string> query1 =
            from teacher in teachers
            join student in students
            on new
            {
                FirstName = teacher.First,
                LastName = teacher.Last
            } equals new
            {
                student.FirstName,
                student.LastName
            }
            select teacher.First + " " + teacher.Last;

        // equivalent
        IEnumerable<string> query3 =
            teachers
                .Join(students,
                    teacher => new { FirstName = teacher.First, LastName = teacher.Last },
                    student => new { student.FirstName, student.LastName },
                    (teacher, student) => $"{teacher.First} {teacher.Last}");

        // multiple joins lamda format
        var query4 = students
            .Join(departments, student => student.DepartmentID, department => department.ID,
            (student, department) => new { student, department })
            .Join(teachers, commonDepartment => commonDepartment.department.TeacherID, teacher => teacher.ID,
            (commonDepartment, teacher) => new
            {
                StudentName = $"{commonDepartment.student.FirstName} {commonDepartment.student.LastName}",
                DepartmentName = commonDepartment.department.Name,
                TeacherName = $"{teacher.First} {teacher.Last}"
            });
    }

}

public enum GradeLevel
{
    FirstYear = 1,
    SecondYear,
    ThirdYear,
    FourthYear
};

public class Student
{
    public required string FirstName { get; init; }
    public required string LastName { get; init; }
    public required int ID { get; init; }

    public required GradeLevel Year { get; init; }
    public required List<int> Scores { get; init; }

    public required int DepartmentID { get; init; }
}

public class Teacher
{
    public required string First { get; init; }
    public required string Last { get; init; }
    public required int ID { get; init; }
    public required string City { get; init; }
}

public class Department
{
    public required string Name { get; init; }
    public int ID { get; init; }

    public required int TeacherID { get; init; }
}