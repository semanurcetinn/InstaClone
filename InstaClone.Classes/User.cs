namespace InstaClone.Classes
{
    public class User{   
        public ulong UserId { get; set; }
        public string UserName { get; set; }
        public int Password { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public ulong PhoneNumber { get; set; }

        public User(string userName, int password, string email, string name, string gender, ulong phoneNumber, ulong userId)
        {
            UserName = userName;
            Password = password;
            Email = email;
            Name = name;
            Gender = gender;
            PhoneNumber = phoneNumber;
            UserId = userId;
        }
    }
}
