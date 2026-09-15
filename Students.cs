class Student (string Name)
{
   public string Name = Name;
   public List<Course> Courses = [];
   public void JoinCourse(Course course)
   {
      course.AddStudent(this);
   }

   public void LeaveCourse(Course course)
   {
      if (!Courses.Contains(course))
      {
         Console.WriteLine($"{Name} kan inte lämna en kurs de inte går");
         return;
      }
   course.RemoveStudent(this);
   }

   public void PrintCourses()
   {
      Console.WriteLine($"Kurser som {Name} går:");
      foreach (Course course in Courses)
      {
         Console.WriteLine(course.Name);
      }
   }
}