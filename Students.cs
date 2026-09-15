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




}