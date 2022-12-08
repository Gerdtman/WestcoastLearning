namespace WestcoastLearning;

class Faculty : IParticipant
{
    public Guid MemberID { get; } = Guid.NewGuid();
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string SocialSecurity { get; } =""; 
    public string StreetAdress { get; set; } ="";
    public string PostalCode { get; set; } ="";
    public string City { get; set; } ="";
    public string Phone { get; set; } ="";
    public string Email { get; set; } = "";
    public bool AdministrativePrivelages {get; set;}



    public Faculty(string firstname, string lastname, string email, string socialsecurity)
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

}