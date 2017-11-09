﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AddressbookVersion3.DAL;

namespace AddressbookVersion3.UI
{
    public partial class AddressView : Form
    {
        public AddressView()
        {
            InitializeComponent();
            GetAllAddresses();
        }
        public void GetAllAddresses()
        {
            DataAccess dataAccess = new DataAccess();
            var addresses = dataAccess.GetAddress();
            addressViewDataGrid.DataSource = addresses;
        }

        
    }
}
