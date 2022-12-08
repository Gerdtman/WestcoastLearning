namespace WestcoastLearning;

public interface IParticipant
{
    string FirstName { get; set;}
    string LastName { get; set; }
    string SocialSecurity { get; }
    string StreetAdress { get; set; }
    string PostalCode { get; set; }
    string City { get; set; }
    string Phone { get; set; }
    string Email {get; set;}

    public bool Save();

    public bool Validate();
}