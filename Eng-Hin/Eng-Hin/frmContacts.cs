using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Outlook = Microsoft.Office.Interop.Outlook;

namespace Eng_Hin
{
    public partial class frmContacts : Form
    {
        public frmContacts()
        {
            InitializeComponent();
        }

        private void frmContacts_Load(object sender, EventArgs e)
        {
            SearchforEmail("@");
        }

        private void SearchforEmail(string partialAddress)
        {
            Microsoft.Office.Interop.Outlook.Application objOutlook = new Microsoft.Office.Interop.Outlook.Application();
            Microsoft.Office.Interop.Outlook.MailItem mic = (Microsoft.Office.Interop.Outlook.MailItem)(objOutlook.CreateItem(Microsoft.Office.Interop.Outlook.OlItemType.olMailItem));

            string contactMessage = string.Empty;
            Microsoft.Office.Interop.Outlook.MAPIFolder contacts = (Microsoft.Office.Interop.Outlook.MAPIFolder)
                objOutlook.ActiveExplorer().Session.GetDefaultFolder
                 (Microsoft.Office.Interop.Outlook.OlDefaultFolders.olFolderContacts);
            foreach (Microsoft.Office.Interop.Outlook.ContactItem foundContact in contacts.Items)
            {
                if (foundContact.Email1Address.Contains(partialAddress))
                {
                    lstContacts.Items.Add(foundContact.Email1Address.ToString());

                    //contactMessage = contactMessage + "New contact"
                    //+ foundContact.FirstName + " " + foundContact.LastName
                    //+ " Email Address is " + foundContact.Email1Address +
                    //". \n";
                    
                }
            }
            if (!(contactMessage.Length > 0))
            {
                //contactMessage = "No Contacts were found.";
                //lblEmail.Text = string.Empty ;
            }
            //MessageBox.Show(contactMessage);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lstContacts.Items.Clear(); 
            SearchforEmail(txtSearchEmail.Text.Trim());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lstContacts.Text != string.Empty)
            {
                if (txtTo.Text != string.Empty)
                {
                    txtTo.Text = txtTo.Text + ";" + lstContacts.Text;
                }
                else
                {
                    txtTo.Text = lstContacts.Text;
                }                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (lstContacts.Text != string.Empty)
            {                

                if (txtCC.Text != string.Empty)
                {
                    txtCC.Text = txtCC.Text + ";" + lstContacts.Text;
                }
                else
                {
                    txtCC.Text = lstContacts.Text;
                }                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (lstContacts.Text != string.Empty)
            {               
                if (txtBcc.Text != string.Empty)
                {
                    txtBcc.Text = txtBcc.Text + ";" + lstContacts.Text;
                }
                else
                {
                    txtBcc.Text = lstContacts.Text;
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Globals.toAddress = txtTo.Text.Trim();
            Globals.ccAddress = txtCC.Text.Trim();
            Globals.bccAddress = txtBcc.Text.Trim();

            this.Close();
        }
    }
}