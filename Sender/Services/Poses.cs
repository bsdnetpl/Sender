﻿using Microsoft.AspNetCore.Identity;
using Sender.DB;
using Sender.DTO;

namespace Sender.Services
{
    public class Poses : IPos
    {
        private readonly ConnectMssql _connectMssql;
        private readonly IPasswordHasher<Pos> _passwordHasher;

        public Poses(ConnectMssql connectMssql, IPasswordHasher<Pos> passwordHasher)
        {
            _connectMssql = connectMssql;
            _passwordHasher = passwordHasher;
        }

        public bool AddPos(PosDTO posDTO)
        {
            Pos pos = new Pos();
            pos.Id = Guid.NewGuid();
            pos.DateTimeCreate = DateTime.Now;
            pos.DatadateOfReceipt = DateTime.Now;
            pos.Password = _passwordHasher.HashPassword(pos, posDTO.Password);
            pos.Address = posDTO.Address;
            pos.email = posDTO.email;
            pos.Address = posDTO.Address;
            pos.City = posDTO.City;
            pos.Country = posDTO.Country;
            pos.Name = posDTO.Name;
            pos.NIP = posDTO.NIP;
            pos.PostalCode = posDTO.PostalCode;
            pos.Phone = posDTO.Phone;
            pos.Description = posDTO.Description;
            _connectMssql.Pos.Add(pos);
            _connectMssql.SaveChanges();
            return true;
        }

        public string DeletePos(Guid guidPos)
        {
            var result = _connectMssql.Pos.Find(guidPos);
            if(result is null)
            {
                return $"No package {guidPos}";
            }
            _connectMssql.Pos.Remove(result);
            _connectMssql.SaveChanges();
            return $"Package was removed : {guidPos}";
        }

        public List<Pos> SeekPos(string Name)
        {
            var result = _connectMssql.Pos.Where(x => x.Name == Name).ToList();
            return result;
        }
    }
}
