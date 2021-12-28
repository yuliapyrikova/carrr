using carrr.Domain;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace carrr.Repository
{
    public class AutopickerStorage
    {
        private Dictionary<int, Autopicker> Autopickers { get; } = new Dictionary<int, Autopicker>();
        //private SqlConnection Connection { get; } = new SqlConnection("Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;");
        //public AutopickerStorage() => Connection.Open();

        public void Create(Autopicker autopicker)
        {
            Autopickers.Add(autopicker.AutopickerId, autopicker);
            //var command = Connection.CreateCommand();
            //command.CommandText = "SELECT * FROM .....";
            //command.ExecuteNonQuery
            //command.ExecuteReader
            //command.ExecuteScalar
        }

        public Autopicker Read(int autopickerId)
        {
            return Autopickers[autopickerId];
        }

        public Autopicker Update(int autopickerId, Autopicker newAutopicker)
        {
            Autopickers[autopickerId] = newAutopicker;
            return Autopickers[autopickerId];
        }

        public bool Delete(int autopickerId)
        {
            return Autopickers.Remove(autopickerId);
        }
    }
}