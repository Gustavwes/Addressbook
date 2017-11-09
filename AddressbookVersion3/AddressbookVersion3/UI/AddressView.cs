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

        private void addressViewDataGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var newValue = addressViewDataGrid[e.ColumnIndex, e.RowIndex].Value;
            var columnName = addressViewDataGrid.Columns[e.ColumnIndex].HeaderText;
            var addressId = addressViewDataGrid[0, e.RowIndex].Value;

            DataAccess dataAccess = new DataAccess();
            dataAccess.UpdateAddress(Convert.ToInt32(addressId),newValue.ToString(),columnName);
        }

        private void DeleteRowButton_Click(object sender, EventArgs e)
        {
            //delete funktioner, behöver plocka ut row Id
        }
    }
}
