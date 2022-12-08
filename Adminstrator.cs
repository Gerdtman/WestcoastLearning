namespace WestcoastLearning;

class Administrator : Faculty
{
    public Administrator(string firstname, string lastname, string email, string socialsecurity) : base(firstname, lastname, email, socialsecurity)
    {
        AdministrativePrivelages = true;
    }
}