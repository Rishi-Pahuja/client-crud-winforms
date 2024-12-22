using BusinessLib.Business;
using BusinessLib.Common;
using ClientApplication.Forms;

namespace ClientApplication;

public partial class MainForm : Form
{
    private ClientViewModel clientVM;

    public MainForm()
    {
        InitializeComponent();
        clientVM = new();
        setupDataGridView();
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
        dataGridViewClients.DataSource = clientVM.Clients;
    }

    private void setupDataGridView()
    {
        // Adjust row height
        dataGridViewClients.RowTemplate.Height = 30;

        // configure for readonly 
        dataGridViewClients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dataGridViewClients.MultiSelect = false;
        dataGridViewClients.AllowUserToAddRows = false;
        dataGridViewClients.EditMode = DataGridViewEditMode.EditProgrammatically;
        dataGridViewClients.AllowUserToOrderColumns = false;
        dataGridViewClients.AllowUserToResizeColumns = false;
        dataGridViewClients.AllowUserToResizeRows = false;
        dataGridViewClients.ColumnHeadersDefaultCellStyle.Font = new Font(DataGridView.DefaultFont, FontStyle.Bold);
        dataGridViewClients.RowHeadersVisible = false;
        dataGridViewClients.StandardTab = true;
        dataGridViewClients.AutoGenerateColumns = false;

        // add columns
        DataGridViewTextBoxColumn clientCode = new DataGridViewTextBoxColumn();
        clientCode.Name = "client";
        clientCode.DataPropertyName = "ClientCode";
        clientCode.HeaderText = "Client Code";
        clientCode.Width = 140;
        clientCode.SortMode = DataGridViewColumnSortMode.NotSortable;
        dataGridViewClients.Columns.Add(clientCode);

        DataGridViewTextBoxColumn companyName = new DataGridViewTextBoxColumn();
        companyName.Name = "companyName";
        companyName.DataPropertyName = "CompanyName";
        companyName.HeaderText = "Company Name";
        companyName.Width = 250;
        companyName.SortMode = DataGridViewColumnSortMode.NotSortable;
        dataGridViewClients.Columns.Add(companyName);

        DataGridViewTextBoxColumn address1 = new DataGridViewTextBoxColumn();
        address1.Name = "address1";
        address1.DataPropertyName = "Address1";
        address1.HeaderText = "Address1";
        address1.Width = 210;
        address1.SortMode = DataGridViewColumnSortMode.NotSortable;
        dataGridViewClients.Columns.Add(address1);

        DataGridViewTextBoxColumn address2 = new DataGridViewTextBoxColumn();
        address2.Name = "address2";
        address2.DataPropertyName = "Address2";
        address2.HeaderText = "Address2";
        address2.Width = 140;
        address2.SortMode = DataGridViewColumnSortMode.NotSortable;
        dataGridViewClients.Columns.Add(address2);

        DataGridViewTextBoxColumn city = new DataGridViewTextBoxColumn();
        city.Name = "city";
        city.DataPropertyName = "City";
        city.HeaderText = "City";
        city.Width = 210;
        city.SortMode = DataGridViewColumnSortMode.NotSortable;
        dataGridViewClients.Columns.Add(city);

        DataGridViewTextBoxColumn province = new DataGridViewTextBoxColumn();
        province.Name = "province";
        province.DataPropertyName = "Province";
        province.HeaderText = "Province";
        province.Width = 110;
        province.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        province.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        province.SortMode = DataGridViewColumnSortMode.NotSortable;
        dataGridViewClients.Columns.Add(province);

        DataGridViewTextBoxColumn postalCode = new DataGridViewTextBoxColumn();
        postalCode.Name = "postalCode";
        postalCode.DataPropertyName = "PostalCode";
        postalCode.HeaderText = "Postal Code";
        postalCode.Width = 140;
        postalCode.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        postalCode.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        postalCode.SortMode = DataGridViewColumnSortMode.NotSortable;
        dataGridViewClients.Columns.Add(postalCode);

        DataGridViewTextBoxColumn ytdSales = new DataGridViewTextBoxColumn();
        ytdSales.Name = "ytdSales";
        ytdSales.DataPropertyName = "YTDSales";
        ytdSales.HeaderText = "YTD Sales";
        ytdSales.Width = 160;
        ytdSales.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
        ytdSales.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        ytdSales.DefaultCellStyle.Format = "N2";
        ytdSales.SortMode = DataGridViewColumnSortMode.NotSortable;
        dataGridViewClients.Columns.Add(ytdSales);

        DataGridViewCheckBoxColumn creditHold = new DataGridViewCheckBoxColumn();
        creditHold.Name = "creditHold";
        creditHold.DataPropertyName = "IsCreditHold";
        creditHold.HeaderText = "Credit Hold";
        creditHold.Width = 140;
        creditHold.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        creditHold.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        creditHold.SortMode = DataGridViewColumnSortMode.NotSortable;
        dataGridViewClients.Columns.Add(creditHold);

        DataGridViewTextBoxColumn notes = new DataGridViewTextBoxColumn();
        notes.Name = "notes";
        notes.DataPropertyName = "Notes";
        notes.HeaderText = "Notes";
        notes.Width = 293;
        notes.SortMode = DataGridViewColumnSortMode.NotSortable;
        dataGridViewClients.Columns.Add(notes);
    }

    private void refreshGrid()
    {
        clientVM.RefreshClientListFromDb();
        dataGridViewClients.DataSource = clientVM.Clients;
    }

    private void buttonAdd_Click(object sender, EventArgs e)
    {
        ClientDialog dialog = new();
        dialog.ShowDialog();

        if (dialog.DialogResult == DialogResult.OK)
        {
            refreshGrid();
        }

        dialog.Dispose();
    }

    private void buttonEdit_Click(object sender, EventArgs e)
    {
        if (dataGridViewClients.CurrentRow != null)
        {
            int index     = dataGridViewClients.CurrentRow.Index;
            Client client = clientVM.Clients[index];

            Client clonedClient = new()
            {
                ClientCode   = client.ClientCode,
                CompanyName  = client.CompanyName,
                Address1     = client.Address1,
                Address2     = client.Address2,
                City         = client.City,
                Province     = client.Province,
                PostalCode   = client.PostalCode,
                YTDSales     = client.YTDSales,
                IsCreditHold = client.IsCreditHold,
                Notes        = client.Notes,
            };

            ClientDialog dialog = new ClientDialog(clonedClient);
            dialog.ShowDialog();

            if (dialog.DialogResult == DialogResult.OK)
            {
                refreshGrid();
            }

            dialog.Dispose();
        }

        else
        {
            MessageBox.Show("Please select a client to edit.", "No Client Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    private void buttonDelete_Click(object sender, EventArgs e)
    {
        if (dataGridViewClients.CurrentRow != null)
        {
            int index     = dataGridViewClients.CurrentRow.Index;
            Client client = clientVM.Clients[index];

            if (checkBoxConfirmDelete.Checked)
            {
                DialogResult result = MessageBox.Show($"Are you sure you want to delete Client Code: {client.ClientCode}?",
                                                       "Confirm Deletion", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (result != DialogResult.OK)
                {
                    return;
                }
            }

            int rowsAffected = ClientValidation.DeleteClient(client);

            if (rowsAffected > 0)
            {
                MessageBox.Show($"Client Code: {client.ClientCode} has been deleted.", "Deletion Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                refreshGrid();
            }

            else
            {
                MessageBox.Show($"Failed to delete Client Code: {client.ClientCode}.", "Deletion Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        else
        {
            MessageBox.Show("Client Table is Empty", "Empty Table", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
