using AutoMapper;
using Sender.DB;
using Sender.DTO;

namespace Sender.Services
{
    public class Consignors : IConsignor
    {
        private readonly IMapper _mapper;
        private readonly ConnectMssql _connectMssql;

        public Consignors(IMapper mapper, ConnectMssql connectMssql)
        {
            _mapper = mapper;
            _connectMssql = connectMssql;
        }

        public bool AddConsignor(ConsignorDTO consignorDTO)
        {
            var result = _mapper.Map<Consignor>(consignorDTO);
            result.Id = Guid.NewGuid();
            result.dateTimeCreate = DateTime.Now;
            _connectMssql.consignors.Add(result);
            _connectMssql.SaveChanges();
            return true;
        }

        public Guid GetConsignor(string Name)
        {
            throw new NotImplementedException();
        }
    }
}
