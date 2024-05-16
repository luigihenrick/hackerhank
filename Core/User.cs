namespace Core;
public class User
{
    public User(string name, DateTime birthday)
    {
        Name = name;
        Birthday = birthday;
    }

    public Guid Id { get; set; }
    public string? Name { get; set; }
    public DateTime Birthday { get; set; }

    public bool IsAdult() => this.Birthday <= DateTime.Now.AddYears(-18);
}
