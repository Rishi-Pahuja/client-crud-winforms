using BusinessLib.Common;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLib.Data;
internal class ClientRepository
{
    private const string connectionString = """
                                            Host=HostName;
                                            Port=15253;
                                            Database=DatabaseName;
                                            Username=*****;
                                            Password=*****;
                                            SslMode=Require;
                                            """;

    private const string tableName = "Clients";

    public static ClientList GetClients()
    {
        string sql = $"""
                      SELECT ClientCode,
                             CompanyName,
                             Address1,
                             Address2,
                             City,
                             Province,
                             PostalCode,
                             YTDSales,
                             CreditHold,
                             Notes
                      FROM {tableName}
                      """;

        ClientList clients = new();

        try
        {
            using NpgsqlConnection connection = new(connectionString);
            using NpgsqlCommand command       = new(sql, connection);

            connection.Open();

            using NpgsqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                clients.Add(new Client
                {
                    ClientCode   = reader["ClientCode"] as string,
                    CompanyName  = reader["CompanyName"] as string,
                    Address1     = reader["Address1"] as string,
                    Address2     = reader["Address2"] as string,
                    City         = reader["City"] as string,
                    Province     = reader["Province"] as string,
                    PostalCode   = reader["PostalCode"] as string,
                    YTDSales     = (decimal)reader["YTDSales"],
                    IsCreditHold = reader.IsDBNull(reader.GetOrdinal("CreditHold")) ? false : (bool)reader["CreditHold"],
                    Notes        = reader["Notes"] as string
                });
            }
        }
        catch (Exception ex)
        {
            throw new InvalidOperationException("Failed to connect to the database. Please refer to the README file.", ex);
        }


        return clients;
    }

    public static int AddClient(Client client)
    {
        string sql = $"""
                      INSERT INTO {tableName}
                      (
                         ClientCode,
                         CompanyName,
                         Address1,
                         Address2,
                         City,
                         Province,
                         PostalCode,
                         YTDSales,
                         CreditHold,
                         Notes
                      )
                      VALUES
                      (
                         @clientCode,
                         @companyName,
                         @address1,
                         @address2,
                         @city,
                         @province,
                         @postalCode,
                         @ytdSales,
                         @creditHold,
                         @notes
                      )
                      """;

        return processQuery(sql, client);
    }

    public static int UpdateClient(Client client)
    {
        string sql = $"""
                      UPDATE {tableName}
                      SET
                        CompanyName    = @companyName,
                        Address1       = @address1,
                        Address2       = @address2,
                        City           = @city,
                        Province       = @province,
                        PostalCode     = @postalCode,
                        YTDSales       = @ytdSales,
                        CreditHold     = @creditHold,
                        Notes          = @notes
                      WHERE ClientCode = @clientCode
                      """;

        return processQuery(sql, client);
    }

    public static int DeleteClient(Client client)
    {
        string sql = $"""
                      DELETE FROM {tableName}
                      WHERE ClientCode = @clientCode
                      """;

        using NpgsqlConnection connection = new(connectionString);
        using NpgsqlCommand command       = new(sql, connection);

        command.Parameters.AddWithValue("@clientCode", client.ClientCode.Trim());

        connection.Open();
        
        return command.ExecuteNonQuery();
    }

    private static int processQuery(string sql, Client client)
    {
        using NpgsqlConnection connection = new(connectionString);
        using NpgsqlCommand command       = new(sql, connection);

        command.Parameters.AddWithValue("@clientCode", client.ClientCode.Trim());
        command.Parameters.AddWithValue("@companyName", client.CompanyName);
        command.Parameters.AddWithValue("@address1", client.Address1);
        command.Parameters.AddWithValue("@address2", (object)client.Address2 ?? DBNull.Value);
        command.Parameters.AddWithValue("@city", (object)client.City ?? DBNull.Value);
        command.Parameters.AddWithValue("@province", client.Province);
        command.Parameters.AddWithValue("@postalCode", (object)client.PostalCode ?? DBNull.Value);
        command.Parameters.AddWithValue("@ytdSales", client.YTDSales);
        command.Parameters.AddWithValue("@creditHold", client.IsCreditHold);
        command.Parameters.AddWithValue("@notes", (object)client.Notes ?? DBNull.Value);

        connection.Open();

        return command.ExecuteNonQuery();
    }

    public static bool ClientCodeExists(string clientCode)
    {
        string sql = $"""
                      SELECT COUNT(*) 
                      FROM {tableName}
                      WHERE ClientCode = @clientCode
                      """;

        using NpgsqlConnection connection = new(connectionString);
        using NpgsqlCommand command       = new(sql, connection);

        command.Parameters.AddWithValue("@clientCode", clientCode);

        connection.Open();

        int count = Convert.ToInt32(command.ExecuteScalar());

        return count > 0;
    }

    public static ProvinceList GetProvinces()
    {
        string sql = $"""
                      SELECT Abbreviation,
                             Name
                      FROM   Province
                      """;

        ProvinceList provinces            = new();
        using NpgsqlConnection connection = new(connectionString);
        using NpgsqlCommand command       = new(sql, connection);

        connection.Open();

        using NpgsqlDataReader reader = command.ExecuteReader();

        while (reader.Read())
        {
            provinces.Add(new Province
            {
                Abbreviation = reader["Abbreviation"] as string,
                Name         = reader["Name"] as string
            });
        }

        return provinces;
    }
}
