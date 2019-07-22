using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShop
{
    public partial class CoffeeShop : Form
    {
        public CoffeeShop()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            
            string customerName = CustomerNameTextBox.Text;
            string contactNo = ContactNoTextBox.Text;
            string adress = AddressTextBox.Text;
            string order = itemComboBox.Text;
            string quantity = QuantityTextBox.Text;

            RichTextBox.Text = ("Coffee Shop Details");
            RichTextBox.Text = ("--------------------------------");
            RichTextBox.Text = ("--------------------------------");
            RichTextBox.Text=("Coffee Shop Details"+ "\n" +"------------------------------------"+ "\n"+"------------------------------------" +
                              "\n"+ "Customer Name: " + customerName + "\n" + "Contact No: " + contactNo +
                            "\n"+ "Address: " + adress +"\n" + "Order" + order + 
                            "\n" + "Quantity" + quantity);
        }
    }
}
