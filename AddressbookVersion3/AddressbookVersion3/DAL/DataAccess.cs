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

        public BindingList<View_Models.Contact> GetContacts(int addressId)
        {
            BindingList<Contact> contacts;


            using (var dataContext = new DataContext.AdressbookDataContext())
            {
                var result = from link in dataContext.AddressContactLink
                              join address in dataContext.Address on link.AddressId equals addressId
                              join typeOfContact in dataContext.ContactType on link.ContactId equals typeOfContact.ContactId 
                              where address.Id == addressId

                              select new View_Models.Contact()
                              {
                                  Id = link.Id,
                                  Name = link.Contact.Name,
                                  Email = link.Contact.Email,
                                  Telephone = link.Contact.Telephone,
                                   ContactTypeString = typeOfContact.ContactType1
                              };
                contacts = new BindingList<Contact>(result.ToList());
            }
            return contacts;
        }

        public BindingList<View_Models.AddressContactLinkModel> GetAddressContactLinkModels()
        {
            BindingList<AddressContactLinkModel> links;
            using (var dataContext = new AdressbookDataContext())
            {
                var linkQuery = from AClink in dataContext.AddressContactLink
                                select new AddressContactLinkModel()
                                {
                                    AddressId = AClink.AddressId,
                                    ContactId = AClink.ContactId
                                };
                links = new BindingList<AddressContactLinkModel>(linkQuery.ToList());
            }
            return links;
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

        public BindingList<AddressModel> SearchContacts(string name, string postalCode, string contactType)
        {
            BindingList<AddressModel> returnList;

            using (var dataContext = new AdressbookDataContext())
            {
                var address = from contact in dataContext.AddressContactLink
                              join link in dataContext.ContactType on contact.ContactId equals link.ContactId
                              where contact.Contact.Name.Contains(name) &
                              contact.Address.PostalCode.Contains(postalCode) &
                              link.ContactType1.Contains(contactType)

                              select new AddressModel()
                              {
                                  Id = contact.Address.Id,
                                  StreetAddress = contact.Address.StreetAddress,
                                  PostalCode = contact.Address.PostalCode,
                                  City = contact.Address.City
                              };
                List<AddressModel> addressList = address.ToList();
                returnList = new BindingList<AddressModel>(addressList);
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
