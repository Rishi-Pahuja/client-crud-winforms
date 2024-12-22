namespace ClientApplication;

partial class MainForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
        dataGridViewClients = new DataGridView();
        checkBoxConfirmDelete = new CheckBox();
        buttonAdd = new Button();
        buttonEdit = new Button();
        buttonDelete = new Button();
        labelGrid = new Label();
        ((System.ComponentModel.ISupportInitialize)dataGridViewClients).BeginInit();
        SuspendLayout();
        // 
        // dataGridViewClients
        // 
        dataGridViewClients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridViewClients.Location = new Point(12, 14);
        dataGridViewClients.Name = "dataGridViewClients";
        dataGridViewClients.RowTemplate.Height = 25;
        dataGridViewClients.Size = new Size(1143, 440);
        dataGridViewClients.TabIndex = 1;
        // 
        // checkBoxConfirmDelete
        // 
        checkBoxConfirmDelete.AutoSize = true;
        checkBoxConfirmDelete.Checked = true;
        checkBoxConfirmDelete.CheckState = CheckState.Checked;
        checkBoxConfirmDelete.Location = new Point(12, 515);
        checkBoxConfirmDelete.Name = "checkBoxConfirmDelete";
        checkBoxConfirmDelete.Size = new Size(120, 23);
        checkBoxConfirmDelete.TabIndex = 5;
        checkBoxConfirmDelete.TabStop = false;
        checkBoxConfirmDelete.Text = "Confirm Delete";
        checkBoxConfirmDelete.UseVisualStyleBackColor = true;
        // 
        // buttonAdd
        // 
        buttonAdd.Location = new Point(771, 512);
        buttonAdd.Name = "buttonAdd";
        buttonAdd.Size = new Size(110, 27);
        buttonAdd.TabIndex = 2;
        buttonAdd.Text = "&Add Client";
        buttonAdd.UseVisualStyleBackColor = true;
        buttonAdd.Click += buttonAdd_Click;
        // 
        // buttonEdit
        // 
        buttonEdit.Location = new Point(908, 512);
        buttonEdit.Name = "buttonEdit";
        buttonEdit.Size = new Size(110, 27);
        buttonEdit.TabIndex = 3;
        buttonEdit.Text = "&Edit Client";
        buttonEdit.UseVisualStyleBackColor = true;
        buttonEdit.Click += buttonEdit_Click;
        // 
        // buttonDelete
        // 
        buttonDelete.Location = new Point(1045, 512);
        buttonDelete.Name = "buttonDelete";
        buttonDelete.Size = new Size(110, 27);
        buttonDelete.TabIndex = 4;
        buttonDelete.Text = "&Delete Client";
        buttonDelete.UseVisualStyleBackColor = true;
        buttonDelete.Click += buttonDelete_Click;
        // 
        // labelGrid
        // 
        labelGrid.AutoSize = true;
        labelGrid.Location = new Point(149, 89);
        labelGrid.Name = "labelGrid";
        labelGrid.Size = new Size(45, 19);
        labelGrid.TabIndex = 0;
        labelGrid.Text = "label1";
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(7F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1167, 550);
        Controls.Add(buttonDelete);
        Controls.Add(buttonEdit);
        Controls.Add(buttonAdd);
        Controls.Add(checkBoxConfirmDelete);
        Controls.Add(dataGridViewClients);
        Controls.Add(labelGrid);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Icon = (Icon)resources.GetObject("$this.Icon");
        MaximizeBox = false;
        Name = "MainForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Client Application";
        Load += MainForm_Load;
        ((System.ComponentModel.ISupportInitialize)dataGridViewClients).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private DataGridView dataGridViewClients;
    private CheckBox checkBoxConfirmDelete;
    private Button buttonAdd;
    private Button buttonEdit;
    private Button buttonDelete;
    private Label labelGrid;
}
