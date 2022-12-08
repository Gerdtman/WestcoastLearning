namespace WestcoastLearning;

class EducationalLeader : Faculty
{
    public EducationalLeader(string firstname, string lastname, string email, string socialsecurity) : base(firstname, lastname, email, socialsecurity)
    {
        AdministrativePrivelages = true;
    }
}