using Sender.DTO;

namespace Sender.Services
{
    public interface IPos
    {
        bool AddPos(PosDTO posDTO);
        List<Pos> SeekPos(string Name);
        string DeletePos(Guid guidPos);
    }
}
