class Student (string Name)
{
   public string Name = Name;
   public List<Course> Courses = [];
   public void joinCourse(Course course)
   {
      if(Courses.Contains(course)){
         return;
      }
      course.addStudent(this);
      Courses.Add(course);
   }

public void leaveCourse(Course course)
{
   if (!Courses.Contains(course))
   {
      return;
   }
    Courses.Remove(course);
    course.removeStudent(this);
}
}