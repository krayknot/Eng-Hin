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
    public partial class frmNewMail : Form
    {
        public frmNewMail()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(-1);
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Outlook.Application objOutlook = new Microsoft.Office.Interop.Outlook.Application();
            Microsoft.Office.Interop.Outlook.MailItem mic = (Microsoft.Office.Interop.Outlook.MailItem)(objOutlook.CreateItem(Microsoft.Office.Interop.Outlook.OlItemType.olMailItem));

            mic.To = txtTo.Text ;
            mic.CC = txtCC.Text  ;
            //mic.BCC = "bcc";

            mic.Subject = txtSubject.Text;
            mic.HTMLBody = txtBody.Text;  

//            mic.SaveAs(@"C:\demo.msg", Microsoft.Office.Interop.Outlook.OlSaveAsType.olMSG);
            mic.Send();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

        }

        private void btnEmail_Click(object sender, EventArgs e)
        {
            frmContacts frmcontacts = new frmContacts();
            frmcontacts.ShowDialog();

            txtTo.Text =  Globals.toAddress ;
            txtCC.Text = Globals.ccAddress;
            txtBcc.Text = Globals.bccAddress ; 
        }        

        private void txtTo_TextChanged(object sender, EventArgs e)
        {
    
        }

       

    }
}