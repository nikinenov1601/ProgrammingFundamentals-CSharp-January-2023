
string input = Console.ReadLine();
Dictionary<string, int> courses = new Dictionary<string, int>();
Dictionary<string, string> studentNames = new Dictionary<string, string>();

while (input != "end")
{
    string[] inputSplit = input.Split(':', StringSplitOptions.RemoveEmptyEntries).ToArray();

    string courseName = inputSplit[0];
    string studentName = inputSplit[1];

    if (courses.ContainsKey(courseName))
    {
        courses[courseName]++;
        studentNames.TryAdd(studentName, courseName);
    }
    else
    {
        courses.Add(courseName, 1);
        studentNames.Add(studentName, courseName);

    }


    input = Console.ReadLine();
}

foreach (var course in courses)
{
    Console.WriteLine($"{course.Key}: {course.Value}");

    foreach (var student in studentNames.Keys)
    {
        Console.WriteLine($"-- {student}");
    }
}
