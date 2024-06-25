namespace FirstApp.Entity
{
    public class Admin
    {

        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public bool? Deleted { get; set; }
    }
}
