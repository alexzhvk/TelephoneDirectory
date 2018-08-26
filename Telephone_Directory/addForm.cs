using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telephone_Directory
{
    public partial class addForm : Form
    {
        private DirectoryModelContainer DirectoryDB = new DirectoryModelContainer();
        string activetable;
        public addForm(string active)
        {
            this.activetable = active;
            InitializeComponent();
            switch (activetable)
            {
                case "Subscribers":
                    {
                        this.Width = 340;
                        addBtn.Width = 293;
                        propertyLabel1.Text = "Passport";
                        propertyLabel2.Text = "Full name";
                        propertyLabel3.Text = "Address";
                        break;
                    }
                case "Operators":
                    {
                        this.Width = 340;
                        addBtn.Width = 293;
                        propertyLabel1.Text = "Name";
                        propertyLabel2.Text = "Code";
                        propertyLabel3.Text = "Amount";
                        break;
                    }
                case "Connections":
                    {
                        this.Width = 643;
                        addBtn.Width = 597;
                        propertyLabel1.Text = "Phone";
                        propertyLabel2.Text = "Arrear";
                        propertyLabel3.Text = "Tariff";
                        propertyLabel4.Text = "Date";
                        propertyLabel5.Text = "SubsId";
                        propertyLabel6.Text = "OpsId";

                        var subs = from subscriber in DirectoryDB.SubscribersInfoSet
                                   select subscriber.Id;
                        foreach (var item in subs)
                            propComboBox5.Items.Add(item);
                        ;

                        var ops = from operators in DirectoryDB.OperatorsInfoSet
                                  select operators.Id;
                        foreach (var item in ops)
                            propComboBox6.Items.Add(item);
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
                            SubscribersInfo subscriber = new SubscribersInfo
                            {
                                PassportData = propTextBox1.Text,
                                FullName = propTextBox2.Text,
                                Address = propTextBox3.Text
                            };
                            DirectoryDB.SubscribersInfoSet.Add(subscriber);
                            DirectoryDB.SaveChanges();
                            break;
                        }
                    case "Operators":
                        {
                            OperatorsInfo operators = new OperatorsInfo
                            {
                                Name = propTextBox1.Text,
                                Code = propTextBox2.Text,
                                AmountOfUsers = Convert.ToInt32(propTextBox3.Text)
                            };
                            DirectoryDB.OperatorsInfoSet.Add(operators);
                            DirectoryDB.SaveChanges();
                            break;
                        }
                    case "Connections":
                        {
                            int id = Convert.ToInt32(propComboBox5.Text);
                            var sub = DirectoryDB.SubscribersInfoSet.Where(subscriber => subscriber.Id == id).First();       
                            var ops = DirectoryDB.OperatorsInfoSet.Where(oper => oper.Id == id).First();
                            ConnectionsInfo connection = new ConnectionsInfo
                            {
                                PhoneNumber = propTextBox1.Text,
                                Arrear = Convert.ToDecimal(propTextBox2.Text),
                                Tariff = propTextBox3.Text,
                                InstallationDate = Convert.ToDateTime(propTextBox4.Text),
                                SubscribersInfo = sub,
                                OperatorsInfo = ops
                            };
                            DirectoryDB.ConnectionsInfoSet.Add(connection);
                            DirectoryDB.SaveChanges();
                            
                            break;
                        }
                }
                MessageBox.Show("Done", "Action", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void propComboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void propComboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void propTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void propTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void propTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void propTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void propertyLabel3_Click(object sender, EventArgs e)
        {

        }

        private void propertyLabel2_Click(object sender, EventArgs e)
        {

        }

        private void propertyLabel1_Click(object sender, EventArgs e)
        {

        }

        private void propertyLabel4_Click(object sender, EventArgs e)
        {

        }

        private void propertyLabel6_Click(object sender, EventArgs e)
        {

        }

        private void propertyLabel5_Click(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
