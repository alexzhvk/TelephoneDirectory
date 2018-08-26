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
using System.IO;

namespace Telephone_Directory
{
    public partial class mainForm : Form
    {
        private DirectoryModelContainer DirectoryDB = new DirectoryModelContainer();
        string activetable;
        string login;
        public mainForm(string login)
        {
            InitializeComponent();
            this.login = login;
            activetable = "Subscribers";
            checkStatus();
            checkActiveTable();
        }
        public void checkStatus()
        {
            string accessLevel = (from users in DirectoryDB.UsersInfoSet where users.Login == login select users.Access_level).First();
            switch (accessLevel)
            {
                case "Owner":
                    {
                        break;
                    }
                case "Admin":
                    {
                        adminPanelBtn.Enabled = adminToolStripMenuItem.Enabled = clearDatabaseToolStripMenuItem.Enabled = false;
                        break;
                    }
                case "User":
                    {
                        adminPanelBtn.Enabled = adminToolStripMenuItem.Enabled = addBtn.Enabled = deleteBtn.Enabled = updateBtn.Enabled = importBtn.Enabled = clearDatabaseToolStripMenuItem.Enabled = false;
                        break;
                    }
            }
        }
        public void checkActiveTable()
        {
            int count;
            switch (activetable)
            {
                case "Subscribers":
                    {
                        DirectoryDB.SubscribersInfoSet.Load();
                        dataGridView1.DataSource = DirectoryDB.SubscribersInfoSet.Local.ToList();
                        count = (from records in DirectoryDB.SubscribersInfoSet select records).Count();
                        toolStripTips.Text = count.ToString();
                        toolStripTips.Text = "    There are " + count + " entries in the " + activetable + " table.";
                        dataGridView1.Columns["ConnectionsInfo"].Visible = false;
                        propertyLabel1.Text = "Id";
                        propertyLabel2.Text = "Passport";
                        propertyLabel3.Text = "Full name";
                        propertyLabel4.Text = "Address";
                        propertyLabel5.Visible = propertyLabel6.Visible = propertyLabel7.Visible = false;
                        propTextBox5.Visible = propTextBox6.Visible = propTextBox7.Visible = false;
                        break;
                    }
                case "Operators":
                    {
                        DirectoryDB.OperatorsInfoSet.Load();
                        dataGridView1.DataSource = DirectoryDB.OperatorsInfoSet.Local.ToList();
                        count = (from records in DirectoryDB.OperatorsInfoSet select records).Count();
                        toolStripTips.Text = "    There are " + count + " entries in the " + activetable + " table.";
                        dataGridView1.Columns["ConnectionsInfo"].Visible = false;
                        propertyLabel1.Text = "Id";
                        propertyLabel2.Text = "Name";
                        propertyLabel3.Text = "Code";
                        propertyLabel4.Text = "Amount";
                        propertyLabel5.Visible = propertyLabel6.Visible = propertyLabel7.Visible = false;
                        propTextBox5.Visible = propTextBox6.Visible = propTextBox7.Visible = false;
                        break;
                    }
                case "Connections":
                    {
                        DirectoryDB.ConnectionsInfoSet.Load();
                        dataGridView1.DataSource = DirectoryDB.ConnectionsInfoSet.Local.ToList();
                        count = (from records in DirectoryDB.ConnectionsInfoSet select records).Count();
                        toolStripTips.Text = "    There are " + count + " entries in the " + activetable + " table.";
                        dataGridView1.Columns["SubscribersInfo"].Visible = false;
                        dataGridView1.Columns["OperatorsInfo"].Visible = false;
                        propertyLabel1.Text = "Id";
                        propertyLabel2.Text = "Phone";
                        propertyLabel3.Text = "Arrear";
                        propertyLabel4.Text = "Tariff";
                        propertyLabel5.Text = "Date";
                        propertyLabel6.Text = "SubsId";
                        propertyLabel7.Text = "OpsId";
                        propertyLabel5.Visible = propertyLabel6.Visible = propertyLabel7.Visible = true;
                        propTextBox5.Visible = propTextBox6.Visible = propTextBox7.Visible = true;
                        break;
                    }
            }
        }

