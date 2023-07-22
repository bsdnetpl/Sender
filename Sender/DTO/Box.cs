namespace Sender.DTO
{
    public class Box
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid PosGuid { get; set; }
        public Guid CustomerGuid { get; set; }
        public Guid Consignor { get; set; }
        public DateTime DateTimeCreateBox { get; set; }
        public DateTime DateTimeUpdateBox { get; set;}
        public double weight { get; set; }
    }
}
