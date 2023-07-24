using Sender.DTO;

namespace Sender.Services
{
    public class Boxes : Ibox
    {
        private readonly string[] alphabetNumeric = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };
        
        public Box AddBox(BoxDTO boxDTO, Guid PosGuid, Guid Consignor, Guid CustomerGuid)
        {
            throw new NotImplementedException();
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

        public Box PackagePickup(Guid BoxGuid, string CodePickup)
        {
            throw new NotImplementedException();
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
