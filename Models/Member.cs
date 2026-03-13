public class Member
{
    public int MemberId { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }

    public Member(int memberId, string name, string email, string password)
    {
        MemberId = memberId;
        Name = name;
        Email = email;
        Password = password;
    }
}