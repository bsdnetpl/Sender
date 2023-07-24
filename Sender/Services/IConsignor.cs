using Sender.DTO;

namespace Sender.Services
{
    public interface IConsignor
    {
        Guid GetConsignor(string Name);
        bool AddConsignor(ConsignorDTO consignorDTO);
    }
}
