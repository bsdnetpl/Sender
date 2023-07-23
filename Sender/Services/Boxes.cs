using Sender.DTO;

namespace Sender.Services
{
    public class Boxes : Ibox
    {
        public Box AddBox(BoxDTO boxDTO, Guid PosGuid, Guid Consignor, Guid CustomerGuid)
        {
            throw new NotImplementedException();
        }

        public string GenerateCodePickup()
        {
            throw new NotImplementedException();
        }

        public Box PackagePickup(Guid BoxGuid, string CodePickup)
        {
            throw new NotImplementedException();
        }

        public Box ReturnBox(Guid ConsignorId)
        {
            throw new NotImplementedException();
        }

        public Box SeekBox(Guid guidBox)
        {
            throw new NotImplementedException();
        }
    }
}
