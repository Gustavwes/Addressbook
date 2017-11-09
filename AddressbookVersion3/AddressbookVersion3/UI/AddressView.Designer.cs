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
            this.DeleteRowButton = new System.Windows.Forms.Button();
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
            this.addressViewDataGrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.addressViewDataGrid_CellEndEdit);
            // 
            // addressBindingSource
            // 
            this.addressBindingSource.DataSource = typeof(AddressbookVersion3.DataContext.Address);
            // 
            // DeleteRowButton
            // 
            this.DeleteRowButton.Location = new System.Drawing.Point(535, 29);
            this.DeleteRowButton.Name = "DeleteRowButton";
            this.DeleteRowButton.Size = new System.Drawing.Size(110, 23);
            this.DeleteRowButton.TabIndex = 1;
            this.DeleteRowButton.Text = "Delete Row";
            this.DeleteRowButton.UseVisualStyleBackColor = true;
            this.DeleteRowButton.Click += new System.EventHandler(this.DeleteRowButton_Click);
            // 
            // AddressView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 376);
            this.Controls.Add(this.DeleteRowButton);
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
        private System.Windows.Forms.Button DeleteRowButton;
    }
}