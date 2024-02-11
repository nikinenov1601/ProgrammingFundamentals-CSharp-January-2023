

Dictionary<string, (string name, int age)> people = new Dictionary<string, (string name, int age)>();

string input;
while ((input = Console.ReadLine()) != "End")
{
    string[] personInfo = input.Split();
    string name = personInfo[0];
    string id = personInfo[1];
    int age = int.Parse(personInfo[2]);

    // Update information if person already exists
    if (people.ContainsKey(id))
    {
        people[id] = (name, age);
    }
    else
    {
        people.Add(id, (name, age));
    }
}

// Order people by age and print
foreach (var person in people.OrderBy(p => p.Value.age))
{
    Console.WriteLine($"{person.Value.name} with ID: {person.Key} is {person.Value.age} years old.");
}