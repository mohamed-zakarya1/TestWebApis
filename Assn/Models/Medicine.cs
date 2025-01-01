namespace Assn.Models
{
    public class Medicine
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public IList<Patient>? Patients { get; set; }
    }
}
