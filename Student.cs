namespace WestcoastLearning;

class Student : IParticipant
{
    public Guid MemberID { get; } = Guid.NewGuid();
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string SocialSecurity { get; } =""; 
    public string StreetAdress { get; set; } ="";
    public string PostalCode { get; set; } ="";
    public string City { get; set; } ="";
    public string Phone { get; set; } ="";
    public string Email { get; set; }
    public List<Course> FinishedCourses {get; private set;} = new List<Course>(); //Köptaslutförda kurser. Course.Subject används senare för att rekomendera ny kurser.
    public List<Course> EnrolledIn {get; private set;} = new List<Course>(); //Köpta pågåender kurser.

    public Student(string firstname, string lastname, string email, string socialsecurity)
    {
        FirstName = firstname;
        LastName = lastname;
        Email = email;
        SocialSecurity = socialsecurity;
    }
    public virtual bool Save()
    {
        Validate();
        Console.WriteLine("Participant saved.");
        return true;
    }

    public bool Validate()
    {
        return true;
    }

    public void Enroll(Course course)
    {
        foreach (var c in EnrolledIn)
        {
            if(course == c)
            {
                EnrolledIn.Remove(c);
                break;
            }
        }
        EnrolledIn.Add(course);
    }
    public void FinishCourse(Course course)
    {
        foreach (var c in FinishedCourses)
        {
            if(course == c)
            {
                EnrolledIn.Remove(c);
                break;
            }
        }
        FinishedCourses.Add(course);
    }
    public void ListCourses()
    {
        foreach(var i in EnrolledIn)
        {
            Console.WriteLine(i);
        }
    }

}