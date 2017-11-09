namespace AddressbookVersion3.UI
{
    partial class AddressView
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
            this.addressViewDataGrid = new System.Windows.Forms.DataGridView();
            this.addressBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.addressViewDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // addressViewDataGrid
            // 
            this.addressViewDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.addressViewDataGrid.Location = new System.Drawing.Point(2, 64);
            this.addressViewDataGrid.Name = "addressViewDataGrid";
            this.addressViewDataGrid.RowTemplate.Height = 24;
            this.addressViewDataGrid.Size = new System.Drawing.Size(751, 308);
            this.addressViewDataGrid.TabIndex = 0;
            // 
            // addressBindingSource
            // 
            this.addressBindingSource.DataSource = typeof(AddressbookVersion3.DataContext.Address);
            // 
            // AddressView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 376);
            this.Controls.Add(this.addressViewDataGrid);
            this.Name = "AddressView";
            this.Text = "AddressView";
            ((System.ComponentModel.ISupportInitialize)(this.addressViewDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView addressViewDataGrid;
        private System.Windows.Forms.BindingSource addressBindingSource;
    }
}