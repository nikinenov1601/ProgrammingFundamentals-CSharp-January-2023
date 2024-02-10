string input = Console.ReadLine();

List<Student> students = new List<Student>();

while (input != "end")
{
    string[] inputSplitted = input.Split(" ");
    string firstName = inputSplitted[0];
    string lastName = inputSplitted[1];
    int age = int.Parse(inputSplitted[2]);
    string homeTown = inputSplitted[3];

    bool studentExist = false;

    foreach (var student in students)
    {
        if (student.FirstName == firstName && student.LastName == lastName)
        {
            studentExist = true;
            break;
        }
    }

    if (studentExist)
    {
        foreach (var student in students)
        {
            if (student.FirstName == firstName && student.LastName == lastName)
            {
                student.Age = age;
                student.HomeTown = homeTown;
            }
        }
    }

    else
    {
        Student student = new Student() // Нова инстанция за листа 
        {
            FirstName = firstName, // 
            LastName = lastName,
            Age = age,
            HomeTown = homeTown
        };
        students.Add(student);
    }

    input = Console.ReadLine();
}

string town = Console.ReadLine();

foreach (Student student in students)
{
    if (student.HomeTown == town)
    {
        Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
    }
}

class Student
{
    public string FirstName { get; set; }

    public string LastName { get; set; }

    public int Age { get; set; }

    public string HomeTown { get; set; }
}