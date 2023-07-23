using Sender.DTO;

namespace Sender.Services
{
    public interface Ibox
    {
       Box AddBox(BoxDTO boxDTO, Guid PosGuid, Guid Consignor, Guid CustomerGuid);
        Box SeekBox(Guid guidBox);
        Box ReturnBox(Guid ConsignorId);
        Box PackagePickup(Guid BoxGuid, string CodePickup);
        string GenerateCodePickup();

    }
}
