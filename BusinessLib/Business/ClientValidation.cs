using BusinessLib.Common;
using BusinessLib.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BusinessLib.Business;
public class ClientValidation
{
    private static List<string> errors = new();
    private static bool isEdit;

    public static string ErrorMessage
    {
        get
        {
            StringBuilder sb = new();

            foreach (string error in errors)
            {
                sb.AppendLine(error);
            }

            return sb.ToString();
        }
    }

    public static int AddClient(Client client)
    {
        isEdit = false;

        return validate(client) ? ClientRepository.AddClient(client) : -1;
    }

    public static int UpdateClient(Client client)
    {
        isEdit = true;

        return validate(client) ? ClientRepository.UpdateClient(client) : -1;
    }

    public static ClientList GetClients()                  => ClientRepository.GetClients();
    public static ProvinceList GetProvinces()              => ClientRepository.GetProvinces();
    public static int DeleteClient(Client client)          => ClientRepository.DeleteClient(client);
    public static bool ClientCodeExists(string clientCode) => ClientRepository.ClientCodeExists(clientCode);

    private static bool validate(Client client)
    {
        bool result = true;
        errors.Clear();

        if (string.IsNullOrWhiteSpace(client.ClientCode) || client.ClientCode.Length > 5)
        {
            errors.Add("Client Code cannot be null or empty, must be less than 5 characters.");
            result = false;
        }

        if (!isEdit)
        {
            if (client.ClientCode != null && ClientCodeExists(client.ClientCode))
            {
                errors.Add("This client code already exists in DB. Client code must be unique.");
                result = false;
            }
        }

        if (string.IsNullOrWhiteSpace(client.CompanyName))
        {
            errors.Add("Company Name cannot be empty.");
            result = false;
        }

        if (string.IsNullOrWhiteSpace(client.Address1))
        {
            errors.Add("Address1 cannot be empty.");
            result = false;
        }

        if (string.IsNullOrWhiteSpace(client.Province))
        {
            errors.Add("Province cannot be empty.");
            result = false;
        }

        string regExCdnPostalCode = @"^[A-Z]\d[A-Z] \d[A-Z]\d$";

        if (!string.IsNullOrWhiteSpace(client.PostalCode) && !Regex.IsMatch(client.PostalCode, regExCdnPostalCode))
        {
            errors.Add("Postal Code must be in the format A9A 9A9");
            result = false;
        }

        return result;
    }
}
