using BusinessLib.Business;
using BusinessLib.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ClientApplication;
internal class ClientViewModel : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler PropertyChanged;

    protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    public ClientViewModel()
    {
        try
        {
            RefreshClientListFromDb();
            GetProvinceList();
            this.Client = new Client();
        }

        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Environment.Exit(1);
        }
    }

    public ClientList Clients { get; private set; }
    public ProvinceList Provinces { get; private set; }

    public void RefreshClientListFromDb() => Clients   = ClientValidation.GetClients();
    public void GetProvinceList()         => Provinces = ClientValidation.GetProvinces();

    private Client client;

    public Client Client
    {
        get { return client; }
        set
        {
            client = value;
            OnPropertyChanged();
        }
    }
}
