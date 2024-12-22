using BusinessLib.Business;
using BusinessLib.Common;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientApplication.Forms;
public partial class ClientDialog : Form
{
    private ClientViewModel clientVM;
    private bool isEditMode;

    public ClientDialog()
    {
        InitializeComponent();
        clientVM   = new();
        isEditMode = false;
        this.Text  = "New Client Record";
    }

    public ClientDialog(Client client)
    {
        InitializeComponent();
        clientVM                  = new();
        clientVM.Client           = client;
        isEditMode                = true;
        textBoxClientCode.Enabled = false;
        this.Text                 = "Editing Client Record";
    }

    private void ClientDialog_Load(object sender, EventArgs e)
    {
        comboBoxProvince.DataSource    = clientVM.Provinces;
        comboBoxProvince.DisplayMember = "Name";
        comboBoxProvince.ValueMember   = "Abbreviation";

        setBindings();
    }

    private void setBindings()
    {
        textBoxClientCode.DataBindings.Add("Text", clientVM, "Client.ClientCode");

        textBoxCompanyName.DataBindings.Add("Text", clientVM, "Client.CompanyName");

        textBoxAddress1.DataBindings.Add("Text", clientVM, "Client.Address1");

        textBoxAddress2.DataBindings.Add("Text", clientVM, "Client.Address2");

        textBoxCity.DataBindings.Add("Text", clientVM, "Client.City");

        textBoxPostalCode.DataBindings.Add("Text", clientVM, "Client.PostalCode");

        textBoxYTDSales.DataBindings.Add("Text", clientVM, "Client.YTDSales",
                                          true, DataSourceUpdateMode.OnValidation,
                                          "0.00", "#,##0.00");

        checkBoxCreditHold.DataBindings.Add("Checked", clientVM, "Client.IsCreditHold");

        textBoxNotes.DataBindings.Add("Text", clientVM, "Client.Notes");

        comboBoxProvince.DataBindings.Add("SelectedValue", clientVM, "Client.Province");
    }

    private void buttonOk_Click(object sender, EventArgs e)
    {
        try
        {
            int rowsAffected;

            if (isEditMode)
            {
                rowsAffected = ClientValidation.UpdateClient(clientVM.Client);
            }

            else
            {
                rowsAffected = ClientValidation.AddClient(clientVM.Client);
            }

            if (rowsAffected < 0)
            {
                errorProvider.SetError(buttonOk, ClientValidation.ErrorMessage);
                return;
            }

            if (rowsAffected < 1)
            {
                errorProvider.SetError(buttonOk, "No database changes made.");
                return;
            }

            this.DialogResult = DialogResult.OK;
        }

        catch (PostgresException ex)
        {
            MessageBox.Show(ex.Message, "Data Access Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Processing Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void textBoxYTDSales_KeyPress(object sender, KeyPressEventArgs e)
    {
        TextBox ytdSales = sender as TextBox;

        e.Handled = (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
                    || (e.KeyChar == '.' && ytdSales.Text.Contains(e.KeyChar));
    }
}
