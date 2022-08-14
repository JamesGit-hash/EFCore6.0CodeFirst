namespace PropertyInspection.Data
{
    public class Agent
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Company { get; set; }

        public ICollection<Inspector> Inspectors { get; set; }
    }
}