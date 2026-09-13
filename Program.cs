Student philip = new Student("Philip", "Sandberg");

Console.WriteLine(philip.Name);
Console.WriteLine(philip.LastName);
Console.WriteLine(philip.Courses.Count);

Course math = new Course("Matematik", 5);

Console.WriteLine(math.Name);
Console.WriteLine($"({math.Students.Count}/{math.MaxParticipants})");
