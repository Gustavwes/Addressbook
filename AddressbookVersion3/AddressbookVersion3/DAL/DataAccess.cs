﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AddressbookVersion3.View_Models;

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

                    select new View_Models.Contact()
                    {
                        Id = contact.Id,
                        Name = contact.Name,
                        Email = contact.Email,
                        Telephone = contact.Telephone
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
    }
}