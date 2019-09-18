using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinDwosForm
{
    public partial class Coffee : Form
    {
        const int arraySize = 100;
        List<string> CustomerName = new List<string> {};
        List <string> CustomerContact = new List<string> {};
        List <string> CustomerAddress = new List<string> {};
        List <string> Order = new List<string> {};
        List <int> Quantity = new List<int> {};
        List <double> Price = new List<double> {};
   
        
        public Coffee()
        {
            InitializeComponent();
          
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (!CustomerContact.Contains(contactTextBox.Text))
            {
                if (!String.IsNullOrEmpty(comboBoxItem.Text))
                {

                    if (quantityTextBox.Text !="")
                    {
                        showRichTextBox.Clear();
                        CustomerName.Add(nameTextBox.Text);
                        CustomerContact.Add(contactTextBox.Text);
                        CustomerAddress.Add(addressTextBox.Text);
                        Order.Add(comboBoxItem.Text);

                        Quantity.Add(Convert.ToInt32(quantityTextBox.Text));

                        Price.Add (Convert.ToInt32(quantityTextBox.Text) * Count(comboBoxItem.Text));

                        showRichTextBox.Text = "Information: "+"\n" + "\n Name: " + nameTextBox.Text + "\n Contract No: " + contactTextBox.Text + "\n Address: " +
                        addressTextBox.Text + "\n Order: " + comboBoxItem.Text + "\n Quantity: "+ "\n Total Price: " +
                        Count(comboBoxItem.Text) + "\n \n";
                    }
                    else
                    {
                        MessageBox.Show("What is your Quantity");
                    }

                }

                else
                {
                    MessageBox.Show("Please Select Your Item");
                }


            }

            else
            {
                MessageBox.Show("Already Exist");
            }
                
        }

        private double Count(string item)
        {
            if (item == "Black")
            {
                return 120;
            }
            else if (item == "Cold")
            {
                return 100;
            }
            else if (item == "Hot")
            {
                return 90;
            }
            else if (item == "Regular")
            {
                return 80;
            }
            else
            {
                return 0;
            }
        }

        private void Information()
        {
            showRichTextBox.Clear();
        
            for (int i = 0; i < CustomerName.Count(); i++)
            {
                showRichTextBox.Text += "Information: " + "\n"+ "Name: " + CustomerName[i] + "\nContract No: " + CustomerContact[i] + "\nAddress: " +
                           CustomerAddress[i] + "\nOrder: " + Order[i] + "\nQuantity: " + Quantity[i] + "\nTotal Price: " + Price[i] + "\n \n";


            }
        }

        private void showButtonClick_Click(object sender, EventArgs e)
        {
            Information();
        }
    }
}