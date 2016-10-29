using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CIS209_PolymorphismDemo2
{
    public partial class Form1 : Form
    {
        // Global list declared
        List<Pet> petInventory;

        public Form1()
        {
            InitializeComponent();

            // Create the list
            petInventory = new List<Pet>();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbxName.Text != "")
            {
                if (cmbType.SelectedItem != null)
                {
                    if (cmbType.SelectedItem.ToString() == "Bird")
                    {
                        petInventory.Add(new Bird(tbxName.Text));
                        listBoxUpdate();
                    }
                    else if (cmbType.SelectedItem.ToString() == "Fish")
                    {
                        petInventory.Add(new Fish(tbxName.Text));
                        listBoxUpdate();
                    }
                    else
                        MessageBox.Show("Something went wrong!", "Pet Invenory",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("Please choose a type of pet.", "Pet Invenory",
                        MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
                MessageBox.Show("Please choose a name for your pet.", "Pet Invenory",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void listBoxUpdate()
        {
            // Clear the list box
            lbxInventory.Items.Clear();

            // Populate the list box from the list
            foreach (Pet item in petInventory)
            {
                string listItem = item.Name + "\t" + item.Type + "\t" + item.TimeStamp;
                lbxInventory.Items.Add(listItem);
            }
        }
    }
}
