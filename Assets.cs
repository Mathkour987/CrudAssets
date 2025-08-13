namespace CrudAssets.Models
{
    public class Asset
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Model { get; set; }
        public DateTime AssignedDate { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }

}