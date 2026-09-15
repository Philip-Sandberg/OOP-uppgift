Student philip = new Student("Philip");
Student martin = new Student("Martin");
Student emma = new Student("Emma");
Course math = new Course("Matematik", 5);
Course english = new Course("Engelska", 5);
Course programming = new Course("Programmering", 2);

martin.LeaveCourse(english);
emma.PrintCourses();
math.PrintStudents();
programming.RemoveStudent(philip);
philip.LeaveCourse(math);
math.AddStudent(philip);
english.AddStudent(philip);
english.AddStudent(martin);
programming.AddStudent(philip);
programming.AddStudent(martin);
programming.AddStudent(emma);
emma.JoinCourse(programming);
programming.RemoveStudent(philip);
programming.RemoveStudent(philip);
programming.AddStudent(emma);
english.AddStudent(emma);
programming.PrintStudents();
philip.LeaveCourse(programming);
philip.LeaveCourse(english);
philip.PrintCourses();
emma.PrintCourses();
martin.PrintCourses();
english.PrintStudents();
math.PrintStudents();

Console.WriteLine("");
Console.WriteLine($"{english.Name} ({english.Students.Count}/{english.MaxParticipants})");

Console.WriteLine($"{martin.Name} går {martin.Courses.Count} kurser");

Console.WriteLine($"{math.Name} ({math.Students.Count}/{math.MaxParticipants})");
Console.WriteLine($"{philip.Name} går {philip.Courses.Count} kurser");