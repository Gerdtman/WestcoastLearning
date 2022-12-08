namespace WestcoastLearning;

class Course
{
    public Guid CourseId { get; } = Guid.NewGuid();
    public string Name { get; set; } = "";
    public int StudentRating { get; set;}
    public bool InHouse {get; set;} //Definera om kursen sker på platts eller inte.
    public string Subject = "";  //Kan användas vid senare skede för att rekommendera liknande kurser.
    public DateTime StartDate { get; } = DateTime.Now;
    public DateTime EndDate { get; } = DateTime.Now.AddMonths(6);
    public string CourseNumber { get; set; } = ""; //Ger  möjlighet att tildela lektionen ett simplare ID för lokalt bruk
    public List<Teacher> AvailableTeachers = new List<Teacher>();
    public List<Student> AttendingStudents = new List<Student>();

    public bool Save()
    {
        Console.WriteLine($"The course: {Name} is saved.");
        return true;
    }
    public bool Validate()
    {
        return true;
    }

    public void ListTeachers()
    {
          foreach(var i in AvailableTeachers)
          {
            Console.WriteLine(i);
          }
    }
    public void ListStudents()
    {
          foreach(var i in AttendingStudents)
          {
            Console.WriteLine(i);
          }
    }

    public string BookCourse()
    {
        if(AttendingStudents.Count() > 5 && AvailableTeachers.Count() >= 1)
        {
            return $"Kursen, {Name} med start {StartDate}, kommer genomföras då fler än fem elever ska delta och vi har tillgängliga lärare.";
        }
            return $"Kursen, {Name} med start {StartDate}, kommer inte genomföras då inte nog med elever vill delta eller inga lärare finns tillgängliga"; 
    }
}

