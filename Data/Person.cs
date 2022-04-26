namespace PersonAPI.Data
{
    public class Person : IDbEntity
    {
        public int Id { get; set; }
        public Guid GID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime WorkedAt { get; set; }
    }
}
