using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Net.Sockets;

namespace ProjectISM240
{
    public partial class EmailCollection : Form
    {
        public EmailCollection()
        {
            InitializeComponent();


        }

        OleDbConnection con = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0;Data Source=db_users ");
        OleDbConnection cmd = new OleDbConnection();
        OleDbDataAdapter da = new OleDbDataAdapter();

        private void EmailCollection_Load(object sender, EventArgs e)
        {

        }

        private TextBox GetTxtfirstname()
        {
            return firstnametextBox;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string firstname, lastname, dob, email,offer,password;
            firstname = firstnametextBox.Text;
            lastname = lastnametextBox.Text;
            email = emailtextBox.Text;
            dob = dobtextBox.Text;
            password = passwordtextBox.Text;
            if (offeremailcheckBox.Checked == true)
                offer = offeremailcheckBox.Text;
            MessageBox.Show("FirstName:" + firstname + "LastName:" + lastname + "\nDOB:" + dob + "\nMail ID:" + email + "\npassword" + password);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            firstnametextBox.Text = "";
            lastnametextBox.Text = "";
            emailtextBox.Text = "";
            dobtextBox.Text = "";
            passwordtextBox.Text = "";
        }
    }
}
