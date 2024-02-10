string input = Console.ReadLine();

List<Student> students = new List<Student>();

while (input != "end")
{
    string[] inputSplitted = input.Split(" ");
    string firstName = inputSplitted[0];
    string lastName = inputSplitted[1];
    int age = int.Parse(inputSplitted[2]);
    string homeTown = inputSplitted[3];


    Student student = new Student(); // Нова инстанция за листа 

    student.FirstName = firstName; // 
    student.LastName = lastName;
    student.Age = age;
    student.HomeTown = homeTown;

    students.Add(student);

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