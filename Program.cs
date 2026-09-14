Student philip = new Student("Philip");
Student martin = new Student("Martin");
Student emma = new Student("Emma");
Course math = new Course("Matematik", 5);
Course english = new Course("Engelska", 5);
Course programming = new Course("Programmering", 2);

math.addStudent(philip);
english.addStudent(philip);
english.addStudent(martin);
programming.addStudent(philip);
programming.addStudent(martin);
programming.addStudent(emma);
programming.removeStudent(philip);
programming.removeStudent(philip);
programming.addStudent(emma);
english.addStudent(emma);
programming.printStudents();


Console.WriteLine(english.Name);
Console.WriteLine($"({english.Students.Count}/{english.MaxParticipants})");

Console.WriteLine($"{martin.Name} går {martin.Courses.Count} kurser");

Console.WriteLine($"{math.Name} ({math.Students.Count}/{math.MaxParticipants})");
Console.WriteLine($"{philip.Name} går {philip.Courses.Count} kurser");