using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Sender.DB;
using Sender.DTO;

namespace Sender.Services
{
    public class Consignors : IConsignor
    {
        private readonly IMapper _mapper;
        private readonly ConnectMssql _connectMssql;
        private readonly IPasswordHasher<Consignor> _passwordHasher;

        public Consignors(IMapper mapper, ConnectMssql connectMssql, IPasswordHasher<Consignor> passwordHasher)
        {
            _mapper = mapper;
            _connectMssql = connectMssql;
            _passwordHasher = passwordHasher;
        }

        public bool AddConsignor(ConsignorDTO consignorDTO)
        {
            var result = _mapper.Map<Consignor>(consignorDTO);
            result.Id = Guid.NewGuid();
            result.dateTimeCreate = DateTime.Now;
            result.Password = _passwordHasher.HashPassword(result, consignorDTO.Password);
            _connectMssql.consignors.Add(result);
            _connectMssql.SaveChanges();
            return true;
        }

        public List<Consignor> GetConsignor(string Name)
        {
           var result =  _connectMssql.consignors.Where(x => x.Name == Name).ToList();
            return result;
        }
    }
}
