public class Admin
{
    public int AdminId { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }

    public Admin(int adminId, string name, string email, string password)
    {
        AdminId = adminId;
        Name = name;
        Email = email;
        Password = password;
    }
}