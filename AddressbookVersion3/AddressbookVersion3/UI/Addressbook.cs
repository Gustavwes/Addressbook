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
using AddressbookVersion3.UI;

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
            AddressView addressView = new AddressView();
            addressView.Show();
        }
    }
}
