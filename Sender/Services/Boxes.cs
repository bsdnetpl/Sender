using Sender.DB;
using Sender.DTO;

namespace Sender.Services
{
    public class Boxes : Ibox
    {
        private readonly string[] alphabetNumeric = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };
        private readonly ConnectMssql _connectMssql;

        public Boxes(ConnectMssql connectMssql)
        {
            _connectMssql = connectMssql;
        }

        public Box AddBox(BoxDTO boxDTO, Guid PosGuid, Guid Consignor, Guid CustomerGuid)
        {
            Box box = new Box();
            box.Id = Guid.NewGuid();
            box.Description = boxDTO.Description;
            box.weight = boxDTO.weight;
            box.pickup_code = GenerateCodePickup(6);
            box.PosGuid = PosGuid;
            box.CustomerGuid = CustomerGuid;
            box.ConsignorGuid = Consignor;
            box.DateTimeCreateBox = DateTime.Now;
            box.Received = false;
            box.DateTimeUpdateBox = DateTime.Now;
            box.Name = boxDTO.Name;
            _connectMssql.boxes.Add(box);
            _connectMssql.SaveChanges();
            return box;
        }

        public string DeletePackage(Guid IdPackage)
        {
            var result = _connectMssql.boxes.Find(IdPackage);
            _connectMssql.Remove(result);
            _connectMssql.SaveChanges();
            return "Package delete";
        }

        public string GenerateCodePickup(int longString)
        {
            Random rnd = new Random();
            var Password = new List<string>();
            for (int i = 0; i < longString; i++)
            {
                Password.Add(alphabetNumeric[rnd.Next(0, alphabetNumeric.Count())]);
            }
          return string.Join("", Password);
        }

        public string PackagePickup(Guid BoxGuid, string CodePickup)
        {
            var result = _connectMssql.boxes.Find(BoxGuid);
            if(result is null)
            {
                return "No package";
            }
            if(result.Received == true)
            {
                return "Package Has been delivered";
            }
            if(result.pickup_code == CodePickup)
            {
                result.Received = true;
                result.DateTimeUpdateBox = DateTime.Now;
                _connectMssql.SaveChanges();
                return "Package Recieve";
            }
            return "Wrong Code";
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
