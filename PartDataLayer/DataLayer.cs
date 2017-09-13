using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Text;
using PartDataLayer.DTO;

namespace PartDataLayer
{
    public class DataLayer : IDataLayer
    {
        private const string ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\PartNumber.accdb";
        private OleDbConnection _connection;
        private OleDbConnection Connection => _connection ?? (_connection = new OleDbConnection(ConnectionString));

        public List<DtoPart> GetAllParts()
        {
            
            var tempList = new List<DtoPart>();

            var sql = new StringBuilder();
    
            sql.AppendLine("SELECT PartNumber     ");
            sql.AppendLine("      ,PartPrice      ");
            sql.AppendLine("      ,PartDescription");
            sql.AppendLine("FROM   parts          ");

            using (var command = new OleDbCommand(sql.ToString(), Connection))
            {
                if (command.Connection.State == System.Data.ConnectionState.Closed)
                    Connection.Open();

                using (var reader = command.ExecuteReader())
                {
                    if (reader != null && !reader.HasRows) return tempList;
                    while (reader != null && reader.Read())
                    {
                        tempList.Add(new DtoPart(
                                         reader["PartNumber"].ToString(),
                                        double.Parse(reader["PartPrice"].ToString()),
                                        reader["PartDescription"].ToString()
                                        ));
                    }
                }
                if (command.Connection.State == System.Data.ConnectionState.Open)
                    Connection.Close();
            }

            return tempList;
        }
        public bool InstsertIntoDataBase(List<DtoPart> insertList)
        {
            var sql = new StringBuilder();

            sql.AppendLine("INSERT INTO parts   ");
            sql.AppendLine("      (PartNumber       ");
            sql.AppendLine("      ,PartPrice        ");
            sql.AppendLine("      ,PartDescription) ");
            sql.AppendLine("Values                  ");
            sql.AppendLine("      (@PartNumber      ");
            sql.AppendLine("      ,@PartPrice       ");
            sql.AppendLine("      ,@PartDescription)");


            using (var command = new OleDbCommand(sql.ToString(), Connection))
            {
                if (command.Connection.State == System.Data.ConnectionState.Closed)
                    Connection.Open();
                using (var transaction = command.Connection.BeginTransaction())
                {
                    command.Transaction = transaction;
                    try
                    {
                        foreach (var item in insertList)
                        {

                            command.Parameters.Clear();
                            command.Parameters.AddWithValue("@PartNumber", item.PartNumber);
                            command.Parameters.AddWithValue("@PartPrice", item.PartPrice);
                            command.Parameters.AddWithValue("@PartDescription", item.PartDesciption);
                            command.ExecuteNonQuery();

                        }

                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        return false;
                    }

                    transaction.Commit();
                    return true;
                }
            }
            
        }


        public bool UpdateIntoDataBase(List<DtoPart> insertList)
        {
            var sql = new StringBuilder();

            sql.AppendLine("UPDATE parts                             ");
            sql.AppendLine("SET   PartPrice = @PartPrice             ");
            sql.AppendLine("     ,PartDescription = @PartDescription ");
            sql.AppendLine("WHERE PartNumber = @PartNumber           ");


            using (var command = new OleDbCommand(sql.ToString(), Connection))
            {
                if (command.Connection.State == System.Data.ConnectionState.Closed)
                    Connection.Open();
                using (var transaction = command.Connection.BeginTransaction())
                {
                    command.Transaction = transaction;
                    try
                    {
                        foreach (var item in insertList)
                        {

                            command.Parameters.Clear();
                            command.Parameters.AddWithValue("@PartPrice", item.PartPrice);
                            command.Parameters.AddWithValue("@PartDesciption", item.PartDesciption);
                            command.Parameters.AddWithValue("@PartNumber", item.PartNumber);
                            command.ExecuteNonQuery();

                        }

                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        return false;
                    }

                    transaction.Commit();
                    return true;
                }
            }
        }





        public bool DeleteIntoDataBase(List<DtoPart> insertList)
        {
            var sql = new StringBuilder();

            sql.AppendLine("Delete From parts                         ");
            sql.AppendLine("WHERE PartNumber = @PartNumber           ");


            using (var command = new OleDbCommand(sql.ToString(), Connection))
            {
                if (command.Connection.State == System.Data.ConnectionState.Closed)
                    Connection.Open();
                using (var transaction = command.Connection.BeginTransaction())
                {
                    command.Transaction = transaction;
                    try
                    {
                        foreach (var item in insertList)
                        {

                            command.Parameters.Clear();
                            command.Parameters.AddWithValue("@PartNumber", item.PartNumber);
                            command.ExecuteNonQuery();

                        }

                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        return false;
                    }

                    transaction.Commit();
                    return true;
                }
            }

        }
		
		
		
		
		

    }
}

