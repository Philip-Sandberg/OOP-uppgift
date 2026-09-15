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
         Console.WriteLine($"{Name} var inte med i den här kursen");
         return;
      }
   course.RemoveStudent(this);
   }

   public void PrintCourses()
   {
      if (Courses.Count == 0)
      {
         Console.WriteLine($"{Name} går inte några kurser");
      } else
      {
      Console.WriteLine($"Kurser som {Name} går:");
      foreach (Course course in Courses)
      {
         Console.WriteLine(course.Name);
      }
      }
   }
}