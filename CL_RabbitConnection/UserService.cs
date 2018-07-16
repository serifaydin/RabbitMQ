namespace CL_RabbitConnection
{
    public static class UserService
    {
        public static User Load()
        {
            return new User()
            {
                Id = 1,
                Name = "Serif",
                Surname = "Aydin"
            };
        }
    }

    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}