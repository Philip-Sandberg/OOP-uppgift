class Course (string Name, int MaxParticipants)
{
    public string Name = Name;
    public int MaxParticipants= MaxParticipants;
    public List<Student> Students = [];

    public void addStudent (Student student)
    {
        if(Students.Contains(student))
        {
            Console.WriteLine($"{student.Name} går redan den här kursen");
            return; //Is needed to prevent adding the same student multiple times
        }

        if(Students.Count >= MaxParticipants)
        {
            Console.WriteLine($"{Name} kan inte lägga till fler studenter, kursen är full");
            return; //Is needed to prevent adding more students than the maximum allowed
        }

        Students.Add(student);
        if (!student.Courses.Contains(this))
        {
            student.Courses.Add(this);
        }
    }
    public void removeStudent (Student student)
    {
        if(Students.Contains(student))
        {
            Students.Remove(student);
            student.Courses.Remove(this);
        }
        else
        {
            Console.WriteLine($"{student.Name} går inte den här kursen");
        }
    }

    public void printStudents()
    {
        Console.WriteLine($"Studenter som går {Name}:");
        foreach (Student student in Students)
        {
            Console.WriteLine(student.Name);
        }
    }
}