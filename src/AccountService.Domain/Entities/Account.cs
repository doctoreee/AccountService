namespace AccountService.Domain.Entities;

public sealed class Account : Entity<long>
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public Account(){}

    public Account(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName; 
    }
}
