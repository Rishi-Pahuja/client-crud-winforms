namespace ClientApplication.Forms;

partial class ClientDialog
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        labelClientCode = new Label();
        textBoxClientCode = new TextBox();
        labelCompanyName = new Label();
        textBoxCompanyName = new TextBox();
        labelAddress1 = new Label();
        textBoxAddress1 = new TextBox();
        labelAddress2 = new Label();
        textBoxAddress2 = new TextBox();
        labelCity = new Label();
        textBoxCity = new TextBox();
        labelProvince = new Label();
        comboBoxProvince = new ComboBox();
        labelPostalCode = new Label();
        textBoxPostalCode = new TextBox();
        labelYTDSales = new Label();
        textBoxYTDSales = new TextBox();
        labelNotes = new Label();
        textBoxNotes = new TextBox();
        checkBoxCreditHold = new CheckBox();
        buttonOk = new Button();
        buttonCancel = new Button();
        errorProvider = new ErrorProvider(components);
        ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
        SuspendLayout();
        // 
        // labelClientCode
        // 
        labelClientCode.AutoSize = true;
        labelClientCode.Location = new Point(22, 22);
        labelClientCode.Name = "labelClientCode";
        labelClientCode.Size = new Size(83, 19);
        labelClientCode.TabIndex = 0;
        labelClientCode.Text = "Client Co&de:";
        // 
        // textBoxClientCode
        // 
        textBoxClientCode.CharacterCasing = CharacterCasing.Upper;
        textBoxClientCode.Location = new Point(175, 19);
        textBoxClientCode.Name = "textBoxClientCode";
        textBoxClientCode.Size = new Size(164, 25);
        textBoxClientCode.TabIndex = 1;
        // 
        // labelCompanyName
        // 
        labelCompanyName.AutoSize = true;
        labelCompanyName.Location = new Point(22, 67);
        labelCompanyName.Name = "labelCompanyName";
        labelCompanyName.Size = new Size(111, 19);
        labelCompanyName.TabIndex = 2;
        labelCompanyName.Text = "Company &Name:";
        // 
        // textBoxCompanyName
        // 
        textBoxCompanyName.Location = new Point(175, 64);
        textBoxCompanyName.Name = "textBoxCompanyName";
        textBoxCompanyName.Size = new Size(262, 25);
        textBoxCompanyName.TabIndex = 3;
        // 
        // labelAddress1
        // 
        labelAddress1.AutoSize = true;
        labelAddress1.Location = new Point(22, 112);
        labelAddress1.Name = "labelAddress1";
        labelAddress1.Size = new Size(69, 19);
        labelAddress1.TabIndex = 4;
        labelAddress1.Text = "&Address1:";
        // 
        // textBoxAddress1
        // 
        textBoxAddress1.Location = new Point(175, 109);
        textBoxAddress1.Name = "textBoxAddress1";
        textBoxAddress1.Size = new Size(164, 25);
        textBoxAddress1.TabIndex = 5;
        // 
        // labelAddress2
        // 
        labelAddress2.AutoSize = true;
        labelAddress2.Location = new Point(22, 157);
        labelAddress2.Name = "labelAddress2";
        labelAddress2.Size = new Size(69, 19);
        labelAddress2.TabIndex = 6;
        labelAddress2.Text = "Add&ress2:";
        // 
        // textBoxAddress2
        // 
        textBoxAddress2.Location = new Point(175, 154);
        textBoxAddress2.Name = "textBoxAddress2";
        textBoxAddress2.Size = new Size(164, 25);
        textBoxAddress2.TabIndex = 7;
        // 
        // labelCity
        // 
        labelCity.AutoSize = true;
        labelCity.Location = new Point(22, 202);
        labelCity.Name = "labelCity";
        labelCity.Size = new Size(36, 19);
        labelCity.TabIndex = 8;
        labelCity.Text = "Cit&y:";
        // 
        // textBoxCity
        // 
        textBoxCity.Location = new Point(175, 199);
        textBoxCity.Name = "textBoxCity";
        textBoxCity.Size = new Size(164, 25);
        textBoxCity.TabIndex = 9;
        // 
        // labelProvince
        // 
        labelProvince.AutoSize = true;
        labelProvince.Location = new Point(22, 247);
        labelProvince.Name = "labelProvince";
        labelProvince.Size = new Size(64, 19);
        labelProvince.TabIndex = 10;
        labelProvince.Text = "&Province:";
        // 
        // comboBoxProvince
        // 
        comboBoxProvince.DropDownStyle = ComboBoxStyle.DropDownList;
        comboBoxProvince.FormattingEnabled = true;
        comboBoxProvince.Location = new Point(175, 244);
        comboBoxProvince.Name = "comboBoxProvince";
        comboBoxProvince.Size = new Size(164, 25);
        comboBoxProvince.TabIndex = 11;
        // 
        // labelPostalCode
        // 
        labelPostalCode.AutoSize = true;
        labelPostalCode.Location = new Point(22, 292);
        labelPostalCode.Name = "labelPostalCode";
        labelPostalCode.Size = new Size(84, 19);
        labelPostalCode.TabIndex = 12;
        labelPostalCode.Text = "Po&stal Code:";
        // 
        // textBoxPostalCode
        // 
        textBoxPostalCode.CharacterCasing = CharacterCasing.Upper;
        textBoxPostalCode.Location = new Point(175, 289);
        textBoxPostalCode.Name = "textBoxPostalCode";
        textBoxPostalCode.Size = new Size(164, 25);
        textBoxPostalCode.TabIndex = 13;
        // 
        // labelYTDSales
        // 
        labelYTDSales.AutoSize = true;
        labelYTDSales.Location = new Point(22, 337);
        labelYTDSales.Name = "labelYTDSales";
        labelYTDSales.Size = new Size(71, 19);
        labelYTDSales.TabIndex = 14;
        labelYTDSales.Text = "YTD Sa&les:";
        // 
        // textBoxYTDSales
        // 
        textBoxYTDSales.Location = new Point(175, 334);
        textBoxYTDSales.Name = "textBoxYTDSales";
        textBoxYTDSales.Size = new Size(164, 25);
        textBoxYTDSales.TabIndex = 15;
        textBoxYTDSales.KeyPress += textBoxYTDSales_KeyPress;
        // 
        // labelNotes
        // 
        labelNotes.AutoSize = true;
        labelNotes.Location = new Point(22, 382);
        labelNotes.Name = "labelNotes";
        labelNotes.Size = new Size(48, 19);
        labelNotes.TabIndex = 16;
        labelNotes.Text = "No&tes:";
        // 
        // textBoxNotes
        // 
        textBoxNotes.Location = new Point(175, 379);
        textBoxNotes.Multiline = true;
        textBoxNotes.Name = "textBoxNotes";
        textBoxNotes.Size = new Size(262, 87);
        textBoxNotes.TabIndex = 17;
        // 
        // checkBoxCreditHold
        // 
        checkBoxCreditHold.AutoSize = true;
        checkBoxCreditHold.Location = new Point(175, 488);
        checkBoxCreditHold.Name = "checkBoxCreditHold";
        checkBoxCreditHold.Size = new Size(98, 23);
        checkBoxCreditHold.TabIndex = 18;
        checkBoxCreditHold.TabStop = false;
        checkBoxCreditHold.Text = "Credit &Hold";
        checkBoxCreditHold.UseVisualStyleBackColor = true;
        // 
        // buttonOk
        // 
        buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        errorProvider.SetIconAlignment(buttonOk, ErrorIconAlignment.MiddleLeft);
        errorProvider.SetIconPadding(buttonOk, 10);
        buttonOk.Location = new Point(376, 554);
        buttonOk.Name = "buttonOk";
        buttonOk.Size = new Size(75, 26);
        buttonOk.TabIndex = 19;
        buttonOk.Text = "&OK";
        buttonOk.UseVisualStyleBackColor = true;
        buttonOk.Click += buttonOk_Click;
        // 
        // buttonCancel
        // 
        buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        buttonCancel.Location = new Point(470, 554);
        buttonCancel.Name = "buttonCancel";
        buttonCancel.Size = new Size(75, 26);
        buttonCancel.TabIndex = 20;
        buttonCancel.Text = "&Cancel";
        buttonCancel.UseVisualStyleBackColor = true;
        // 
        // errorProvider
        // 
        errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
        errorProvider.ContainerControl = this;
        // 
        // ClientDialog
        // 
        AcceptButton = buttonOk;
        AutoScaleDimensions = new SizeF(7F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        CancelButton = buttonCancel;
        ClientSize = new Size(557, 592);
        Controls.Add(buttonCancel);
        Controls.Add(buttonOk);
        Controls.Add(checkBoxCreditHold);
        Controls.Add(textBoxNotes);
        Controls.Add(labelNotes);
        Controls.Add(textBoxYTDSales);
        Controls.Add(labelYTDSales);
        Controls.Add(textBoxPostalCode);
        Controls.Add(labelPostalCode);
        Controls.Add(comboBoxProvince);
        Controls.Add(labelProvince);
        Controls.Add(textBoxCity);
        Controls.Add(labelCity);
        Controls.Add(textBoxAddress2);
        Controls.Add(labelAddress2);
        Controls.Add(textBoxAddress1);
        Controls.Add(labelAddress1);
        Controls.Add(textBoxCompanyName);
        Controls.Add(labelCompanyName);
        Controls.Add(textBoxClientCode);
        Controls.Add(labelClientCode);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "ClientDialog";
        ShowInTaskbar = false;
        StartPosition = FormStartPosition.CenterParent;
        Text = "ClientDialog";
        Load += ClientDialog_Load;
        ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label labelClientCode;
    private TextBox textBoxClientCode;
    private Label labelCompanyName;
    private TextBox textBoxCompanyName;
    private Label labelAddress1;
    private TextBox textBoxAddress1;
    private Label labelAddress2;
    private TextBox textBoxAddress2;
    private Label labelCity;
    private TextBox textBoxCity;
    private Label labelProvince;
    private ComboBox comboBoxProvince;
    private Label labelPostalCode;
    private TextBox textBoxPostalCode;
    private Label labelYTDSales;
    private TextBox textBoxYTDSales;
    private Label labelNotes;
    private TextBox textBoxNotes;
    private CheckBox checkBoxCreditHold;
    private Button buttonOk;
    private Button buttonCancel;
    private ErrorProvider errorProvider;
}