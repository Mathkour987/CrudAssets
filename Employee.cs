namespace CrudAssets.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string JobTitle { get; set; }
        public string Email { get; set; }  
        public ICollection<Asset> Assets { get; set; }
    }

}
