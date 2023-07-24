using Sender.DTO;

namespace Sender.Services
{
    public interface IPos
    {
        bool AddPos(PosDTO posDTO);
        Pos SeekPos(string Name);
        string DeletePos(Guid guidPos);
    }
}
