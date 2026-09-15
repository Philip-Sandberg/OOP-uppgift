class Student (string Name)
{
   public string Name = Name;
   public List<Course> Courses = [];
   public void joinCourse(Course course)
   {
      course.addStudent(this);
   }

   public void leaveCourse(Course course)
   {
      if (!Courses.Contains(course))
      {
         Console.WriteLine($"{Name} kan inte lämna en kurs de inte går");
         return;
      }
   course.removeStudent(this);
   }

   public void printCourses()
   {
      Console.WriteLine($"Kurser som {Name} går:");
      foreach (Course course in Courses)
      {
         Console.WriteLine(course.Name);
      }
   }
}