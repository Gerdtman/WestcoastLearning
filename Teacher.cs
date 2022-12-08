namespace WestcoastLearning;

class Teacher : Faculty
{
    public List<Course> AssignedCourses = new List<Course>(); 
    public Teacher(string firstname, string lastname, string email, string socialsecurity) : base(firstname, lastname, email, socialsecurity)
    {
    }
    public void AssignCourse(Course course)
    {
        foreach (var c in AssignedCourses)
        {
            if(course == c)
            {
                AssignedCourses.Remove(c);
                break;
            }
        }
        AssignedCourses.Add(course);
    }
}