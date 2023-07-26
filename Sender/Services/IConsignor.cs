using Sender.DTO;

namespace Sender.Services
{
    public interface IConsignor
    {
        List<Consignor> GetConsignor(string Name);
        bool AddConsignor(ConsignorDTO consignorDTO);
    }
}
