using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AddressbookVersion3.DAL;

namespace AddressbookVersion3
{
    public partial class Addressbook : Form
    {
        public Addressbook()
        {
            InitializeComponent();
            GetAllContacts();
            AddTypeOfContactsToComboBox();
        }

        public void GetAllContacts()
        {
           DataAccess dataAccess = new DataAccess();
            var contacts = dataAccess.GetContacts();
            AddressbookDataGridView.DataSource = contacts;
        }

        private void CreateNewContactButton_Click(object sender, EventArgs e)
        {
            DataAccess dataAccess = new DataAccess();
            var sendContact = new View_Models.Contact();
            sendContact.Name = NameTextBox.Text;
            sendContact.Email = EmailTextBox.Text;
            sendContact.Telephone = TelephoneTextBox.Text;

            var sendAddress = new View_Models.AddressModel();
            sendAddress.StreetAddress = StreetAddressTextBox.Text;
            sendAddress.PostalCode = PostalCodeTextBox.Text;
            sendAddress.City = CityTextBox.Text;
            var sendTypeContact = ContactTypeComboBox.SelectedItem.ToString();

            //var sendTypeContact = new View_Models.ContactTypeModel();
            //var maxContactsId = dataAccess.GetContacts().Max(x=>x.Id);
            //sendTypeContact.ContactId = maxContactsId;

            //var sendACLink = new View_Models.AddressContactLinkModel();
            //var maxAddressId = dataAccess.g
            //sendACLink.AddressId = 

            dataAccess.CreateNewContact(sendContact,sendAddress,sendTypeContact);
            GetAllContacts();
        }
        private void AddTypeOfContactsToComboBox()
        {
            ContactTypeComboBox.Items.Add("Jobb Kontakt");
            ContactTypeComboBox.Items.Add("Personlig Kontakt");
            ContactTypeComboBox.Items.Add("Övrig Kontakt");
        }

        private void ShowAddressListButton_Click(object sender, EventArgs e)
        {
            //AddressView addressView = new AddressView();
            //addressView.Show();public void GetAllAddresses()
            
               ShowAllAddresses();
            
        }

        private void AddressbookDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var newValue = AddressbookDataGridView[e.ColumnIndex, e.RowIndex].Value;
            var columnName = AddressbookDataGridView.Columns[e.ColumnIndex].HeaderText;
            var addressId = AddressbookDataGridView[0, e.RowIndex].Value;

            DataAccess dataAccess = new DataAccess();
            dataAccess.UpdateAddress(Convert.ToInt32(addressId), newValue.ToString(), columnName);
        }

        private void DeleteSelected_Click(object sender, EventArgs e)
        {
            DataAccess dataAccess = new DataAccess();
            //delete funktioner, behöver plocka ut row Id
            if (AddressbookDataGridView.SelectedRows.Count > 0)
            {
                for (int i = 0; i < AddressbookDataGridView.Rows.Count; i++)
                {
                    if (AddressbookDataGridView.Rows[i].Selected)
                    {
                        var addressId = AddressbookDataGridView[0, i].Value;
                        dataAccess.DeleteContact(Convert.ToInt32(addressId));
                    }

                }

            }
            ShowAllAddresses();
        }

        public void ShowAllAddresses()
        {
            DataAccess dataAccess = new DataAccess();
            var addresses = dataAccess.GetAddress();
            AddressbookDataGridView.DataSource = addresses;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            var nameSearch = NameTextBox.Text;

            var dataAccess = new DataAccess();

            var searchResults = dataAccess.SearchContacts(nameSearch);
            AddressbookDataGridView.DataSource = searchResults;
        }
    }
}
