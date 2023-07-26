using Sender.DTO;

namespace Sender.Services
{
    public interface Ibox
    {
        Box AddBox(BoxDTO boxDTO, Guid PosGuid, Guid Consignor, Guid CustomerGuid);
        Box SeekBox(Guid guidBox);
        Box ReturnBox(Guid BoxId);
        string PackagePickup(Guid BoxGuid, string CodePickup);
        string GenerateCodePickup(int longString);
        string DeletePackage(Guid IdPackage);
    }
}