        private void subscribersTableBtn_Click(object sender, EventArgs e)
        {
            activetable = "Subscribers";
            checkActiveTable();
        }

        private void connectionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            activetable = "Subscribers";
            checkActiveTable();
        }

        private void operatorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            activetable = "Operators";
            checkActiveTable();
        }

        private void operatorsTableBtn_Click(object sender, EventArgs e)
        {
            activetable = "Operators";
            checkActiveTable();
        }

        private void connectionsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            activetable = "Connections";
            checkActiveTable();
        }

        private void connectionsTableBtn_Click(object sender, EventArgs e)
        {
            activetable = "Connections";
            checkActiveTable();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            addForm addform = new addForm(activetable);
            addform.ShowDialog();
            checkActiveTable();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            int row = dataGridView1.CurrentCell.RowIndex;
            int id = Convert.ToInt32(dataGridView1[0, row].Value);
            try
            {
                switch (activetable)
                {
                    case "Subscribers":
                        {
                            var sub = DirectoryDB.SubscribersInfoSet.Find(id);
                            DirectoryDB.SubscribersInfoSet.Remove(sub);
                            break;
                        }
                    case "Operators":
                        {
                            var ops = DirectoryDB.OperatorsInfoSet.Find(id);
                            DirectoryDB.OperatorsInfoSet.Remove(ops);
                            break;
                        }
                    case "Connections":
                        {
                            var con = DirectoryDB.ConnectionsInfoSet.Find(id);
                            DirectoryDB.ConnectionsInfoSet.Remove(con);
                            break;
                        }
                }
                DialogResult dialogResult = MessageBox.Show("Delete object?", "Action", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    DirectoryDB.SaveChanges();
                    dataGridView1.Refresh();
                    MessageBox.Show("Done!", "Action", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                DialogResult dialogResult = MessageBox.Show("You have to delete connections first!Do you want to do it?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        switch (activetable)
                        {
                            case "Subscribers":
                                {
                                    var con = from o in DirectoryDB.ConnectionsInfoSet where o.SubscribersInfo.Id == id select o;
                                    DirectoryDB.ConnectionsInfoSet.RemoveRange(con);
                                    break;
                                }
                            case "Operators":
                                {
                                    var ops = from o in DirectoryDB.ConnectionsInfoSet where o.OperatorsInfo.Id == id select o;
                                    DirectoryDB.ConnectionsInfoSet.RemoveRange(ops);
                                    break;
                                }
                        }
                        DirectoryDB.SaveChanges();
                        MessageBox.Show("Done!", "Action", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception exep)
                    {
                        MessageBox.Show(exep.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            checkActiveTable();
        }

        private void clearDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Clear database?", "Action", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    var subTrunc = from c in DirectoryDB.SubscribersInfoSet select c;
                    DirectoryDB.SubscribersInfoSet.RemoveRange(subTrunc);

                    var opsTrunc = from c in DirectoryDB.OperatorsInfoSet select c;
                    DirectoryDB.OperatorsInfoSet.RemoveRange(opsTrunc);

                    var conTrunc = from c in DirectoryDB.ConnectionsInfoSet select c;
                    DirectoryDB.ConnectionsInfoSet.RemoveRange(conTrunc);

                    DirectoryDB.SaveChanges();

                    checkActiveTable();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            int row = dataGridView1.CurrentCell.RowIndex;
            int id = Convert.ToInt32(dataGridView1[0, row].Value);
            try
            {
                editForm editform = new editForm(activetable, id);
                editform.ShowDialog();
                checkActiveTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void adminPanelBtn_Click(object sender, EventArgs e)
        {
            try
            {
                administrationForm adminform = new administrationForm(login);
                adminform.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                administrationForm adminform = new administrationForm(login);
                adminform.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void filterBtn_Click(object sender, EventArgs e) //ИЗВИНЯЮСЬ ЗА ЭТОТ "ШЕДЕВР". =)
        {
            try
            {
                switch (activetable)
                {
                    case "Subscribers":
                        {
                            if (propTextBox1.Text.Length == 0)
                            {
                                dataGridView1.DataSource = DirectoryDB.SubscribersInfoSet
                                    .Where(sub => sub.PassportData.Contains(propTextBox2.Text))
                                    .Where(sub => sub.FullName.Contains(propTextBox3.Text))
                                    .Where(sub => sub.Address.Contains(propTextBox4.Text)).ToList();
                            }
                            else
                            {
                                int id = Convert.ToInt32(propTextBox1.Text);
                                dataGridView1.DataSource = DirectoryDB.SubscribersInfoSet
                                    .Where(sub => sub.Id == id)
                                    .Where(sub => sub.PassportData.Contains(propTextBox2.Text))
                                    .Where(sub => sub.FullName.Contains(propTextBox3.Text))
                                    .Where(sub => sub.Address.Contains(propTextBox4.Text)).ToList();
                            }
                            break;
                        }
                    case "Operators":
                        {
                            int amount;
                            if (propTextBox1.Text.Length == 0)
                            {
                                if (propTextBox4.Text.Length == 0)
                                {
                                    dataGridView1.DataSource = DirectoryDB.OperatorsInfoSet
                                    .Where(ops => ops.Name.Contains(propTextBox2.Text))
                                    .Where(ops => ops.Code.Contains(propTextBox3.Text))
                                    .ToList();
                                }
                                else
                                {
                                    amount = Convert.ToInt32(propTextBox4.Text);
                                    dataGridView1.DataSource = DirectoryDB.OperatorsInfoSet
                                    .Where(ops => ops.Name.Contains(propTextBox2.Text))
                                    .Where(ops => ops.Code.Contains(propTextBox3.Text))
                                    .Where(ops => ops.AmountOfUsers == amount).ToList();
                                }
                            }
                            else
                            {
                                int id = Convert.ToInt32(propTextBox1.Text);
                                if (propTextBox4.Text.Length == 0)
                                {
                                    dataGridView1.DataSource = DirectoryDB.OperatorsInfoSet
                                        .Where(ops => ops.Id == id)
                                        .Where(ops => ops.Name.Contains(propTextBox2.Text))
                                        .Where(ops => ops.Code.Contains(propTextBox3.Text))
                                        .ToList();
                                }
                                else
                                {
                                    amount = Convert.ToInt32(propTextBox4.Text);
                                    dataGridView1.DataSource = DirectoryDB.OperatorsInfoSet
                                       .Where(ops => ops.Id == id)
                                       .Where(ops => ops.Name.Contains(propTextBox2.Text))
                                       .Where(ops => ops.Code.Contains(propTextBox3.Text))
                                       .Where(ops => ops.AmountOfUsers == amount).ToList();
                                }
                            }
                            break;
                        }
                    case "Connections":
                        {
                            decimal arrear;
                            DateTime date;
                            int subId, opsId, id;
                            if (propTextBox1.Text.Length == 0)
                            {
                                if (propTextBox3.Text.Length == 0)
                                {
                                    if (propTextBox5.Text.Length == 0)
                                    {
                                        if (propTextBox6.Text.Length == 0)
                                        {
                                            if (propTextBox7.Text.Length == 0)
                                            {
                                                dataGridView1.DataSource = DirectoryDB.ConnectionsInfoSet
                                                    .Where(con => con.PhoneNumber.Contains(propTextBox2.Text))
                                                    .Where(con => con.Tariff.Contains(propTextBox4.Text))
                                                    .ToList();
                                            }
                                            else
                                            {
                                                opsId = Convert.ToInt32(propTextBox7.Text);
                                                dataGridView1.DataSource = DirectoryDB.ConnectionsInfoSet
                                                    .Where(con => con.PhoneNumber.Contains(propTextBox2.Text))
                                                    .Where(con => con.Tariff.Contains(propTextBox4.Text))
                                                    .Where(con => con.OperatorsInfo.Id == opsId)
                                                    .ToList();
                                            }
                                        }
                                        else
                                        {
                                            subId = Convert.ToInt32(propTextBox6.Text);
                                            if (propTextBox7.Text.Length == 0)
                                            {
                                                dataGridView1.DataSource = DirectoryDB.ConnectionsInfoSet
                                                    .Where(con => con.PhoneNumber.Contains(propTextBox2.Text))
                                                    .Where(con => con.Tariff.Contains(propTextBox4.Text))
                                                    .Where(con => con.SubscribersInfo.Id == subId)
                                                    .ToList();
                                            }
                                            else
                                            {
                                                opsId = Convert.ToInt32(propTextBox7.Text);
                                                dataGridView1.DataSource = DirectoryDB.ConnectionsInfoSet
                                                    .Where(con => con.PhoneNumber.Contains(propTextBox2.Text))
                                                    .Where(con => con.Tariff.Contains(propTextBox4.Text))
                                                    .Where(con => con.SubscribersInfo.Id == subId)
                                                    .Where(con => con.OperatorsInfo.Id == opsId)
                                                    .ToList();
                                            }
                                        }
                                    }
                                    else
                                    {
                                        date = Convert.ToDateTime(propTextBox5.Text);
                                        if (propTextBox6.Text.Length == 0)
                                        {
                                            if (propTextBox7.Text.Length == 0)
                                            {
                                                dataGridView1.DataSource = DirectoryDB.ConnectionsInfoSet
                                                    .Where(con => con.PhoneNumber.Contains(propTextBox2.Text))
                                                    .Where(con => con.Tariff.Contains(propTextBox4.Text))
                                                    .Where(con => con.InstallationDate == date)
                                                    .ToList();
                                            }
                                            else
                                            {
                                                opsId = Convert.ToInt32(propTextBox7.Text);
                                                dataGridView1.DataSource = DirectoryDB.ConnectionsInfoSet
                                                    .Where(con => con.PhoneNumber.Contains(propTextBox2.Text))
                                                    .Where(con => con.Tariff.Contains(propTextBox4.Text))
                                                    .Where(con => con.InstallationDate == date)
                                                    .Where(con => con.OperatorsInfo.Id == opsId)
                                                    .ToList();
                                            }
                                        }
                                        else
                                        {
                                            subId = Convert.ToInt32(propTextBox6.Text);
                                            if (propTextBox7.Text.Length == 0)
                                            {
                                                dataGridView1.DataSource = DirectoryDB.ConnectionsInfoSet
                                                    .Where(con => con.PhoneNumber.Contains(propTextBox2.Text))
                                                    .Where(con => con.Tariff.Contains(propTextBox4.Text))
                                                    .Where(con => con.InstallationDate == date)
                                                    .Where(con => con.SubscribersInfo.Id == subId)
                                                    .ToList();
                                            }
                                            else
                                            {
                                                opsId = Convert.ToInt32(propTextBox7.Text);
                                                dataGridView1.DataSource = DirectoryDB.ConnectionsInfoSet
                                                    .Where(con => con.PhoneNumber.Contains(propTextBox2.Text))
                                                    .Where(con => con.Tariff.Contains(propTextBox4.Text))
                                                    .Where(con => con.InstallationDate == date)
                                                    .Where(con => con.SubscribersInfo.Id == subId)
                                                    .Where(con => con.OperatorsInfo.Id == opsId)
                                                    .ToList();
                                            }
                                        }
                                    }
                                }
                                else
                                {
                                    arrear = Convert.ToDecimal(propTextBox3.Text);
                                    if (propTextBox5.Text.Length == 0)
                                    {
                                        if (propTextBox6.Text.Length == 0)
                                        {
                                            if (propTextBox7.Text.Length == 0)
                                            {
                                                dataGridView1.DataSource = DirectoryDB.ConnectionsInfoSet
                                                    .Where(con => con.PhoneNumber.Contains(propTextBox2.Text))
                                                    .Where(con => con.Tariff.Contains(propTextBox4.Text))
                                                    .Where(con => con.Arrear == arrear)
                                                    .ToList();
                                            }
                                            else
                                            {
                                                opsId = Convert.ToInt32(propTextBox7.Text);
                                                dataGridView1.DataSource = DirectoryDB.ConnectionsInfoSet
                                                    .Where(con => con.PhoneNumber.Contains(propTextBox2.Text))
                                                    .Where(con => con.Tariff.Contains(propTextBox4.Text))
                                                    .Where(con => con.Arrear == arrear)
                                                    .Where(con => con.OperatorsInfo.Id == opsId)
                                                    .ToList();
                                            }
                                        }
                                        else
                                        {
                                            subId = Convert.ToInt32(propTextBox6.Text);
                                            if (propTextBox7.Text.Length == 0)
                                            {
                                                dataGridView1.DataSource = DirectoryDB.ConnectionsInfoSet
                                                    .Where(con => con.PhoneNumber.Contains(propTextBox2.Text))
                                                    .Where(con => con.Tariff.Contains(propTextBox4.Text))
                                                    .Where(con => con.Arrear == arrear)
                                                    .Where(con => con.SubscribersInfo.Id == subId)
                                                    .ToList();
                                            }
                                            else
                                            {
                                                opsId = Convert.ToInt32(propTextBox7.Text);
                                                dataGridView1.DataSource = DirectoryDB.ConnectionsInfoSet
                                                    .Where(con => con.PhoneNumber.Contains(propTextBox2.Text))
                                                    .Where(con => con.Tariff.Contains(propTextBox4.Text))
                                                    .Where(con => con.Arrear == arrear)
                                                    .Where(con => con.SubscribersInfo.Id == subId)
                                                    .Where(con => con.OperatorsInfo.Id == opsId)
                                                    .ToList();
                                            }
                                        }
                                    }
                                    else
                                    {
                                        date = Convert.ToDateTime(propTextBox5.Text);
                                        if (propTextBox6.Text.Length == 0)
                                        {
                                            if (propTextBox7.Text.Length == 0)
                                            {
                                                dataGridView1.DataSource = DirectoryDB.ConnectionsInfoSet
                                                    .Where(con => con.PhoneNumber.Contains(propTextBox2.Text))
                                                    .Where(con => con.Arrear == arrear)
                                                    .Where(con => con.Tariff.Contains(propTextBox4.Text))
                                                    .Where(con => con.InstallationDate == date)
                                                    .ToList();
                                            }
                                            else
                                            {
                                                opsId = Convert.ToInt32(propTextBox7.Text);
                                                dataGridView1.DataSource = DirectoryDB.ConnectionsInfoSet
                                                    .Where(con => con.PhoneNumber.Contains(propTextBox2.Text))
                                                    .Where(con => con.Arrear == arrear)
                                                    .Where(con => con.Tariff.Contains(propTextBox4.Text))
                                                    .Where(con => con.InstallationDate == date)
                                                    .Where(con => con.OperatorsInfo.Id == opsId)
                                                    .ToList();
                                            }
                                        }
                                        else
                                        {
                                            subId = Convert.ToInt32(propTextBox6.Text);
                                            if (propTextBox7.Text.Length == 0)
                                            {
                                                dataGridView1.DataSource = DirectoryDB.ConnectionsInfoSet
                                                    .Where(con => con.PhoneNumber.Contains(propTextBox2.Text))
                                                    .Where(con => con.Arrear == arrear)
                                                    .Where(con => con.Tariff.Contains(propTextBox4.Text))
                                                    .Where(con => con.InstallationDate == date)
                                                    .Where(con => con.SubscribersInfo.Id == subId)
                                                    .ToList();
                                            }
                                            else
                                            {
                                                opsId = Convert.ToInt32(propTextBox7.Text);
                                                dataGridView1.DataSource = DirectoryDB.ConnectionsInfoSet
                                                    .Where(con => con.PhoneNumber.Contains(propTextBox2.Text))
                                                    .Where(con => con.Tariff.Contains(propTextBox4.Text))
                                                    .Where(con => con.Arrear == arrear)
                                                    .Where(con => con.InstallationDate == date)
                                                    .Where(con => con.SubscribersInfo.Id == subId)
                                                    .Where(con => con.OperatorsInfo.Id == opsId)
                                                    .ToList();
                                            }
                                        }
                                    }
                                }
                            }
                            else
                            {
                                id = Convert.ToInt32(propTextBox1.Text);
                                if (propTextBox3.Text.Length == 0)
                                {
                                    if (propTextBox5.Text.Length == 0)
                                    {
                                        if (propTextBox6.Text.Length == 0)
                                        {
                                            if (propTextBox7.Text.Length == 0)
                                            {
                                                dataGridView1.DataSource = DirectoryDB.ConnectionsInfoSet
                                                    .Where(con => con.Id == id)
                                                    .Where(con => con.PhoneNumber.Contains(propTextBox2.Text))
                                                    .Where(con => con.Tariff.Contains(propTextBox4.Text))
                                                    .ToList();
                                            }
                                            else
                                            {
                                                opsId = Convert.ToInt32(propTextBox7.Text);
                                                dataGridView1.DataSource = DirectoryDB.ConnectionsInfoSet
                                                    .Where(con => con.Id == id)
                                                    .Where(con => con.PhoneNumber.Contains(propTextBox2.Text))
                                                    .Where(con => con.Tariff.Contains(propTextBox4.Text))
                                                    .Where(con => con.OperatorsInfo.Id == opsId)
                                                    .ToList();
                                            }
                                        }
                                        else
                                        {
                                            subId = Convert.ToInt32(propTextBox6.Text);
                                            if (propTextBox7.Text.Length == 0)
                                            {
                                                dataGridView1.DataSource = DirectoryDB.ConnectionsInfoSet
                                                    .Where(con => con.Id == id)
                                                    .Where(con => con.PhoneNumber.Contains(propTextBox2.Text))
                                                    .Where(con => con.Tariff.Contains(propTextBox4.Text))
                                                    .Where(con => con.SubscribersInfo.Id == subId)
                                                    .ToList();
                                            }
                                            else
                                            {
                                                opsId = Convert.ToInt32(propTextBox7.Text);
                                                dataGridView1.DataSource = DirectoryDB.ConnectionsInfoSet
                                                    .Where(con => con.Id == id)
                                                    .Where(con => con.PhoneNumber.Contains(propTextBox2.Text))
                                                    .Where(con => con.Tariff.Contains(propTextBox4.Text))
                                                    .Where(con => con.SubscribersInfo.Id == subId)
                                                    .Where(con => con.OperatorsInfo.Id == opsId)
                                                    .ToList();
                                            }
                                        }
                                    }
                                    else
                                    {
                                        date = Convert.ToDateTime(propTextBox5.Text);
                                        if (propTextBox6.Text.Length == 0)
                                        {
                                            if (propTextBox7.Text.Length == 0)
                                            {
                                                dataGridView1.DataSource = DirectoryDB.ConnectionsInfoSet
                                                    .Where(con => con.Id == id)
                                                    .Where(con => con.PhoneNumber.Contains(propTextBox2.Text))
                                                    .Where(con => con.Tariff.Contains(propTextBox4.Text))
                                                    .Where(con => con.InstallationDate == date)
                                                    .ToList();
                                            }
                                            else
                                            {
                                                opsId = Convert.ToInt32(propTextBox7.Text);
                                                dataGridView1.DataSource = DirectoryDB.ConnectionsInfoSet
                                                    .Where(con => con.Id == id)
                                                    .Where(con => con.PhoneNumber.Contains(propTextBox2.Text))
                                                    .Where(con => con.Tariff.Contains(propTextBox4.Text))
                                                    .Where(con => con.InstallationDate == date)
                                                    .Where(con => con.OperatorsInfo.Id == opsId)
                                                    .ToList();
                                            }
                                        }
                                        else
                                        {
                                            subId = Convert.ToInt32(propTextBox6.Text);
                                            if (propTextBox7.Text.Length == 0)
                                            {
                                                dataGridView1.DataSource = DirectoryDB.ConnectionsInfoSet
                                                    .Where(con => con.Id == id)
                                                    .Where(con => con.PhoneNumber.Contains(propTextBox2.Text))
                                                    .Where(con => con.Tariff.Contains(propTextBox4.Text))
                                                    .Where(con => con.InstallationDate == date)
                                                    .Where(con => con.SubscribersInfo.Id == subId)
                                                    .ToList();
                                            }
                                            else
                                            {
                                                opsId = Convert.ToInt32(propTextBox7.Text);
                                                dataGridView1.DataSource = DirectoryDB.ConnectionsInfoSet
                                                    .Where(con => con.Id == id)
                                                    .Where(con => con.PhoneNumber.Contains(propTextBox2.Text))
                                                    .Where(con => con.Tariff.Contains(propTextBox4.Text))
                                                    .Where(con => con.InstallationDate == date)
                                                    .Where(con => con.SubscribersInfo.Id == subId)
                                                    .Where(con => con.OperatorsInfo.Id == opsId)
                                                    .ToList();
                                            }
                                        }
                                    }
                                }
                                else
                                {
                                    arrear = Convert.ToDecimal(propTextBox3.Text);
                                    if (propTextBox5.Text.Length == 0)
                                    {
                                        if (propTextBox6.Text.Length == 0)
                                        {
                                            if (propTextBox7.Text.Length == 0)
                                            {
                                                dataGridView1.DataSource = DirectoryDB.ConnectionsInfoSet
                                                    .Where(con => con.Id == id)
                                                    .Where(con => con.PhoneNumber.Contains(propTextBox2.Text))
                                                    .Where(con => con.Tariff.Contains(propTextBox4.Text))
                                                    .Where(con => con.Arrear == arrear)
                                                    .ToList();
                                            }
                                            else
                                            {
                                                opsId = Convert.ToInt32(propTextBox7.Text);
                                                dataGridView1.DataSource = DirectoryDB.ConnectionsInfoSet
                                                    .Where(con => con.Id == id)
                                                    .Where(con => con.PhoneNumber.Contains(propTextBox2.Text))
                                                    .Where(con => con.Tariff.Contains(propTextBox4.Text))
                                                    .Where(con => con.Arrear == arrear)
                                                    .Where(con => con.OperatorsInfo.Id == opsId)
                                                    .ToList();
                                            }
                                        }
                                        else
                                        {
                                            subId = Convert.ToInt32(propTextBox6.Text);
                                            if (propTextBox7.Text.Length == 0)
                                            {
                                                dataGridView1.DataSource = DirectoryDB.ConnectionsInfoSet
                                                    .Where(con => con.Id == id)
                                                    .Where(con => con.PhoneNumber.Contains(propTextBox2.Text))
                                                    .Where(con => con.Tariff.Contains(propTextBox4.Text))
                                                    .Where(con => con.Arrear == arrear)
                                                    .Where(con => con.SubscribersInfo.Id == subId)
                                                    .ToList();
                                            }
                                            else
                                            {
                                                opsId = Convert.ToInt32(propTextBox7.Text);
                                                dataGridView1.DataSource = DirectoryDB.ConnectionsInfoSet
                                                    .Where(con => con.Id == id)
                                                    .Where(con => con.PhoneNumber.Contains(propTextBox2.Text))
                                                    .Where(con => con.Tariff.Contains(propTextBox4.Text))
                                                    .Where(con => con.Arrear == arrear)
                                                    .Where(con => con.SubscribersInfo.Id == subId)
                                                    .Where(con => con.OperatorsInfo.Id == opsId)
                                                    .ToList();
                                            }
                                        }
                                    }
                                    else
                                    {
                                        date = Convert.ToDateTime(propTextBox5.Text);
                                        if (propTextBox6.Text.Length == 0)
                                        {
                                            if (propTextBox7.Text.Length == 0)
                                            {
                                                dataGridView1.DataSource = DirectoryDB.ConnectionsInfoSet
                                                    .Where(con => con.Id == id)
                                                    .Where(con => con.PhoneNumber.Contains(propTextBox2.Text))
                                                    .Where(con => con.Arrear == arrear)
                                                    .Where(con => con.Tariff.Contains(propTextBox4.Text))
                                                    .Where(con => con.InstallationDate == date)
                                                    .ToList();
                                            }
                                            else
                                            {
                                                opsId = Convert.ToInt32(propTextBox7.Text);
                                                dataGridView1.DataSource = DirectoryDB.ConnectionsInfoSet
                                                    .Where(con => con.Id == id)
                                                    .Where(con => con.PhoneNumber.Contains(propTextBox2.Text))
                                                    .Where(con => con.Arrear == arrear)
                                                    .Where(con => con.Tariff.Contains(propTextBox4.Text))
                                                    .Where(con => con.InstallationDate == date)
                                                    .Where(con => con.OperatorsInfo.Id == opsId)
                                                    .ToList();
                                            }
                                        }
                                        else
                                        {
                                            subId = Convert.ToInt32(propTextBox6.Text);
                                            if (propTextBox7.Text.Length == 0)
                                            {
                                                dataGridView1.DataSource = DirectoryDB.ConnectionsInfoSet
                                                    .Where(con => con.Id == id)
                                                    .Where(con => con.PhoneNumber.Contains(propTextBox2.Text))
                                                    .Where(con => con.Arrear == arrear)
                                                    .Where(con => con.Tariff.Contains(propTextBox4.Text))
                                                    .Where(con => con.InstallationDate == date)
                                                    .Where(con => con.SubscribersInfo.Id == subId)
                                                    .ToList();
                                            }
                                            else
                                            {
                                                opsId = Convert.ToInt32(propTextBox7.Text);
                                                dataGridView1.DataSource = DirectoryDB.ConnectionsInfoSet
                                                    .Where(con => con.Id == id)
                                                    .Where(con => con.PhoneNumber.Contains(propTextBox2.Text))
                                                    .Where(con => con.Tariff.Contains(propTextBox4.Text))
                                                    .Where(con => con.Arrear == arrear)
                                                    .Where(con => con.InstallationDate == date)
                                                    .Where(con => con.SubscribersInfo.Id == subId)
                                                    .Where(con => con.OperatorsInfo.Id == opsId)
                                                    .ToList();
                                            }
                                        }
                                    }
                                }
                            }
                            break;
                        }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteFiltersBtn_Click(object sender, EventArgs e)
        {
            checkActiveTable();
            propTextBox1.Text = propTextBox2.Text = propTextBox3.Text = propTextBox4.Text = propTextBox5.Text = propTextBox6.Text = propTextBox7.Text = "";
        }

        private void importBtn_Click(object sender, EventArgs e)
        {
            string line;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "txt files (*.txt)|*.txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    switch (activetable)
                    {
                        case "Subscribers":
                            {
                                StreamReader sr = new StreamReader(ofd.OpenFile());
                                line = sr.ReadLine();
                                while (line != null)
                                {
                                    string[] values = line.Split('\t');
                                    SubscribersInfo subscriber = new SubscribersInfo
                                    {
                                        PassportData = values[0],
                                        FullName = values[1],
                                        Address = values[2]
                                    };
                                    DirectoryDB.SubscribersInfoSet.Add(subscriber);
                                    line = sr.ReadLine();
                                }
                                DirectoryDB.SaveChanges();
                                sr.Close();
                                MessageBox.Show("Done!", "Action", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                            }
                        case "Operators":
                            {
                                StreamReader sr = new StreamReader(ofd.OpenFile());
                                line = sr.ReadLine();
                                while (line != null)
                                {
                                    string[] values = line.Split('\t');
                                    OperatorsInfo operators = new OperatorsInfo
                                    {
                                        Name = values[0],
                                        Code = values[1],
                                        AmountOfUsers = Convert.ToInt32(values[2])
                                    };
                                    DirectoryDB.OperatorsInfoSet.Add(operators);
                                    line = sr.ReadLine();
                                }
                                DirectoryDB.SaveChanges();
                                sr.Close();
                                MessageBox.Show("Done!", "Action", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                            }
                        case "Connections":
                            {
                                StreamReader sr = new StreamReader(ofd.OpenFile());
                                line = sr.ReadLine();
                                while (line != null)
                                {
                                    string[] values = line.Split('\t');
                                    int s = Convert.ToInt32(values[4]);
                                    var sub = DirectoryDB.SubscribersInfoSet.Where(subscriber => subscriber.Id == s).First();
                                    int o = Convert.ToInt32(values[5]);
                                    var ops = DirectoryDB.OperatorsInfoSet.Where(oper => oper.Id == o).First();
                                    decimal arrear = Convert.ToDecimal(values[1]);
                                    DateTime date = Convert.ToDateTime(values[3]);
                                    ConnectionsInfo connect = new ConnectionsInfo
                                    {
                                        PhoneNumber = values[0],
                                        Arrear = arrear,
                                        Tariff = values[2],
                                        InstallationDate = date,
                                        SubscribersInfo = sub,
                                        OperatorsInfo = ops
                                    };
                                    DirectoryDB.ConnectionsInfoSet.Add(connect);
                                    line = sr.ReadLine();
                                }
                                DirectoryDB.SaveChanges();
                                sr.Close();
                                MessageBox.Show("Done!", "Action", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                            }
                    }
                    checkActiveTable();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            helpForm helpform = new helpForm();
            helpform.ShowDialog();
        }
    }
}
