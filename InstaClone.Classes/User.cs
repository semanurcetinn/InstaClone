namespace InstaClone.Classes
{
    public class User{   
        public string UserId { get; set; }
        public string UserName { get; set; }
        public int Password { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int PhoneNumber { get; set; }

        public User(string userName, int password, string email, string name, string gender, int phoneNumber, string userId)
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
