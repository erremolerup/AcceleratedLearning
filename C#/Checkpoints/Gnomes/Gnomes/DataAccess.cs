using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Gnomes
{
    public class DataAccess
    {
        public string conString = "Server = (localdb)\\mssqllocaldb; Database = GnomeDb";

        internal List<Gnome> GetGnomesFromDatabase()
        {
            var sql = @"SELECT Name, BeardYesOrNo, Intention, Temper, Type
                        FROM Gnome
                        LEFT JOIN Temper ON TemperId = Temper.Id
                        LEFT JOIN Type ON TypeId = Type.Id
                        LEFT JOIN Beard ON BeardId = Beard.Id
                        LEFT JOIN Intention ON IntentionId = Intention.Id";

            using (SqlConnection connection = new SqlConnection(conString))
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                var list = new List<Gnome>();

                while (reader.Read())
                {
                    var gn = new Gnome
                    {
                        Name = reader.GetSqlString(0).Value,
                        BeardYesOrNo = reader.GetSqlString(1).Value,
                        Intention = reader.GetSqlString(2).Value,
                        Temper = reader.GetSqlInt32(3).Value,
                        Type = reader.GetSqlString(4).Value
                    };
                    list.Add(gn);
                }
                return list;
            }
        }
    }
}
