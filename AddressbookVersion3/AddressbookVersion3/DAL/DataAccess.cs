using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using AddressbookVersion3.DataContext;
using AddressbookVersion3.View_Models;
using Contact = AddressbookVersion3.View_Models.Contact;

namespace AddressbookVersion3.DAL
{
    public class DataAccess
    {
        public BindingList<View_Models.Contact> GetContacts()
        {
            BindingList<Contact> contacts;


            using (var dataContext = new DataContext.AdressbookDataContext())
            {
                var contactQuery = from contact in dataContext.Contact
                                   join contactType in dataContext.ContactType on contact.Id equals contactType.ContactId

                                   select new View_Models.Contact()
                                   {
                                       Id = contact.Id,
                                       Name = contact.Name,
                                       Email = contact.Email,
                                       Telephone = contact.Telephone,
                                       ContactTypeString = contactType.ContactType1
                                   };
                contacts = new BindingList<Contact>(contactQuery.ToList());
            }
            return contacts;
        }

        public BindingList<View_Models.AddressModel> GetAddress()
        {
            BindingList<AddressModel> addresses;
            using (var dataContext = new DataContext.AdressbookDataContext())
            {
                var addressQuery = from address in dataContext.Address
                                   select new View_Models.AddressModel()
                                   {
                                       Id = address.Id,
                                       StreetAddress = address.StreetAddress,
                                       PostalCode = address.PostalCode,
                                       City = address.City
                                   };
                addresses = new BindingList<AddressModel>(addressQuery.ToList());
            }
            return addresses;
        }

        public void UpdateAddress(int addressId, string updateValue, string columnName)
        {
            using (var dataContext = new AdressbookDataContext())
            {
                var result = dataContext.Address.SingleOrDefault(x => x.Id == addressId);
                if (result != null)
                {
                    if (columnName == "StreetAddress")
                    {
                        result.StreetAddress = updateValue;
                    }
                    if (columnName == "PostalCode")
                    {
                        result.PostalCode = updateValue;
                    }
                    if (columnName == "City")
                    {
                        result.City = updateValue;
                    }
                }
                dataContext.SaveChanges();
            }
        }

        public BindingList<Contact> SearchContacts(string name)
        {
            BindingList<Contact> returnList;
            using (var dataContext = new AdressbookDataContext())
            {
                var contacts = from contact in dataContext.Contact
                               where contact.Name.Contains(name)
                               join contactType in dataContext.ContactType on contact.Id equals contactType.ContactId

                               select new View_Models.Contact
                               {
                                   Id = contact.Id,
                                   Name = contact.Name,
                                   Email = contact.Email,
                                   Telephone = contact.Telephone,
                                   ContactTypeString = contactType.ContactType1

                               };
                List<Contact> contactResult = contacts.ToList();
                returnList = new BindingList<Contact>(contactResult);
            }
            return returnList;
        }

        public void CreateNewContact(Contact contact, AddressModel address, string contactType)
        {
            using (var dataContext = new DataContext.AdressbookDataContext())
            {
                var newContact = new DataContext.Contact();
                newContact.Name = contact.Name;
                newContact.Email = contact.Email;
                newContact.Telephone = contact.Telephone;

                var newAddress = new DataContext.Address();
                newAddress.StreetAddress = address.StreetAddress;
                newAddress.City = address.City;
                newAddress.PostalCode = address.PostalCode;

                var contactId = newContact.Id;
                var newContactType = new DataContext.ContactType();
                newContactType.ContactType1 = contactType;
                newContactType.ContactId = contactId;

                var newAddressContactLink = new DataContext.AddressContactLink();
                newAddressContactLink.ContactId = newContact.Id;
                newAddressContactLink.AddressId = newAddress.Id;

                dataContext.Contact.Add(newContact);
                dataContext.Address.Add(newAddress);
                dataContext.ContactType.Add(newContactType);
                dataContext.AddressContactLink.Add(newAddressContactLink);
                dataContext.SaveChanges();
            }
        }

        public void DeleteContact(int addressId)
        {
            using (var dataContext = new AdressbookDataContext())
            {
                var deleteAddress = dataContext.Address.SingleOrDefault(x => x.Id == addressId);

                if (deleteAddress != null)
                {
                    dataContext.Address.Remove(deleteAddress);
                }
                dataContext.SaveChanges();
            }

        }
    }
}
