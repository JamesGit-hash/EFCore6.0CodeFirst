namespace PropertyInspection.Data
{
    public class Inspector
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int AgentId { get; set; }
        public Agent Agent { get; set; }
    }
}