namespace AddressbookVersion3
{
    partial class Addressbook
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
            this.components = new System.ComponentModel.Container();
            this.AddressbookDataGridView = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.CreateNewContactButton = new System.Windows.Forms.Button();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.TelephoneLabel = new System.Windows.Forms.Label();
            this.StreetAdressLabel = new System.Windows.Forms.Label();
            this.Postalcodelabel = new System.Windows.Forms.Label();
            this.CityLabel = new System.Windows.Forms.Label();
            this.ContactTypeLabel = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.TelephoneTextBox = new System.Windows.Forms.TextBox();
            this.StreetAddressTextBox = new System.Windows.Forms.TextBox();
            this.PostalCodeTextBox = new System.Windows.Forms.TextBox();
            this.CityTextBox = new System.Windows.Forms.TextBox();
            this.ContactTypeComboBox = new System.Windows.Forms.ComboBox();
            this.ShowAddressListButton = new System.Windows.Forms.Button();
            this.contactBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.contactBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.contactBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.contactBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DeleteSelected = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AddressbookDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // AddressbookDataGridView
            // 
            this.AddressbookDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AddressbookDataGridView.Location = new System.Drawing.Point(319, 184);
            this.AddressbookDataGridView.Name = "AddressbookDataGridView";
            this.AddressbookDataGridView.RowTemplate.Height = 24;
            this.AddressbookDataGridView.Size = new System.Drawing.Size(734, 203);
            this.AddressbookDataGridView.TabIndex = 0;
            this.AddressbookDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.AddressbookDataGridView_CellEndEdit);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1106, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // CreateNewContactButton
            // 
            this.CreateNewContactButton.Location = new System.Drawing.Point(917, 40);
            this.CreateNewContactButton.Name = "CreateNewContactButton";
            this.CreateNewContactButton.Size = new System.Drawing.Size(75, 23);
            this.CreateNewContactButton.TabIndex = 2;
            this.CreateNewContactButton.Text = "Create New Contact";
            this.CreateNewContactButton.UseVisualStyleBackColor = true;
            this.CreateNewContactButton.Click += new System.EventHandler(this.CreateNewContactButton_Click);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(36, 40);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(156, 22);
            this.NameTextBox.TabIndex = 3;
            this.NameTextBox.Text = "Name";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(33, 13);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(45, 17);
            this.NameLabel.TabIndex = 4;
            this.NameLabel.Text = "Name";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(33, 69);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(42, 17);
            this.EmailLabel.TabIndex = 5;
            this.EmailLabel.Text = "Email";
            // 
            // TelephoneLabel
            // 
            this.TelephoneLabel.AutoSize = true;
            this.TelephoneLabel.Location = new System.Drawing.Point(33, 112);
            this.TelephoneLabel.Name = "TelephoneLabel";
            this.TelephoneLabel.Size = new System.Drawing.Size(130, 17);
            this.TelephoneLabel.TabIndex = 6;
            this.TelephoneLabel.Text = "Telephone Number";
            // 
            // StreetAdressLabel
            // 
            this.StreetAdressLabel.AutoSize = true;
            this.StreetAdressLabel.Location = new System.Drawing.Point(33, 161);
            this.StreetAdressLabel.Name = "StreetAdressLabel";
            this.StreetAdressLabel.Size = new System.Drawing.Size(102, 17);
            this.StreetAdressLabel.TabIndex = 7;
            this.StreetAdressLabel.Text = "Street Address";
            // 
            // Postalcodelabel
            // 
            this.Postalcodelabel.AutoSize = true;
            this.Postalcodelabel.Location = new System.Drawing.Point(36, 204);
            this.Postalcodelabel.Name = "Postalcodelabel";
            this.Postalcodelabel.Size = new System.Drawing.Size(84, 17);
            this.Postalcodelabel.TabIndex = 8;
            this.Postalcodelabel.Text = "Postal Code";
            // 
            // CityLabel
            // 
            this.CityLabel.AutoSize = true;
            this.CityLabel.Location = new System.Drawing.Point(36, 252);
            this.CityLabel.Name = "CityLabel";
            this.CityLabel.Size = new System.Drawing.Size(31, 17);
            this.CityLabel.TabIndex = 9;
            this.CityLabel.Text = "City";
            // 
            // ContactTypeLabel
            // 
            this.ContactTypeLabel.AutoSize = true;
            this.ContactTypeLabel.Location = new System.Drawing.Point(36, 297);
            this.ContactTypeLabel.Name = "ContactTypeLabel";
            this.ContactTypeLabel.Size = new System.Drawing.Size(92, 17);
            this.ContactTypeLabel.TabIndex = 10;
            this.ContactTypeLabel.Text = "Contact Type";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(36, 87);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(156, 22);
            this.EmailTextBox.TabIndex = 11;
            this.EmailTextBox.Text = "Email";
            // 
            // TelephoneTextBox
            // 
            this.TelephoneTextBox.Location = new System.Drawing.Point(36, 133);
            this.TelephoneTextBox.Name = "TelephoneTextBox";
            this.TelephoneTextBox.Size = new System.Drawing.Size(156, 22);
            this.TelephoneTextBox.TabIndex = 12;
            this.TelephoneTextBox.Text = "Telephone Number";
            // 
            // StreetAddressTextBox
            // 
            this.StreetAddressTextBox.Location = new System.Drawing.Point(36, 179);
            this.StreetAddressTextBox.Name = "StreetAddressTextBox";
            this.StreetAddressTextBox.Size = new System.Drawing.Size(156, 22);
            this.StreetAddressTextBox.TabIndex = 13;
            this.StreetAddressTextBox.Text = "Street Address";
            // 
            // PostalCodeTextBox
            // 
            this.PostalCodeTextBox.Location = new System.Drawing.Point(36, 225);
            this.PostalCodeTextBox.Name = "PostalCodeTextBox";
            this.PostalCodeTextBox.Size = new System.Drawing.Size(156, 22);
            this.PostalCodeTextBox.TabIndex = 14;
            this.PostalCodeTextBox.Text = "Postal Code";
            // 
            // CityTextBox
            // 
            this.CityTextBox.Location = new System.Drawing.Point(36, 272);
            this.CityTextBox.Name = "CityTextBox";
            this.CityTextBox.Size = new System.Drawing.Size(156, 22);
            this.CityTextBox.TabIndex = 15;
            this.CityTextBox.Text = "City";
            // 
            // ContactTypeComboBox
            // 
            this.ContactTypeComboBox.FormattingEnabled = true;
            this.ContactTypeComboBox.Location = new System.Drawing.Point(36, 318);
            this.ContactTypeComboBox.Name = "ContactTypeComboBox";
            this.ContactTypeComboBox.Size = new System.Drawing.Size(156, 24);
            this.ContactTypeComboBox.TabIndex = 16;
            // 
            // ShowAddressListButton
            // 
            this.ShowAddressListButton.Location = new System.Drawing.Point(685, 40);
            this.ShowAddressListButton.Name = "ShowAddressListButton";
            this.ShowAddressListButton.Size = new System.Drawing.Size(158, 36);
            this.ShowAddressListButton.TabIndex = 17;
            this.ShowAddressListButton.Text = "Show Address List";
            this.ShowAddressListButton.UseVisualStyleBackColor = true;
            this.ShowAddressListButton.Click += new System.EventHandler(this.ShowAddressListButton_Click);
            // 
            // contactBindingSource2
            // 
            this.contactBindingSource2.DataSource = typeof(AddressbookVersion3.View_Models.Contact);
            // 
            // contactBindingSource3
            // 
            this.contactBindingSource3.DataSource = typeof(AddressbookVersion3.View_Models.Contact);
            // 
            // contactBindingSource1
            // 
            this.contactBindingSource1.DataSource = typeof(AddressbookVersion3.View_Models.Contact);
            // 
            // contactBindingSource
            // 
            this.contactBindingSource.DataSource = typeof(AddressbookVersion3.DataContext.Contact);
            // 
            // DeleteSelected
            // 
            this.DeleteSelected.Location = new System.Drawing.Point(917, 87);
            this.DeleteSelected.Name = "DeleteSelected";
            this.DeleteSelected.Size = new System.Drawing.Size(75, 23);
            this.DeleteSelected.TabIndex = 18;
            this.DeleteSelected.Text = "Delete Selected";
            this.DeleteSelected.UseVisualStyleBackColor = true;
            this.DeleteSelected.Click += new System.EventHandler(this.DeleteSelected_Click);
            // 
            // Addressbook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 449);
            this.Controls.Add(this.DeleteSelected);
            this.Controls.Add(this.ShowAddressListButton);
            this.Controls.Add(this.ContactTypeComboBox);
            this.Controls.Add(this.CityTextBox);
            this.Controls.Add(this.PostalCodeTextBox);
            this.Controls.Add(this.StreetAddressTextBox);
            this.Controls.Add(this.TelephoneTextBox);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.ContactTypeLabel);
            this.Controls.Add(this.CityLabel);
            this.Controls.Add(this.Postalcodelabel);
            this.Controls.Add(this.StreetAdressLabel);
            this.Controls.Add(this.TelephoneLabel);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.CreateNewContactButton);
            this.Controls.Add(this.AddressbookDataGridView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Addressbook";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.AddressbookDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView AddressbookDataGridView;
        private System.Windows.Forms.BindingSource contactBindingSource;
        private System.Windows.Forms.BindingSource contactBindingSource1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button CreateNewContactButton;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label TelephoneLabel;
        private System.Windows.Forms.Label StreetAdressLabel;
        private System.Windows.Forms.Label Postalcodelabel;
        private System.Windows.Forms.Label CityLabel;
        private System.Windows.Forms.Label ContactTypeLabel;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.TextBox TelephoneTextBox;
        private System.Windows.Forms.TextBox StreetAddressTextBox;
        private System.Windows.Forms.TextBox PostalCodeTextBox;
        private System.Windows.Forms.TextBox CityTextBox;
        private System.Windows.Forms.ComboBox ContactTypeComboBox;
        private System.Windows.Forms.Button ShowAddressListButton;
        private System.Windows.Forms.BindingSource contactBindingSource3;
        private System.Windows.Forms.BindingSource contactBindingSource2;
        private System.Windows.Forms.Button DeleteSelected;
    }
}

