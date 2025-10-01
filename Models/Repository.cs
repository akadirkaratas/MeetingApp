namespace MeetingApp.Models
{
    public static class Repository
    {
        private static List<UserInfo> _users = new();

        static Repository()
        {
            _users.Add(new UserInfo() { Id = 1, Name = "Kadir", Email = "abc@kadir.com", Phone = "555 555 55 55", WillAttend = true });
            _users.Add(new UserInfo() { Id = 2, Name = "Meltem", Email = "abc@meltem.com", Phone = "553 555 55 55", WillAttend = false });
            _users.Add(new UserInfo() { Id = 3, Name = "Ahmet", Email = "abc@ahmet.com", Phone = "555 552 55 55", WillAttend = true });
        }


        public static List<UserInfo> Users
        {
            get { return _users; }
        }

        public static void CreateUser(UserInfo user)
        {
            user.Id = Users.Count + 1;
            _users.Add(user);
        }

        public static UserInfo? GetById(int id)
        {
            return _users.FirstOrDefault(user => user.Id == id);
        }
    }
}