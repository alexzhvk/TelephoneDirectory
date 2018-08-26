using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;


namespace Telephone_Directory
{
    public partial class editForm : Form
    {
        private DirectoryModelContainer DirectoryDB = new DirectoryModelContainer();
        string activetable;
        int currentId;
        public editForm(string active, int id)
        {
            this.activetable = active;
            this.currentId = id;
            InitializeComponent();
            switch (activetable)
            {
                case "Subscribers":
                    {
                        this.Width = 340;
                        editBtn.Width = 293;
                        propertyLabel1.Text = "Passport";
                        propertyLabel2.Text = "Full name";
                        propertyLabel3.Text = "Address";

                        var sub = DirectoryDB.SubscribersInfoSet.Find(currentId);
                        propTextBox1.Text = sub.PassportData;
                        propTextBox2.Text = sub.FullName;
                        propTextBox3.Text = sub.Address;
                        break;
                    }
                case "Operators":
                    {
                        this.Width = 340;
                        editBtn.Width = 293;
                        propertyLabel1.Text = "Name";
                        propertyLabel2.Text = "Code";
                        propertyLabel3.Text = "Amount";

                        var ops = DirectoryDB.OperatorsInfoSet.Find(currentId);
                        propTextBox1.Text = ops.Name;
                        propTextBox2.Text = ops.Code;
                        propTextBox3.Text = Convert.ToString(ops.AmountOfUsers);
                        break;
                    }
                case "Connections":
                    {
                        this.Width = 643;
                        editBtn.Width = 597;
                        propertyLabel1.Text = "Phone";
                        propertyLabel2.Text = "Arrear";
                        propertyLabel3.Text = "Tariff";
                        propertyLabel4.Text = "Date";
                        
                        var con = DirectoryDB.ConnectionsInfoSet.Find(currentId);
                        propTextBox1.Text = con.PhoneNumber;
                        propTextBox2.Text = Convert.ToString(con.Arrear);
                        propTextBox3.Text = con.Tariff;
                        propTextBox4.Text = Convert.ToString(con.InstallationDate);
                        break;
                    }
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                switch (activetable)
                {
                    case "Subscribers":
                        {
                            var sub = DirectoryDB.SubscribersInfoSet.Find(currentId);
                            sub.PassportData = propTextBox1.Text;
                            sub.FullName = propTextBox2.Text;
                            sub.Address = propTextBox3.Text;
                            DirectoryDB.Entry(sub).State = EntityState.Modified;
                            break;
                        }
                    case "Operators":
                        {
                            var ops = DirectoryDB.OperatorsInfoSet.Find(currentId);
                            ops.Name = propTextBox1.Text;
                            ops.Code = propTextBox2.Text;
                            ops.AmountOfUsers = Convert.ToInt32(propTextBox3.Text);
                            DirectoryDB.Entry(ops).State = EntityState.Modified;
                            break;
                        }
                    case "Connections":
                        {
                            var con = DirectoryDB.ConnectionsInfoSet.Find(currentId);
                            con.PhoneNumber = propTextBox1.Text;
                            con.Arrear = Convert.ToInt32(propTextBox2.Text);
                            con.Tariff = propTextBox3.Text;
                            con.InstallationDate = Convert.ToDateTime(propTextBox4.Text);
                            DirectoryDB.Entry(con).State = EntityState.Modified;
                            break;
                        }
                }
                DirectoryDB.SaveChanges();
                MessageBox.Show("Done", "Action", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
