namespace FSL.ApiCustomIdentity.Models
{
    public sealed class MyLoggedUser : IUser
    {
        public string Id { get ; set ; }
        public string Name { get; set; }
        public string Credentials { get; set; }
        public bool IsAdmin { get; set; }
    }
}
