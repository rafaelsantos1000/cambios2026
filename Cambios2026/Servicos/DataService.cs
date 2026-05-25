using Cambios2026.Modelos;
using Microsoft.Data.Sqlite;

namespace Cambios2026.Servicos
{
    public class DataService
    {
        private SqliteConnection connection;

        private SqliteCommand command;

        private DialogService dialogService;


        public DataService()
        {
            dialogService = new DialogService();

            if (!Directory.Exists("Data"))
            {
                Directory.CreateDirectory("Data");
            }

            var path = @"Data\Rates.sqlite";

            try
            {
                connection = new SqliteConnection("Data Source=" + path);
                connection.Open();

                string sqlcommand = "create table if not exists rates(RateId int, Code varchar(5), TaxRate real, Name varchar(250))";

                command = new SqliteCommand(sqlcommand, connection);

                command.ExecuteNonQuery();
            }
            catch(Exception e)
            {
                dialogService.ShowMessage(e.Message, "Erro");
            }
        }

        public void SaveData(List<Rate> Rates)
        {
            try
            {
                foreach(var rate in Rates)
                {
                    string sql = string.Format("insert into Rates (RateId,Code,TaxRate,Name) values({0}, '{1}', {2}, '{3}')"
                        ,rate.RateId, rate.Code, rate.TaxRate, rate.Name);

                    command = new SqliteCommand(sql, connection);

                    command.ExecuteNonQuery();
                }

                connection.Close();
            }
            catch(Exception e)
            {
                dialogService.ShowMessage(e.Message, "Erro");
            }
        }

        public List<Rate> GetData()
        {
            List<Rate> rates = new List<Rate>();

            try
            {
                string sql = "select RateId, Code, TaxRate, Name from Rates";

                command = new SqliteCommand(sql, connection);

                //Lê cada registo
                SqliteDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    rates.Add(new Rate
                    {
                        RateId = Convert.ToInt32(reader["RateId"]),
                        Code = reader["Code"].ToString(),
                        Name = reader["Name"].ToString(),
                        TaxRate = Convert.ToDouble(reader["TaxRate"]),
                    });
                }

                connection.Close();

                return rates;
            }
            catch(Exception e)
            {
                dialogService.ShowMessage(e.Message, "Erro");
                return null;
            }
        }

        public void DeleteData()
        {
            try
            {
                string sql = "delete from Rates";

                command = new SqliteCommand(sql, connection);

                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                dialogService.ShowMessage(e.Message, "Erro");
            }
        }
    }
}
