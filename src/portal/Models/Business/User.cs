namespace portal.Models.Business
{
    public class User : IBusinessModel
    {
        public string Id { get; set; }

        public string Username { get; set; }

        public string Email { get; set; }

        public string HashedPassword { get; set; }
    }
}
