namespace MeetingApp.Models
{
    public static class Repository
    {
        private static List<UserInfo> _users = new();

        static Repository()
        {
            _users.Add(new UserInfo() { Name = "Kadir", Email = "abc@kadir.com", Phone = "555 555 55 55", WillAttend = true });
            _users.Add(new UserInfo() { Name = "Meltem", Email = "abc@meltem.com", Phone = "553 555 55 55", WillAttend = false });
            _users.Add(new UserInfo() { Name = "Ahmet", Email = "abc@ahmet.com", Phone = "555 552 55 55", WillAttend = true });
        }
        

        public static List<UserInfo> Users
        {
            get { return _users; }
        }

        public static void CreateUser(UserInfo user)
        {
            _users.Add(user);
        }
    }
}