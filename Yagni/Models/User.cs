namespace Yagni.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public DateTime CreatedDate { get; set; }

        public User(string _username, string _password)
        {
            Username = _username;
            Password = _password;
        }
        public string GetUser()
        {
            return Username + "     " + Password;
        }
    }
}
