using System.ComponentModel;

namespace Sender.DTO
{
    public class Box
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid PosGuid { get; set; }
        public Guid CustomerGuid { get; set; }
        public Guid ConsignorGuid { get; set; }
        public DateTime DateTimeCreateBox { get; set; }
        public DateTime DateTimeUpdateBox { get; set;}
        public string pickup_code { get; set; }
        public double weight { get; set; }
        [DefaultValue("false")]
        public  bool Received;
        [DefaultValue("false")]
        public bool ReturnBox;
        public DateTime DateTimeReturnBox { get; set; }
    }
}
